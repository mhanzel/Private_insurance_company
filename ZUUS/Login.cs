using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace ZUUS
{
    public partial class Login : Form
    {
        public static string sqlLogin;
        public Login()
        {
            InitializeComponent();
        }

        private void statusPołaczeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection f1 = new Connection();
            f1.BackFromConnectionToLogin = this;
            f1.Show();
            this.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register f1 = new Register();
            f1.BackFromRegisterToLogin = this;
            f1.Show();
            this.Visible = false;
        }
        //Blokuje niedozwolone litery
        static public void BlockChar(object sender, KeyPressEventArgs e)
        {
            e.Handled = ("%&'" + '"').Contains(e.KeyChar.ToString());
        }
        //Logowanie do konta
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection._QuerySql("Select login From klient WHERE login = '"+textBoxLogin.Text+"'");
                if (Connection.T_Global.Rows.Count == 0) throw new Exception("Niepoprawny login");
                sqlLogin = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select login From klient WHERE login = '" + textBoxHash.Text + "'");
                if (Connection.T_Global.Rows.Count == 0) throw new Exception("Niepoprawny hasło");
                string sqlHash = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                string currentLogin = textBoxLogin.Text;
                string currentHash = Register.GetStringSha256Hash(textBoxHash.Text);
                MMenu f1 = new MMenu();
                f1.BackFromMenuToLogin = this;
                f1.Show();
                this.Visible = false;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Brak połączenia");
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            BlockChar(sender, e);
        }

        private void textBoxHash_KeyPress(object sender, KeyPressEventArgs e)
        {
            BlockChar(sender, e);
        }
    }
}
