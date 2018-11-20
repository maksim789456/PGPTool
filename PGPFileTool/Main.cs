//© maksim789456, 2018 г.

using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using Cinchoo.PGP;

namespace PGPFileTool
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        private WorkType? workType;
        private string inputPath, outputPath, publicKeyPath, privateKeyPath, passwordPGP;

        public Main()
        {
            InitializeComponent();
        }

        private void metroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetroRadioButton copyButton = (MetroRadioButton) sender;
            switch (copyButton.Text)
            {
                case "Encrypt":
                    workType = WorkType.Encrypt;
                    metroButtonWork.Enabled = true;
                    metroButtonWork.Text = "Encrypt";
                    metroCheckBoxArmor.Visible = true;
                    metroCheckBoxIntegrityCheck.Visible = true;
                    break;
                case "Decrypt":
                    workType = WorkType.Decrypt;
                    metroButtonWork.Enabled = true;
                    metroButtonWork.Text = "Decrypt";
                    openFileDialogInputFile.Filter = "PGP File|*.PGP";
                    saveFileDialogOutputFile.Filter = "All Files|*.*";
                    metroCheckBoxArmor.Visible = false;
                    metroCheckBoxIntegrityCheck.Visible = false;
                    break;
            }
        }

        private async void metroButtonWork_Click(object sender, EventArgs e)
        {
            inputPath = metroTextBoxInputFilePath.Text != "" ? metroTextBoxInputFilePath.Text : "";
            outputPath = metroTextBoxOutputFilePath.Text != "" ? metroTextBoxOutputFilePath.Text : "";
            publicKeyPath = metroTextBoxPublicKey.Text != "" ? metroTextBoxPublicKey.Text : "";
            privateKeyPath = metroTextBoxPrivateKey.Text != "" ? metroTextBoxPrivateKey.Text : "";
            passwordPGP = metroTextBoxPasswordPGP.Text != "" ? metroTextBoxPasswordPGP.Text : "";

            bool armor = metroCheckBoxArmor.Checked;
            bool integrityCheck = metroCheckBoxIntegrityCheck.Checked;

            bool state = CheckToNull(inputPath, outputPath, publicKeyPath, privateKeyPath, passwordPGP);
            if (!state) return;

            switch (workType)
            {
                case WorkType.Encrypt:
                    using (ChoPGPEncryptDecrypt pgp = new ChoPGPEncryptDecrypt())
                    {
                        await pgp.EncryptFileAndSignAsync(inputPath, outputPath, publicKeyPath, privateKeyPath,
                            passwordPGP, armor, integrityCheck);
                        MessageBox.Show($"Файл зашифрован. Не потяряйте ключи!\n Файл находиться по пути: {outputPath}");
                    }
                    break;
                case WorkType.Decrypt:
                    using (ChoPGPEncryptDecrypt pgp = new ChoPGPEncryptDecrypt())
                    {
                        await pgp.DecryptFileAndVerifyAsync(inputPath, outputPath, publicKeyPath, privateKeyPath,
                            passwordPGP);
                        MessageBox.Show($"Файл расшифрован.\n Файл находиться по пути: {outputPath}");
                    }
                    break;
            }
        }

        private bool CheckToNull(string inputPath, string outputPath, string publicKeyPath, string privateKeyPath, string passwordPGP)
        {
            switch (workType)
            {
                case WorkType.Encrypt:
                    if (inputPath == "") { MessageBox.Show("Не выбран файл который нужно зашифровать!"); return false;}
                    if (outputPath == "") { MessageBox.Show("Не выбран путь куда нужно положить файл после шифровки!"); return false; }
                    if (publicKeyPath == "") { MessageBox.Show("Не выбран файл публичного ключа!\n Нет ключа?! Его можно сгенерировать в Key Generator."); return false; }
                    if (privateKeyPath == "") { MessageBox.Show("Не выбран файл приватного ключа!\n Нет ключа?! Его можно сгенерировать в Key Generator."); return false; }
                    if (passwordPGP == "") { MessageBox.Show("Не введен пароль секретного ключа!"); return false; }
                    break;
                case WorkType.Decrypt:
                    if (inputPath == "") { MessageBox.Show("Не выбран файл который нужно разшифровать!"); return false; }
                    if (outputPath == "") { MessageBox.Show("Не выбран путь куда нужно положить файл после разшифровки!"); return false; }
                    if (publicKeyPath == "") { MessageBox.Show("Не выбран файл публичного ключа!\n Нет ключа?! Ну и тогда пошел отсюда!"); return false; }
                    if (privateKeyPath == "") { MessageBox.Show("Не выбран файл приватного ключа!\n Нет ключа?! Ну и тогда пошел отсюда!"); return false; }
                    if (passwordPGP == "") { MessageBox.Show("Не введен пароль секретного ключа!"); return false; }
                    break;
            }
            return true;
        }

        private void metroButtonKeyGenerator_Click(object sender, EventArgs e)
        {
            KeyGen kgForm = new KeyGen();
            kgForm.Show();
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            if (workType == null) return;
            metroTextBoxInputFilePath.Text = null;
            metroTextBoxOutputFilePath.Text = null;
            metroTextBoxPublicKey.Text = null;
            metroTextBoxPrivateKey.Text = null;
            metroTextBoxPasswordPGP.Text = null;
        }

        private void metroButtonInputFileOpen_Click(object sender, EventArgs e)
        {
            if (workType == null) return;
            if (openFileDialogInputFile.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxInputFilePath.Text = openFileDialogInputFile.FileName;
            }
        }

        private void metroButtonOutputFileSelect_Click(object sender, EventArgs e)
        {
            if (workType == null) return;
            if (saveFileDialogOutputFile.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxOutputFilePath.Text = saveFileDialogOutputFile.FileName;
            }
        }

        private void metroButtonPublicKeyOpen_Click(object sender, EventArgs e)
        {
            if (workType == null) return;
            if (openFileDialogPublicKey.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxPublicKey.Text = openFileDialogPublicKey.FileName;
            }
        }

        private void metroButtonPrivateKeyOpen_Click(object sender, EventArgs e)
        {
            if (workType == null) return;
            if (openFileDialogPrivateKey.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxPrivateKey.Text = openFileDialogPrivateKey.FileName;
            }
        }
    }
}
