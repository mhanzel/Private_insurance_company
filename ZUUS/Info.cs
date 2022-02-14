using System;
using System.Globalization;
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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            init();
        }
        //inicjalizacja informacji
        private void init()
        {
            
            Connection._QuerySql("select rola from klient where id_klient = " + MMenu.idKlient);
            if (Connection.T_Global.Rows[0].ItemArray[0].ToString() == "1") labelRole.Text = "Użytkownik";
            else labelRole.Text = "Adminstrator";
            Connection._QuerySql("select login from klient where id_klient = " + MMenu.idKlient);
            labelUser.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("select data_platnosci from platnosc where id_klient = " + MMenu.idKlient);
            labelDayPay.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString().Substring(0, 10);
            Connection._QuerySql("select nr_konta_bankowego from platnosc where id_klient = " + MMenu.idKlient);
            labelNumberBank.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("select numer_karty from platnosc where id_klient = " + MMenu.idKlient);
            labelNumberCard.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("select rok_karty from platnosc where id_klient = " + MMenu.idKlient);
            DateTime dateEnd = DateTime.Parse(Connection.T_Global.Rows[0].ItemArray[0].ToString());
            labelCardEnd.Text = dateEnd.ToString("MM/yy", CultureInfo.CreateSpecificCulture("en-US"));
            Connection._QuerySql("select cvc_karty from platnosc where id_klient = " + MMenu.idKlient);
            labelCVC.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
        }
    }
}
