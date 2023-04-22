
namespace TI2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            открытьЗашифрованныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            сохранитьИсходныйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pTB = new System.Windows.Forms.TextBox();
            encipherButton = new System.Windows.Forms.Button();
            plaintextRTB = new System.Windows.Forms.RichTextBox();
            ciphertextRTB = new System.Windows.Forms.RichTextBox();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            qTB = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            closekeyTB = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            openkeyTB = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            decipherButton = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1603, 47);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, открытьЗашифрованныйToolStripMenuItem, saveToolStripMenuItem, сохранитьИсходныйФайлToolStripMenuItem });
            fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(87, 43);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(470, 48);
            openToolStripMenuItem.Text = "Open file";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // открытьЗашифрованныйToolStripMenuItem
            // 
            открытьЗашифрованныйToolStripMenuItem.Name = "открытьЗашифрованныйToolStripMenuItem";
            открытьЗашифрованныйToolStripMenuItem.Size = new System.Drawing.Size(470, 48);
            открытьЗашифрованныйToolStripMenuItem.Text = "Open encrypted file";
            открытьЗашифрованныйToolStripMenuItem.Click += открытьЗашифрованныйToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(470, 48);
            saveToolStripMenuItem.Text = "Save encrypted file";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // сохранитьИсходныйФайлToolStripMenuItem
            // 
            сохранитьИсходныйФайлToolStripMenuItem.Enabled = false;
            сохранитьИсходныйФайлToolStripMenuItem.Name = "сохранитьИсходныйФайлToolStripMenuItem";
            сохранитьИсходныйФайлToolStripMenuItem.Size = new System.Drawing.Size(470, 48);
            сохранитьИсходныйФайлToolStripMenuItem.Text = "Save file";
            сохранитьИсходныйФайлToolStripMenuItem.Click += сохранитьИсходныйФайлToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(185, 357);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(205, 55);
            label2.TabIndex = 2;
            label2.Text = "Plaintext";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(1011, 357);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(260, 55);
            label3.TabIndex = 3;
            label3.Text = "Cyphertext";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(185, 115);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(46, 45);
            label4.TabIndex = 4;
            label4.Text = "p";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTB
            // 
            pTB.BackColor = System.Drawing.SystemColors.Window;
            pTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            pTB.ForeColor = System.Drawing.Color.Black;
            pTB.Location = new System.Drawing.Point(22, 163);
            pTB.MaxLength = 36;
            pTB.Name = "pTB";
            pTB.Size = new System.Drawing.Size(367, 47);
            pTB.TabIndex = 0;
            // 
            // encipherButton
            // 
            encipherButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            encipherButton.Location = new System.Drawing.Point(147, 760);
            encipherButton.Name = "encipherButton";
            encipherButton.Size = new System.Drawing.Size(383, 48);
            encipherButton.TabIndex = 10;
            encipherButton.Text = "Encrypt";
            encipherButton.UseVisualStyleBackColor = true;
            encipherButton.Click += encipherButton_Click;
            // 
            // plaintextRTB
            // 
            plaintextRTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            plaintextRTB.Location = new System.Drawing.Point(22, 433);
            plaintextRTB.Name = "plaintextRTB";
            plaintextRTB.ReadOnly = true;
            plaintextRTB.Size = new System.Drawing.Size(686, 287);
            plaintextRTB.TabIndex = 13;
            plaintextRTB.Text = "";
            // 
            // ciphertextRTB
            // 
            ciphertextRTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ciphertextRTB.Location = new System.Drawing.Point(753, 433);
            ciphertextRTB.Name = "ciphertextRTB";
            ciphertextRTB.ReadOnly = true;
            ciphertextRTB.Size = new System.Drawing.Size(733, 287);
            ciphertextRTB.TabIndex = 14;
            ciphertextRTB.Text = "";
            // 
            // qTB
            // 
            qTB.BackColor = System.Drawing.SystemColors.Window;
            qTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            qTB.ForeColor = System.Drawing.Color.Black;
            qTB.Location = new System.Drawing.Point(395, 163);
            qTB.MaxLength = 36;
            qTB.Name = "qTB";
            qTB.Size = new System.Drawing.Size(367, 47);
            qTB.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(526, 115);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 45);
            label6.TabIndex = 16;
            label6.Text = "q";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closekeyTB
            // 
            closekeyTB.BackColor = System.Drawing.SystemColors.Window;
            closekeyTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            closekeyTB.ForeColor = System.Drawing.Color.Black;
            closekeyTB.Location = new System.Drawing.Point(768, 163);
            closekeyTB.MaxLength = 36;
            closekeyTB.Name = "closekeyTB";
            closekeyTB.Size = new System.Drawing.Size(367, 47);
            closekeyTB.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(780, 115);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(278, 45);
            label7.TabIndex = 18;
            label7.Text = "Private key(d)";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openkeyTB
            // 
            openkeyTB.BackColor = System.Drawing.SystemColors.Window;
            openkeyTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            openkeyTB.ForeColor = System.Drawing.Color.Black;
            openkeyTB.Location = new System.Drawing.Point(578, 296);
            openkeyTB.MaxLength = 36;
            openkeyTB.Name = "openkeyTB";
            openkeyTB.Size = new System.Drawing.Size(367, 47);
            openkeyTB.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(633, 237);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(210, 45);
            label5.TabIndex = 21;
            label5.Text = "Public key";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decipherButton
            // 
            decipherButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            decipherButton.Location = new System.Drawing.Point(969, 760);
            decipherButton.Name = "decipherButton";
            decipherButton.Size = new System.Drawing.Size(383, 48);
            decipherButton.TabIndex = 23;
            decipherButton.Text = "Decrypt";
            decipherButton.UseVisualStyleBackColor = true;
            decipherButton.Click += decipherButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1603, 911);
            Controls.Add(decipherButton);
            Controls.Add(openkeyTB);
            Controls.Add(label5);
            Controls.Add(closekeyTB);
            Controls.Add(label7);
            Controls.Add(qTB);
            Controls.Add(label6);
            Controls.Add(ciphertextRTB);
            Controls.Add(plaintextRTB);
            Controls.Add(encipherButton);
            Controls.Add(pTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LFSR";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pTB;
        private System.Windows.Forms.Button encipherButton;
        private System.Windows.Forms.RichTextBox plaintextRTB;
        private System.Windows.Forms.RichTextBox ciphertextRTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox qTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox closekeyTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox openkeyTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button decipherButton;
        private System.Windows.Forms.ToolStripMenuItem открытьЗашифрованныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИсходныйФайлToolStripMenuItem;
    }
}

