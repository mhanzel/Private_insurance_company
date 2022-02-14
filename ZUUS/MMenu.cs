using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ZUUS
{
    public partial class MMenu : Form
    {
        public Login BackFromMenuToLogin { get; set; }
        public static string idKlient;
        public MMenu()
        {
            InitializeComponent();
            init();
        }
        //wyszukanie potrzebnego id_klienta do wykonywania poleceń
        //uzupełnienie tabel
        public void init()
        {
            Connection._QuerySql("Select id_klient from klient WHERE login = '" + Login.sqlLogin + "'");
            idKlient = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("Select stan_konta from portfel WHERE id_klient = '" + idKlient + "'");
            labelMoney.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("Select wspolczynnik_przyrostu from portfel WHERE id_klient = '" + idKlient + "'");
            labelGrowth.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            Connection._QuerySql("Select stawka from portfel WHERE id_klient = '" + idKlient + "'");
            labelRate.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            //
            Connection._QuerySql("Select login from klient WHERE id_klient = '" + idKlient + "'");
            aToolStripMenuItemName.Text = Connection.T_Global.Rows[0].ItemArray[0].ToString();
            //dodaj vanish
            Connection._QuerySql("Select rola from klient WHERE id_klient = '" + idKlient + "'");
            //Wyświeltenie panelu dla Administracji
            //rola 1 jest to zwykły użytkownik
            if (Connection.T_Global.Rows[0].ItemArray[0].ToString() == "1")
            {
                adminToolStripMenuItem.Visible = false;
            }
            chartPay.Series.Clear();
            comboBoxForecast.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Refresh();
        }
        //sprawdza czas zapłat
        private void timerPayDay_Tick(object sender, EventArgs e)
        {
                //do zerowania zapłat na nowy miesiąc, 1 dzień miesiąca
                //+
                //zmiana współczynnika stawki
                if (DateTime.Now.ToString("dd.HH.mm.ss") == "01.10.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.11.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.12.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.13.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.14.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.15.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.16.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.17.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.18.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.19.00.00"
                    || DateTime.Now.ToString("dd.HH.mm.ss") == "01.20.00.00")
                {
                    SetNo();
                    ChangeFactor();
                }
                //do wykonania zapłat oprócz 1 dnia miesiąca
                else
                {
                    if (DateTime.Now.ToString("HH.mm.ss") == "10.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "11.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "12.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "13.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "14.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "15.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "16.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "17.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "18.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "19.00.00"
                        || DateTime.Now.ToString("HH.mm.ss") == "20.00.00")
                    {
                        PayDay();
                    }
                }
        }
        public static void SetNo()
        {
            try
            {
                Connection._QuerySql("Select id_klient from platnosc");
                int count = Connection.T_Global.Rows.Count;
                string[] idUser = new string[count];
                for(int i = 0; i< count;i++)
                {
                    idUser[i] = Connection.T_Global.Rows[i].ItemArray[0].ToString();
                }
                for (int i = 0; i < count; i++)
                {
                    Connection._QuerySql("update platnosc set czy_platnosc_dokonana = 'NIE' WHERE id_klient = " + idUser[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void PayDay()
        {
            try
            {
                DateTime date_pay;
                Connection._QuerySql("select id_klient, data_platnosci, czy_platnosc_dokonana from platnosc");
                int Lenght = Connection.T_Global.Rows.Count;
                string[,] TablePay = new string[Lenght, 3];
                double Balance, Factor, Rate;
                for (int i = 0; i < Lenght; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        TablePay[i, j] = Connection.T_Global.Rows[i].ItemArray[j].ToString();
                    }
                }
                //petla dla każdego klienta
                for (int i = 0; i < Lenght; i++)
                {
                    //sprawdza czy dokonano zapłaty w tym miesiącu
                    if (TablePay[i, 2] == "NIE")
                    {
                        date_pay = DateTime.ParseExact(TablePay[i, 1], "dd.MM.yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                        //wykonanie zapłaty wtedy gdy jest dany dzień zapłaty lub dzień już był
                        if (DateTime.Compare(DateTime.Now, date_pay) >= 0)
                        {
                            Connection._QuerySql("select stan_konta, wspolczynnik_przyrostu, stawka from portfel where id_klient = " + TablePay[i, 0]);
                            Balance = double.Parse(Connection.T_Global.Rows[0].ItemArray[0].ToString());
                            Factor = double.Parse(Connection.T_Global.Rows[0].ItemArray[1].ToString());
                            Rate = double.Parse(Connection.T_Global.Rows[0].ItemArray[2].ToString());
                            Balance += Factor + Rate;
                            Connection._QuerySql("update portfel set stan_konta = '" + Balance.ToString().Replace(",",".") + "' where id_klient = " + TablePay[i, 0]);
                            Connection._QuerySql("update platnosc set czy_platnosc_dokonana = 'TAK' WHERE id_klient = " + TablePay[i, 0]);
                            //miejsce na wykonanie operacji przelewu
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public static void ChangeFactor()
        {
            try
            {
                //tworzy tablicę użytkowników
                Connection._QuerySql("Select id_klient from portfel");
                string[] idUser = new string[Connection.T_Global.Rows.Count];
                for (int i = 0; i < Connection.T_Global.Rows.Count; i++)
                {
                    idUser[i] = Connection.T_Global.Rows[i].ItemArray[0].ToString();
                }
                //zlicza ilość użytkowników w bazie oraz tworzy ich współczynnik oraz stawkę
                Connection._QuerySql("Select stawka from portfel");
                int count = Connection.T_Global.Rows.Count;
                double[] rate = new double[count];
                string[] factor = new string[count];
                //funkcja tworzy nowe współczynnik z funcji oraz wysokości stawek
                for (int i = 0; i < count; i++)
                {
                    rate[i] = double.Parse(Connection.T_Global.Rows[i].ItemArray[0].ToString());
                    factor[i] = Math.Round(Math.Log(rate[i] + 1) + (rate[i] / 75), 2).ToString().Replace(",", ".");
                    //log_e(x+1)+(x/75)
                }
                //wpisuje zaktualizowane dane
                for (int i = 0; i < count; i++)
                {
                    Connection._QuerySql("update portfel set wspolczynnik_przyrostu = '" + factor[i] + "' where id_klient = " + idUser[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Login"].Close();
        }
        private void MMenu_Activated(object sender, EventArgs e)
        {
            init();
        }
        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackFromMenuToLogin.Show();
            this.Hide();
        }
        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings f1 = new Settings();
            f1.Show();
        }
        private void zmianaStawkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rate f1 = new Rate();
            f1.Show();
        }
        private void zamianaKartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Card f1 = new Card();
            f1.Show();
        }
        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info f1 = new Info();
            f1.Show();
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f1 = new Admin();
            f1.Show();
        }

        private void wypłataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment f1 = new Payment();
            f1.Show();
        }
        //Prognoza na nastepne lata
        private void comboBoxRole_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection._QuerySql("select stan_konta, wspolczynnik_przyrostu, stawka from portfel WHERE id_klient = "+ idKlient.ToString());
                double Balance = double.Parse(Connection.T_Global.Rows[0].ItemArray[0].ToString());
                double Factor = double.Parse(Connection.T_Global.Rows[0].ItemArray[1].ToString());
                double Rate = double.Parse(Connection.T_Global.Rows[0].ItemArray[2].ToString());
                if (Rate == 0) throw new Exception("Nie można wyświetlić wykresów na 0 stawce");
                double FactorRate = Factor + Rate;
                switch (comboBoxForecast.GetItemText(comboBoxForecast.SelectedItem))
                {
                    case "6 miesięcy": ChartChange(6 ,Balance, FactorRate);
                        break;
                    case "1 rok": ChartChange(12, Balance, FactorRate);
                        break;
                    case "2 lata": ChartChange(24, Balance, FactorRate);
                        break;
                    case "3 lata": ChartChange(36, Balance, FactorRate);
                        break;
                    case "5 lata": ChartChange(48, Balance, FactorRate);
                        break;
                    case "10 lata": ChartChange(120, Balance, FactorRate);
                        break;
                    case "20 lata": ChartChange(240, Balance, FactorRate);
                        break;
                    case "30 lata": ChartChange(360, Balance, FactorRate);
                        break;
                    case "40 lata": ChartChange(480, Balance, FactorRate);
                        break;
                    case "50 lata": ChartChange(600, Balance, FactorRate);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ChartChange(int Xsize,double Balance, double FactionRate)
        {
            chartPay.Series.Clear();
            double[] Yvariable = new double[Xsize+1];
            Yvariable[1] = Balance;
            double member = Balance + FactionRate;
            chartPay.ChartAreas[0].AxisX.IsMarginVisible = false;
            string first, second, last;
            for (int i = 2;i <= Xsize ; i++)
                {
                Yvariable[i] = member;
                member+= FactionRate;
            }
            chartPay.ChartAreas[0].AxisY.Maximum = Yvariable[Xsize] + (Yvariable[Xsize] / 5);
            first = Math.Round(Yvariable[1], 2).ToString() + " zł";
            second = Math.Round(Yvariable[Xsize / 2], 2).ToString() + " zł";
            last = Math.Round(Yvariable[Xsize], 2).ToString() + " zł";
            chartPay.Series.Add(first);
            chartPay.Series.Add(second);
            chartPay.Series.Add(last);
            chartPay.Series[first].XValueType = ChartValueType.String;
            chartPay.Series[first].Points.AddXY(DateTime.Now.ToString("dd.MM.yyyy"), Yvariable[1]);
            chartPay.Series[first].Points.AddXY(DateTime.Now.AddMonths(Xsize/2).ToString("dd.MM.yyyy"), Yvariable[Xsize/2]);
            chartPay.Series[first].Points.AddXY(DateTime.Now.AddMonths(Xsize).ToString("dd.MM.yyyy"), Yvariable[Xsize]);
            chartPay.Series[first].Color = Color.Red;
            chartPay.Series[second].Color = Color.Purple;
            chartPay.Series[last].Color = Color.Green;
            chartPay.Series[first].Points[0].Color = Color.Red;
            chartPay.Series[first].Points[1].Color = Color.Purple;
            chartPay.Series[first].Points[2].Color = Color.Green;
            chartPay.Legends[0].Font = new Font(chartPay.Legends[0].Font.FontFamily, 12);
        }
    }
}
