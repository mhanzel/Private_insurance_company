using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUUS
{
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            dateTimePickerYearCard.Format = DateTimePickerFormat.Custom;
            dateTimePickerYearCard.CustomFormat = " MM / yy ";
            //blokada do 3 i 16 cyfr;
            textBoxNumberCard.MaxLength = 16;
            textBoxCVC.MaxLength = 3;
            Connection._QuerySql("select numer_karty from platnosc where id_klient = " + MMenu.idKlient);
            textBoxNumberCard.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("select rok_karty from platnosc where id_klient = " + MMenu.idKlient);
            dateTimePickerYearCard.Value = DateTime.Parse(Connection.T_Global.Rows[0].ItemArray[0].ToString());
            Connection._QuerySql("select cvc_karty from platnosc where id_klient = " + MMenu.idKlient);
            textBoxCVC.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
        }

        private void textBoxNumberCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            //możliwość wpisania wyłącznie liczby
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCVC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //możliwość wpisania wyłącznie liczb
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNumberCard.Text.Length < 16) throw new Exception("Zbyt krótki numer karty");
                if (textBoxCVC.Text.Length<3) throw new Exception("Zbyt krótki CVC karty");
                Connection._QuerySql("update platnosc set numer_karty = '" + textBoxNumberCard.Text + "', rok_karty = '" + dateTimePickerYearCard.Value.ToString("yyyy-MM-dd") +"', cvc_karty = '"+textBoxCVC.Text+"' where id_klient = " + MMenu.idKlient);
                MessageBox.Show("Dokonano zmiany");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
