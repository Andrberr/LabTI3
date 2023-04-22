using System;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace TI2
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        const int ITERATIONS = 50;
        const int MAX_MODULE = 65535;

        class RSAKeyPair
        {
            public BigInteger e;
            public BigInteger n;
            public override string ToString()
            {
                return "(" + e.ToString() + ", " + n.ToString() + ")";
            }
        }

        public static bool IsPrime(BigInteger n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            Random rand = new Random();

            for (int i = 0; i < ITERATIONS; i++)
            {
                BigInteger a = RandomBigInteger(2, n - 1, rand);
                if (BigInteger.ModPow(a, n - 1, n) != 1)   // a^(n-1) mod n для всех = 1 , значит простое
                {
                    return false;
                }
            }

            return true;
        }

        private static BigInteger RandomBigInteger(BigInteger min, BigInteger max, Random rand)
        {
            BigInteger result;
            do
            {
                byte[] bytes = new byte[max.ToByteArray().Length];
                rand.NextBytes(bytes);
                result = new BigInteger(bytes);
            } while (result < min || result >= max);

            return result;
        }

        static bool AreCoprime(BigInteger a, BigInteger b)
        {
            BigInteger r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }

            return a == 1;
        }

        private bool IsCorrect(BigInteger p, BigInteger q, BigInteger d, BigInteger elerFun, BigInteger n)
        {
            if (!IsPrime(p))
            {
                MessageBox.Show("Error: p is not simple.");
                return false;
            }
            if (!IsPrime(q))
            {
                MessageBox.Show("Error: q is not simple.");
                return false;
            }
            if (d <= 1 || d > elerFun)
            {
                MessageBox.Show($"Error: key must be > 1 and < {elerFun}.");
                return false;
            }
            if (!AreCoprime(d, elerFun))
            {
                MessageBox.Show($"Error: ket must be mutually simple with Eler Fun");
                return false;
            }
            if (n >= MAX_MODULE)
            {
                MessageBox.Show($"Error:  n = p * q = {n} must be less than {MAX_MODULE}.");
                return false;
            }
            return true;
        }

        private void encipherButton_Click(object sender, EventArgs eventArgs)
        {
            if (plaintextRTB.Text == "")
                return;
            if (!BigInteger.TryParse(pTB.Text, out BigInteger p))
            {
                MessageBox.Show("Error: p must be integer.");
                return;
            }
            if (!BigInteger.TryParse(qTB.Text, out BigInteger q))
            {
                MessageBox.Show("Error: q must be integer");
                return;
            }
            if (!BigInteger.TryParse(closekeyTB.Text, out BigInteger d))
            {
                MessageBox.Show("Error: d must be integer");
                return;
            }
            BigInteger n = p * q;
            BigInteger elerFun = (p - 1) * (q - 1);
            if (!IsCorrect(p, q, d, elerFun, n))
                return;
            BigInteger e = ModInverse(elerFun, d);
            RSAKeyPair openKey = new() { e = e, n = n };
            openkeyTB.Text = openKey.ToString();
            // Шифрование
            byte[] inputFileBytes = GetBytes(plaintextRTB);
            BigInteger[] encryptedInts = new BigInteger[inputFileBytes.Length];
            for (int i = 0; i < inputFileBytes.Length; i++)
            {
                BigInteger m = new(inputFileBytes[i]);
                BigInteger c = FastExponentiation(m, e, n);
                encryptedInts[i] = c;
            }
            OutputEncryptedNums(encryptedInts, ciphertextRTB);
            saveToolStripMenuItem.Enabled = true;
            сохранитьИсходныйФайлToolStripMenuItem.Enabled = true;
        }

        private void decipherButton_Click(object sender, EventArgs eventArgs)
        {
            if (ciphertextRTB.Text == "")
                return;
            if (!BigInteger.TryParse(pTB.Text, out BigInteger p))
            {
                MessageBox.Show("Error: p must be integer.");
                return;
            }
            if (!BigInteger.TryParse(qTB.Text, out BigInteger q))
            {
                MessageBox.Show("Error: q must be integer.");
                return;
            }
            if (!BigInteger.TryParse(closekeyTB.Text, out BigInteger d))
            {
                MessageBox.Show("Error: d must be integer.");
                return;
            }
            BigInteger n = p * q;
            BigInteger elerFun = (p - 1) * (q - 1);
            if (!IsCorrect(p, q, d, elerFun, n))
                return;
            //Дешифрование
            BigInteger[] inputFileBytes = GetInts(ciphertextRTB);
            BigInteger[] decryptedInts = new BigInteger[inputFileBytes.Length];
            for (int i = 0; i < inputFileBytes.Length; i++)
            {
                BigInteger m = inputFileBytes[i];
                BigInteger c = FastExponentiation(m, d, n);
                decryptedInts[i] = c;
            }
            OutputEncryptedNums(decryptedInts, plaintextRTB);
            saveToolStripMenuItem.Enabled = true;
            сохранитьИсходныйФайлToolStripMenuItem.Enabled = true;
        }


        static BigInteger ModInverse(BigInteger a, BigInteger b)
        {
            BigInteger q, a0 = a, a1 = b, x0 = 1, x1 = 0, y0 = 0, y1 = 1;
            while (a1 > 1)
            {
                q = a0 / a1;
                BigInteger a2 = a0 % a1;
                BigInteger x2 = x0 - q * x1;
                BigInteger y2 = y0 - q * y1;
                a0 = a1;
                a1 = a2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }
            if (y1 >= 0) return y1;
            else return y1 + a;
        }

        static BigInteger FastExponentiation(BigInteger a, BigInteger z, BigInteger n)
        {
            BigInteger a1 = a;
            BigInteger z1 = z;
            BigInteger x = 1;
            while (z1 != 0)
            {
                while (z1 % 2 == 0)
                {
                    z1 /= 2;
                    a1 = (a1 * a1) % n;
                }
                z1--;
                x = (x * a1) % n;
            }
            return x;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            plaintextRTB.Text = ReadFileBits(filename);
            ciphertextRTB.Text = "";
            openkeyTB.Text = "";
            saveToolStripMenuItem.Enabled = false;
            сохранитьИсходныйФайлToolStripMenuItem.Enabled = false;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            byte[] bytes = ConvertToByteArray(ciphertextRTB.Text);
            File.WriteAllBytes(filename, bytes);
        }

        private void открытьЗашифрованныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            ciphertextRTB.Text = ReadBytesFromFile(filename);
            plaintextRTB.Text = "";
            openkeyTB.Text = "";
            saveToolStripMenuItem.Enabled = false;
            сохранитьИсходныйФайлToolStripMenuItem.Enabled = false;
        }

        private void сохранитьИсходныйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            byte[] bytes = GetBytes(plaintextRTB);
            File.WriteAllBytes(filename, bytes);
        }

        public static byte[] ConvertToByteArray(string input)
        {
            string[] numbers = input.Trim().Split(' ');
            byte[] result = new byte[numbers.Length * 2];
            for (int i = 0; i < numbers.Length; i++)
            {
                ushort number;
                if (ushort.TryParse(numbers[i], out number))
                {
                    byte[] bytes = BitConverter.GetBytes(number);
                    Buffer.BlockCopy(bytes, 0, result, i * 2, 2);
                }
                else
                {
                    throw new ArgumentException($"Невозможно преобразовать число {numbers[i]} в массив байт.");
                }
            }
            return result;
        }

        private byte[] GetBytes(RichTextBox textRTB)
        {
            string plaintext = textRTB.Text.Trim();
            string[] numbers = plaintext.Split(' ');
            byte[] result = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (byte.TryParse(numbers[i], out byte b))
                {
                    result[i] = b;
                }
                else
                {
                    throw new ArgumentException($"Не удалось преобразовать число {numbers[i]} в байт.");
                }
            }
            return result;
        }

        private BigInteger[] GetInts(RichTextBox textRTB)
        {
            string plaintext = textRTB.Text.Trim();
            string[] numbers = plaintext.Split(' ');
            BigInteger[] result = new BigInteger[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (BigInteger.TryParse(numbers[i], out BigInteger b))
                {
                    result[i] = b;
                }
                else
                {
                    throw new ArgumentException($"Не удалось преобразовать число {numbers[i]} в байт.");
                }
            }
            return result;
        }

        private string ReadFileBits(string filePath)
        {
            var result = new StringBuilder();
            using (FileStream stream = File.OpenRead(filePath))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        result.Append(Convert.ToString(buffer[i]) + " ");
                    }
                }
            }
            return result.ToString();
        }

        private void OutputEncryptedNums(BigInteger[] encryptedInts, RichTextBox richTextBox)
        {
            var sb = new StringBuilder();
            foreach (BigInteger b in encryptedInts)
            {
                sb.Append($"{b} ");
            }
            richTextBox.Text = sb.ToString();
        }

        static string ReadBytesFromFile(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            StringBuilder result = new();
            for (int i = 0; i < bytes.Length; i += 2)
            {
                if (i + 1 >= bytes.Length) break;
                byte[] twoBytes = new byte[2];
                twoBytes[0] = bytes[i];
                twoBytes[1] = bytes[i + 1];
                ushort number = BitConverter.ToUInt16(twoBytes, 0);
                result.Append(number + " ");
            }
            return result.ToString().Trim();
        }
    }
}
