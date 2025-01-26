namespace Exercise_5
{
    partial class Form1
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
            lblCipherSecretWord = new Label();
            lblInputText = new Label();
            lblOutputText = new Label();
            txtCipherSecretWord = new TextBox();
            txtInputText = new TextBox();
            txtOutputText = new TextBox();
            btnTranslateText = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblCipherSecretWord
            // 
            lblCipherSecretWord.AutoSize = true;
            lblCipherSecretWord.Location = new Point(79, 55);
            lblCipherSecretWord.Name = "lblCipherSecretWord";
            lblCipherSecretWord.Size = new Size(122, 15);
            lblCipherSecretWord.TabIndex = 0;
            lblCipherSecretWord.Text = "Cipher \"Secret\" Word:";
            // 
            // lblInputText
            // 
            lblInputText.AutoSize = true;
            lblInputText.Location = new Point(83, 122);
            lblInputText.Name = "lblInputText";
            lblInputText.RightToLeft = RightToLeft.Yes;
            lblInputText.Size = new Size(59, 15);
            lblInputText.TabIndex = 1;
            lblInputText.Text = "Input Text";
            
            // 
            // lblOutputText
            // 
            lblOutputText.AutoSize = true;
            lblOutputText.Location = new Point(83, 178);
            lblOutputText.Name = "lblOutputText";
            lblOutputText.Size = new Size(72, 15);
            lblOutputText.TabIndex = 2;
            lblOutputText.Text = "Output Text:";
            // 
            // txtCipherSecretWord
            // 
            txtCipherSecretWord.Location = new Point(210, 55);
            txtCipherSecretWord.Name = "txtCipherSecretWord";
            txtCipherSecretWord.Size = new Size(100, 23);
            txtCipherSecretWord.TabIndex = 3;
            // 
            // txtInputText
            // 
            txtInputText.Location = new Point(210, 119);
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(478, 23);
            txtInputText.TabIndex = 4;
            // 
            // txtOutputText
            // 
            txtOutputText.Location = new Point(210, 175);
            txtOutputText.Name = "txtOutputText";
            txtOutputText.Size = new Size(478, 23);
            txtOutputText.TabIndex = 5;
            // 
            // btnTranslateText
            // 
            btnTranslateText.Location = new Point(37, 330);
            btnTranslateText.Name = "btnTranslateText";
            btnTranslateText.Size = new Size(104, 23);
            btnTranslateText.TabIndex = 6;
            btnTranslateText.Text = "Translate Text";
            btnTranslateText.UseVisualStyleBackColor = true;
            btnTranslateText.Click += btnTranslateText_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(165, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(683, 330);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnTranslateText);
            Controls.Add(txtOutputText);
            Controls.Add(txtInputText);
            Controls.Add(txtCipherSecretWord);
            Controls.Add(lblOutputText);
            Controls.Add(lblInputText);
            Controls.Add(lblCipherSecretWord);
            Name = "Form1";
            Text = "Code Translator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCipherSecretWord;
        private Label lblInputText;
        private Label lblOutputText;
        private TextBox txtCipherSecretWord;
        private TextBox txtInputText;
        private TextBox txtOutputText;
        private Button btnTranslateText;
        private Button btnClear;
        private Button btnClose;
    }
}
