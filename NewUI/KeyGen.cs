//© maksim789456, 2018 г.

using System;
using System.Windows.Forms;
using Cinchoo.PGP;

namespace NewUI
{
    public partial class KeyGen : MetroFramework.Forms.MetroForm
    {
        public KeyGen()
        {
            InitializeComponent();
        }

        private async void metroButtonGenerate_Click(object sender, EventArgs e)
        {
            string pathToPubKey = metroTextBoxPathToSave.Text != "" ? metroTextBoxPathToSave.Text + @"\pub.asc" : "";
            string pathToPrivKey = metroTextBoxPathToSave.Text != "" ? metroTextBoxPathToSave.Text + @"\pri.asc" : "";
            string username = metroTextBoxUsername.Text != "" ? metroTextBoxUsername.Text : "";
            string password = metroTextBoxPassword.Text != "" ? metroTextBoxPassword.Text : "";
            int strength = metroTextBoxStrength.Text != "" ? Convert.ToInt32(metroTextBoxStrength.Text) : 1024;
            int certainty = metroTextBoxCertainty.Text != "" ? Convert.ToInt32(metroTextBoxCertainty.Text) : 8;

            bool state = CheckToNull(pathToPubKey, pathToPrivKey, username, password);
            if (!state) { return; }

            using (ChoPGPEncryptDecrypt pgp = new ChoPGPEncryptDecrypt())
            {
                await pgp.GenerateKeyAsync(pathToPubKey, pathToPrivKey, username, password, strength, certainty);
            }
            MessageBox.Show(
                $"Generation done!\nThe public key is located: {pathToPubKey}.\nThe private key located: {pathToPrivKey}");
            Close();
        }

        private bool CheckToNull(string pathToPubKey, string pathToPrivKey, string username, string password)
        {
            if (pathToPubKey == "" || pathToPrivKey == "") { MessageBox.Show("Не выбран путь!"); return false;}
            if (username == "") { MessageBox.Show("Не введено имя пользователя!"); return false;}
            if (password == "") { MessageBox.Show("Не введен пароль!"); return false;}

            return true;
        }

        private void metroButtonPathSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                metroTextBoxPathToSave.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void metroTextBoxStrength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroTextBoxCertainty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroTextBoxPathToSave.Text = null;
            metroTextBoxUsername.Text = null;
            metroTextBoxPassword.Text = null;
            metroTextBoxStrength.Text = null;
            metroTextBoxCertainty.Text = null;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
