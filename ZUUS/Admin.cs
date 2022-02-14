using System;
using System.Windows.Forms;

namespace ZUUS
{
    public partial class Admin : Form
    {
        public static string UserID; 
        public Admin()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            //zablokowanie comboboxia
            comboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPayed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            addUser();
            Connection._QuerySql("Select id_klient from klient");
            labelUsers.Text = Connection.T_Global.Rows.Count.ToString();
            Connection._QuerySql("Select id_klient from klient WHERE rola = 0");
            labelAdmins.Text = Connection.T_Global.Rows.Count.ToString();
            Connection._QuerySql("Select login from klient ORDER BY id_klient DESC LIMIT 1");
            labelNewUser.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("SELECT SUM(stan_konta) FROM  portfel");
            labelMoney.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            this.Refresh();
        }
        //dodanie użytkowników do comboboxa
        private void addUser()
        {
            Connection._QuerySql("Select login from klient");
            for (int i = 0; i < Connection.T_Global.Rows.Count; i++)
            {
                comboBoxUser.Items.Add(Connection.T_Global.Rows[i].ItemArray[0]);
            }
            comboBoxUser.SelectedIndex = 0;
        }
        //wywołanie użytkownika
        private void buttonChange_Click(object sender, EventArgs e)
        {
            try
            {
                string UserLogin = comboBoxUser.Text;
                Connection._QuerySql("Select id_klient From klient WHERE login = '" + UserLogin + "'");
                UserID = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                labelIdAndUser.Text = UserID + " | " + UserLogin;
                //klient
                Connection._QuerySql("Select imie From klient WHERE id_klient = '" + UserID + "'");
                textBoxName.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select nazwisko From klient WHERE id_klient = '" + UserID + "'");
                textBoxSurName.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select rok_urodzenia From klient WHERE id_klient = '" + UserID + "'");
                dateTimePickerBirthDay.Value = DateTime.ParseExact(Connection.T_Global.Rows[0].ItemArray[0].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                Connection._QuerySql("Select rola From klient WHERE id_klient = '" + UserID + "'");
                comboBoxRole.Text = RoleGet(Connection.T_Global.Rows[0].ItemArray[0].ToString());
                Connection._QuerySql("Select data_rejestracji From klient WHERE id_klient = '" + UserID + "'");
                textBoxDateRegister.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString().Substring(0,10);
                Connection._QuerySql("Select e_mail From klient WHERE id_klient = '" + UserID + "'");
                textBoxEmail.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                //portfel
                Connection._QuerySql("Select stan_konta From portfel WHERE id_klient = '" + UserID + "'");
                textBoxAccountBalance.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select wspolczynnik_przyrostu From portfel WHERE id_klient = '" + UserID + "'");
                textBoxIncrementFactor.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select stawka From portfel WHERE id_klient = '" + UserID + "'");
                textBoxRate.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                //platnosc
                Connection._QuerySql("Select numer_karty From platnosc WHERE id_klient = '" + UserID + "'");
                textBoxNumerCard.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select rok_karty From platnosc WHERE id_klient = '" + UserID + "'");
                dateTimePickerYearCard.Value = DateTime.ParseExact(Connection.T_Global.Rows[0].ItemArray[0].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                Connection._QuerySql("Select cvc_karty From platnosc WHERE id_klient = '" + UserID + "'");
                textBoxCVC.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select data_platnosci From platnosc WHERE id_klient = '" + UserID + "'");
                dateTimePickerPayDay.Value = DateTime.ParseExact(Connection.T_Global.Rows[0].ItemArray[0].ToString(), "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                Connection._QuerySql("Select nr_konta_bankowego From platnosc WHERE id_klient = '" + UserID + "'");
                textBoxNumerAccountBank.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
                Connection._QuerySql("Select czy_platnosc_dokonana From platnosc WHERE id_klient = '" + UserID + "'");
                comboBoxPayed.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //zmiana w bazie
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection._QuerySql("update klient set imie='"+textBoxName.Text+"',nazwisko='"+textBoxSurName.Text+"',rok_urodzenia='"+dateTimePickerBirthDay.Value.ToString("yyyy-MM-dd") +"',rola='"+ RoleChange(comboBoxRole.Text).ToString() + "',e_mail='"+textBoxEmail.Text+"' where id_klient = "+UserID);
                Connection._QuerySql("update platnosc set numer_karty = '"+textBoxNumerCard.Text+"', rok_karty='"+dateTimePickerYearCard.Value.ToString("yyyy-MM-dd") +"', cvc_karty ='"+textBoxCVC.Text+"', data_platnosci='"+dateTimePickerPayDay.Value.ToString("yyyy-MM-dd")+ "', nr_konta_bankowego ='"+textBoxNumerAccountBank.Text+"',czy_platnosc_dokonana = '"+comboBoxPayed.Text+"' where id_klient = " + UserID);
                Connection._QuerySql("update portfel set stan_konta='"+textBoxAccountBalance.Text.Replace(",", ".") + "',wspolczynnik_przyrostu='"+textBoxIncrementFactor.Text.Replace(",", ".") + "',stawka='"+textBoxRate.Text.Replace(",", ".") + "'where id_klient = "+UserID);
                MessageBox.Show("dokonano zmian");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int RoleChange(string role)
        {
            if ("Admin" == role) return 0;
            return 1;
        }
        private string RoleGet(string role)
        {
            if ("0" == role) return "Admin";
            return "Użytkownik";
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Login.BlockChar(sender,e);
        }

        private void textBoxSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Login.BlockChar(sender, e);
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Login.BlockChar(sender, e);
        }

        private void textBoxRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) 
                && e.KeyChar != '1' 
                && e.KeyChar != '.' 
                && e.KeyChar != '0')
            {
                e.Handled = true;
            }
        }

        private void textBoxAccountBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxIncrementFactor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxNumerCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textBoxNumerAccountBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void buttonPayDay_Click(object sender, EventArgs e)
        {
            MMenu.PayDay();
            buttonChange_Click(sender, e);
            Refresh();
        }

        private void buttonSetNo_Click(object sender, EventArgs e)
        {
            MMenu.SetNo();
            buttonChange_Click(sender, e);
            Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MMenu.ChangeFactor();
            buttonChange_Click(sender, e);
            Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserID == null) throw new Exception("Nie wybrano użytkownika");
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zmienić dane?", "Zmiana danych", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Connection._QuerySql("DELETE FROM portfel WHERE id_klient = " + UserID);
                    Connection._QuerySql("DELETE FROM platnosc WHERE id_klient = " + UserID);
                    Connection._QuerySql("DELETE FROM klient WHERE id_klient = " + UserID);
                    comboBoxUser.Items.Clear();
                    init();
                    MessageBox.Show("Usunięto użytkownika");
                }
                else
                {
                    throw new Exception("Nie usunięto");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
