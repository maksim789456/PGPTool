namespace PGPFileTool
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroRadioButtonEncrypt = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonDecrypt = new MetroFramework.Controls.MetroRadioButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroButtonWork = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonKeyGenerator = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxInputFilePath = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonInputFileOpen = new MetroFramework.Controls.MetroButton();
            this.metroButtonOutputFileSelect = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxOutputFilePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonPublicKeyOpen = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPublicKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonPrivateKeyOpen = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPrivateKey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialogInputFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogPublicKey = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPrivateKey = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.metroCheckBoxArmor = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxIntegrityCheck = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPasswordPGP = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroRadioButtonEncrypt
            // 
            this.metroRadioButtonEncrypt.AutoSize = true;
            this.metroRadioButtonEncrypt.Location = new System.Drawing.Point(111, 63);
            this.metroRadioButtonEncrypt.Name = "metroRadioButtonEncrypt";
            this.metroRadioButtonEncrypt.Size = new System.Drawing.Size(63, 15);
            this.metroRadioButtonEncrypt.TabIndex = 0;
            this.metroRadioButtonEncrypt.Text = "Encrypt";
            this.metroRadioButtonEncrypt.UseSelectable = true;
            this.metroRadioButtonEncrypt.CheckedChanged += new System.EventHandler(this.metroRadioButton_CheckedChanged);
            // 
            // metroRadioButtonDecrypt
            // 
            this.metroRadioButtonDecrypt.AutoSize = true;
            this.metroRadioButtonDecrypt.Location = new System.Drawing.Point(180, 63);
            this.metroRadioButtonDecrypt.Name = "metroRadioButtonDecrypt";
            this.metroRadioButtonDecrypt.Size = new System.Drawing.Size(64, 15);
            this.metroRadioButtonDecrypt.TabIndex = 1;
            this.metroRadioButtonDecrypt.Text = "Decrypt";
            this.metroRadioButtonDecrypt.UseSelectable = true;
            this.metroRadioButtonDecrypt.CheckedChanged += new System.EventHandler(this.metroRadioButton_CheckedChanged);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(23, 284);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(101, 51);
            this.metroButtonClear.TabIndex = 16;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // metroButtonWork
            // 
            this.metroButtonWork.Enabled = false;
            this.metroButtonWork.Location = new System.Drawing.Point(237, 284);
            this.metroButtonWork.Name = "metroButtonWork";
            this.metroButtonWork.Size = new System.Drawing.Size(122, 51);
            this.metroButtonWork.TabIndex = 17;
            this.metroButtonWork.Text = "Select work mode";
            this.metroButtonWork.UseSelectable = true;
            this.metroButtonWork.Click += new System.EventHandler(this.metroButtonWork_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Work Mode:";
            // 
            // metroButtonKeyGenerator
            // 
            this.metroButtonKeyGenerator.Location = new System.Drawing.Point(130, 284);
            this.metroButtonKeyGenerator.Name = "metroButtonKeyGenerator";
            this.metroButtonKeyGenerator.Size = new System.Drawing.Size(101, 51);
            this.metroButtonKeyGenerator.TabIndex = 19;
            this.metroButtonKeyGenerator.Text = "Key Generator";
            this.metroButtonKeyGenerator.UseSelectable = true;
            this.metroButtonKeyGenerator.Click += new System.EventHandler(this.metroButtonKeyGenerator_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Input File Path:";
            // 
            // metroTextBoxInputFilePath
            // 
            // 
            // 
            // 
            this.metroTextBoxInputFilePath.CustomButton.Image = null;
            this.metroTextBoxInputFilePath.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.metroTextBoxInputFilePath.CustomButton.Name = "";
            this.metroTextBoxInputFilePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxInputFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxInputFilePath.CustomButton.TabIndex = 1;
            this.metroTextBoxInputFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxInputFilePath.CustomButton.UseSelectable = true;
            this.metroTextBoxInputFilePath.CustomButton.Visible = false;
            this.metroTextBoxInputFilePath.Lines = new string[0];
            this.metroTextBoxInputFilePath.Location = new System.Drawing.Point(135, 94);
            this.metroTextBoxInputFilePath.MaxLength = 32767;
            this.metroTextBoxInputFilePath.Name = "metroTextBoxInputFilePath";
            this.metroTextBoxInputFilePath.PasswordChar = '\0';
            this.metroTextBoxInputFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxInputFilePath.SelectedText = "";
            this.metroTextBoxInputFilePath.SelectionLength = 0;
            this.metroTextBoxInputFilePath.SelectionStart = 0;
            this.metroTextBoxInputFilePath.ShortcutsEnabled = true;
            this.metroTextBoxInputFilePath.Size = new System.Drawing.Size(177, 23);
            this.metroTextBoxInputFilePath.TabIndex = 21;
            this.metroTextBoxInputFilePath.UseSelectable = true;
            this.metroTextBoxInputFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxInputFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonInputFileOpen
            // 
            this.metroButtonInputFileOpen.Location = new System.Drawing.Point(318, 94);
            this.metroButtonInputFileOpen.Name = "metroButtonInputFileOpen";
            this.metroButtonInputFileOpen.Size = new System.Drawing.Size(41, 23);
            this.metroButtonInputFileOpen.TabIndex = 22;
            this.metroButtonInputFileOpen.Text = "...";
            this.metroButtonInputFileOpen.UseSelectable = true;
            this.metroButtonInputFileOpen.Click += new System.EventHandler(this.metroButtonInputFileOpen_Click);
            // 
            // metroButtonOutputFileSelect
            // 
            this.metroButtonOutputFileSelect.Location = new System.Drawing.Point(318, 123);
            this.metroButtonOutputFileSelect.Name = "metroButtonOutputFileSelect";
            this.metroButtonOutputFileSelect.Size = new System.Drawing.Size(41, 23);
            this.metroButtonOutputFileSelect.TabIndex = 25;
            this.metroButtonOutputFileSelect.Text = "...";
            this.metroButtonOutputFileSelect.UseSelectable = true;
            this.metroButtonOutputFileSelect.Click += new System.EventHandler(this.metroButtonOutputFileSelect_Click);
            // 
            // metroTextBoxOutputFilePath
            // 
            // 
            // 
            // 
            this.metroTextBoxOutputFilePath.CustomButton.Image = null;
            this.metroTextBoxOutputFilePath.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.metroTextBoxOutputFilePath.CustomButton.Name = "";
            this.metroTextBoxOutputFilePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxOutputFilePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxOutputFilePath.CustomButton.TabIndex = 1;
            this.metroTextBoxOutputFilePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxOutputFilePath.CustomButton.UseSelectable = true;
            this.metroTextBoxOutputFilePath.CustomButton.Visible = false;
            this.metroTextBoxOutputFilePath.Lines = new string[0];
            this.metroTextBoxOutputFilePath.Location = new System.Drawing.Point(135, 123);
            this.metroTextBoxOutputFilePath.MaxLength = 32767;
            this.metroTextBoxOutputFilePath.Name = "metroTextBoxOutputFilePath";
            this.metroTextBoxOutputFilePath.PasswordChar = '\0';
            this.metroTextBoxOutputFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOutputFilePath.SelectedText = "";
            this.metroTextBoxOutputFilePath.SelectionLength = 0;
            this.metroTextBoxOutputFilePath.SelectionStart = 0;
            this.metroTextBoxOutputFilePath.ShortcutsEnabled = true;
            this.metroTextBoxOutputFilePath.Size = new System.Drawing.Size(177, 23);
            this.metroTextBoxOutputFilePath.TabIndex = 24;
            this.metroTextBoxOutputFilePath.UseSelectable = true;
            this.metroTextBoxOutputFilePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxOutputFilePath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 123);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Output File Path:";
            // 
            // metroButtonPublicKeyOpen
            // 
            this.metroButtonPublicKeyOpen.Location = new System.Drawing.Point(318, 152);
            this.metroButtonPublicKeyOpen.Name = "metroButtonPublicKeyOpen";
            this.metroButtonPublicKeyOpen.Size = new System.Drawing.Size(41, 23);
            this.metroButtonPublicKeyOpen.TabIndex = 28;
            this.metroButtonPublicKeyOpen.Text = "...";
            this.metroButtonPublicKeyOpen.UseSelectable = true;
            this.metroButtonPublicKeyOpen.Click += new System.EventHandler(this.metroButtonPublicKeyOpen_Click);
            // 
            // metroTextBoxPublicKey
            // 
            // 
            // 
            // 
            this.metroTextBoxPublicKey.CustomButton.Image = null;
            this.metroTextBoxPublicKey.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.metroTextBoxPublicKey.CustomButton.Name = "";
            this.metroTextBoxPublicKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPublicKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPublicKey.CustomButton.TabIndex = 1;
            this.metroTextBoxPublicKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPublicKey.CustomButton.UseSelectable = true;
            this.metroTextBoxPublicKey.CustomButton.Visible = false;
            this.metroTextBoxPublicKey.Lines = new string[0];
            this.metroTextBoxPublicKey.Location = new System.Drawing.Point(135, 152);
            this.metroTextBoxPublicKey.MaxLength = 32767;
            this.metroTextBoxPublicKey.Name = "metroTextBoxPublicKey";
            this.metroTextBoxPublicKey.PasswordChar = '\0';
            this.metroTextBoxPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPublicKey.SelectedText = "";
            this.metroTextBoxPublicKey.SelectionLength = 0;
            this.metroTextBoxPublicKey.SelectionStart = 0;
            this.metroTextBoxPublicKey.ShortcutsEnabled = true;
            this.metroTextBoxPublicKey.Size = new System.Drawing.Size(177, 23);
            this.metroTextBoxPublicKey.TabIndex = 27;
            this.metroTextBoxPublicKey.UseSelectable = true;
            this.metroTextBoxPublicKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPublicKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(100, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Public Key Path:";
            // 
            // metroButtonPrivateKeyOpen
            // 
            this.metroButtonPrivateKeyOpen.Location = new System.Drawing.Point(318, 181);
            this.metroButtonPrivateKeyOpen.Name = "metroButtonPrivateKeyOpen";
            this.metroButtonPrivateKeyOpen.Size = new System.Drawing.Size(41, 23);
            this.metroButtonPrivateKeyOpen.TabIndex = 31;
            this.metroButtonPrivateKeyOpen.Text = "...";
            this.metroButtonPrivateKeyOpen.UseSelectable = true;
            this.metroButtonPrivateKeyOpen.Click += new System.EventHandler(this.metroButtonPrivateKeyOpen_Click);
            // 
            // metroTextBoxPrivateKey
            // 
            // 
            // 
            // 
            this.metroTextBoxPrivateKey.CustomButton.Image = null;
            this.metroTextBoxPrivateKey.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.metroTextBoxPrivateKey.CustomButton.Name = "";
            this.metroTextBoxPrivateKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPrivateKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPrivateKey.CustomButton.TabIndex = 1;
            this.metroTextBoxPrivateKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPrivateKey.CustomButton.UseSelectable = true;
            this.metroTextBoxPrivateKey.CustomButton.Visible = false;
            this.metroTextBoxPrivateKey.Lines = new string[0];
            this.metroTextBoxPrivateKey.Location = new System.Drawing.Point(135, 181);
            this.metroTextBoxPrivateKey.MaxLength = 32767;
            this.metroTextBoxPrivateKey.Name = "metroTextBoxPrivateKey";
            this.metroTextBoxPrivateKey.PasswordChar = '\0';
            this.metroTextBoxPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPrivateKey.SelectedText = "";
            this.metroTextBoxPrivateKey.SelectionLength = 0;
            this.metroTextBoxPrivateKey.SelectionStart = 0;
            this.metroTextBoxPrivateKey.ShortcutsEnabled = true;
            this.metroTextBoxPrivateKey.Size = new System.Drawing.Size(177, 23);
            this.metroTextBoxPrivateKey.TabIndex = 30;
            this.metroTextBoxPrivateKey.UseSelectable = true;
            this.metroTextBoxPrivateKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPrivateKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 181);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Private Key Path:";
            // 
            // openFileDialogInputFile
            // 
            this.openFileDialogInputFile.Filter = "All Files|*.*";
            // 
            // saveFileDialogOutputFile
            // 
            this.saveFileDialogOutputFile.Filter = "PGP File|*.PGP";
            // 
            // openFileDialogPublicKey
            // 
            this.openFileDialogPublicKey.FileName = "pub.key";
            this.openFileDialogPublicKey.Filter = "Public PGP Key|*.key;*.asc";
            // 
            // openFileDialogPrivateKey
            // 
            this.openFileDialogPrivateKey.FileName = "pri.key";
            this.openFileDialogPrivateKey.Filter = "Private PGP Key|*.key;*.asc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "© maksim789456, 2018\r\n";
            // 
            // metroCheckBoxArmor
            // 
            this.metroCheckBoxArmor.AutoSize = true;
            this.metroCheckBoxArmor.Checked = true;
            this.metroCheckBoxArmor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxArmor.Location = new System.Drawing.Point(23, 242);
            this.metroCheckBoxArmor.Name = "metroCheckBoxArmor";
            this.metroCheckBoxArmor.Size = new System.Drawing.Size(202, 15);
            this.metroCheckBoxArmor.TabIndex = 33;
            this.metroCheckBoxArmor.Text = "Binary representation as ASCII text";
            this.metroCheckBoxArmor.UseSelectable = true;
            this.metroCheckBoxArmor.Visible = false;
            // 
            // metroCheckBoxIntegrityCheck
            // 
            this.metroCheckBoxIntegrityCheck.AutoSize = true;
            this.metroCheckBoxIntegrityCheck.Checked = true;
            this.metroCheckBoxIntegrityCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxIntegrityCheck.Location = new System.Drawing.Point(23, 263);
            this.metroCheckBoxIntegrityCheck.Name = "metroCheckBoxIntegrityCheck";
            this.metroCheckBoxIntegrityCheck.Size = new System.Drawing.Size(291, 15);
            this.metroCheckBoxIntegrityCheck.TabIndex = 34;
            this.metroCheckBoxIntegrityCheck.Text = "Сheck the integrity of the package on the input file";
            this.metroCheckBoxIntegrityCheck.UseSelectable = true;
            this.metroCheckBoxIntegrityCheck.Visible = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 210);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Password to PGP";
            // 
            // metroTextBoxPasswordPGP
            // 
            // 
            // 
            // 
            this.metroTextBoxPasswordPGP.CustomButton.Image = null;
            this.metroTextBoxPasswordPGP.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.metroTextBoxPasswordPGP.CustomButton.Name = "";
            this.metroTextBoxPasswordPGP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPasswordPGP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPasswordPGP.CustomButton.TabIndex = 1;
            this.metroTextBoxPasswordPGP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPasswordPGP.CustomButton.UseSelectable = true;
            this.metroTextBoxPasswordPGP.CustomButton.Visible = false;
            this.metroTextBoxPasswordPGP.Lines = new string[0];
            this.metroTextBoxPasswordPGP.Location = new System.Drawing.Point(135, 210);
            this.metroTextBoxPasswordPGP.MaxLength = 32767;
            this.metroTextBoxPasswordPGP.Name = "metroTextBoxPasswordPGP";
            this.metroTextBoxPasswordPGP.PasswordChar = '*';
            this.metroTextBoxPasswordPGP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPasswordPGP.SelectedText = "";
            this.metroTextBoxPasswordPGP.SelectionLength = 0;
            this.metroTextBoxPasswordPGP.SelectionStart = 0;
            this.metroTextBoxPasswordPGP.ShortcutsEnabled = true;
            this.metroTextBoxPasswordPGP.Size = new System.Drawing.Size(177, 23);
            this.metroTextBoxPasswordPGP.TabIndex = 36;
            this.metroTextBoxPasswordPGP.UseSelectable = true;
            this.metroTextBoxPasswordPGP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPasswordPGP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 358);
            this.Controls.Add(this.metroTextBoxPasswordPGP);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroCheckBoxIntegrityCheck);
            this.Controls.Add(this.metroCheckBoxArmor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButtonPrivateKeyOpen);
            this.Controls.Add(this.metroTextBoxPrivateKey);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroButtonPublicKeyOpen);
            this.Controls.Add(this.metroTextBoxPublicKey);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroButtonOutputFileSelect);
            this.Controls.Add(this.metroTextBoxOutputFilePath);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButtonInputFileOpen);
            this.Controls.Add(this.metroTextBoxInputFilePath);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButtonKeyGenerator);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonWork);
            this.Controls.Add(this.metroButtonClear);
            this.Controls.Add(this.metroRadioButtonDecrypt);
            this.Controls.Add(this.metroRadioButtonEncrypt);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "PGP File Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButtonEncrypt;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonDecrypt;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroButton metroButtonWork;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonKeyGenerator;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxInputFilePath;
        private MetroFramework.Controls.MetroButton metroButtonInputFileOpen;
        private MetroFramework.Controls.MetroButton metroButtonOutputFileSelect;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOutputFilePath;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButtonPublicKeyOpen;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPublicKey;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButtonPrivateKeyOpen;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrivateKey;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.OpenFileDialog openFileDialogInputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogPublicKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogPrivateKey;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxArmor;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxIntegrityCheck;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPasswordPGP;
    }
}

