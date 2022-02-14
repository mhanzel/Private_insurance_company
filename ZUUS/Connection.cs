
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace ZUUS
{
    
    public partial class Connection : Form
    {
        //Pozwala na zobaczenia Form1
        public Login BackFromConnectionToLogin { get; set; }
        public static DataTable T_Global;
        public static string NameServer;
        public static string NamePort;
        public static string NameUser;
        public static string NamePassword;
        public static string NameDatabase;
        //metoda do wyczytywania z bazy danych informacji
        public static void _QuerySql(string query)
        {
            MySqlConnection con = new MySqlConnection("server=" + NameServer + ";port=" + NamePort + ";user id=" + NameUser + ";password=" + NamePassword + ";database=" + NameDatabase + ";");
            MySqlCommand cmd;
            MySqlDataAdapter da;
            DataTable dt;
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            T_Global = dt;
            con.Close();
        }
        //metoda dodająca do bazy danych informacje
        public static void _InsertSql(string String, string id, string Table)
        {
            string ID;
            _QuerySql("Select " + id + " From " + Table + " ORDER BY 1 DESC Limit 1");
            if (T_Global.Rows.Count == 0)
            {
                ID = "1";
            }
            else
            {
                ID = (int.Parse(T_Global.Rows[0].ItemArray[0].ToString()) + 1).ToString();
            }
            MySqlConnection con = new MySqlConnection("server=" + NameServer + ";port=" + NamePort + ";user id=" + NameUser + ";password=" + NamePassword + ";database=" + NameDatabase + ";");
            MySqlCommand cmd;
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO " + Table + " VALUES('" + ID + "','" + String;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
        }
        public Connection()
        {
            InitializeComponent();
            ImageStatus();
        }
        //Sprawdza status połaczenia
        public bool CheckStatus()
        {
            try
            {
                NameServer = textBoxServer.Text;
                NamePort = textBoxPort.Text;
                NamePassword = textBoxHash.Text;
                NameUser = textBoxUser.Text;
                NameDatabase = textBoxDatabase.Text;
                _QuerySql("Select * from Klient");
                labelStatus.Text = "Połączono";
                return true;
            }
            catch
            {
                labelStatus.Text = "Brak połączenia";
                return false;
            }
            
        }
        //zmiana koloru statusu
        public void ImageStatus()
        {
            if (CheckStatus() == true)
            {
                pictureBoxStatus.Image = Image.FromFile("C:/Users/matiz/OneDrive/Pulpit/studia/SEM 7/PROJEKT/green.png");
            }
            else
            {
                pictureBoxStatus.Image = Image.FromFile("C:/Users/matiz/OneDrive/Pulpit/studia/SEM 7/PROJEKT/red.png");
            }
            this.pictureBoxStatus.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void Connection_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackFromConnectionToLogin.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ImageStatus();
            //if(CheckStatus() == false) this.Close();
        }
    }
}
