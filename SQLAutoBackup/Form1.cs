using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> _databaseNames = new List<string>();

        private void btnActiveTimer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            if (file.ShowDialog() == DialogResult.OK)
               txtPath.Text = file.SelectedPath;
            BackupTimer.Start();
            progressBar1.Value = BackupTimer.Interval;
        }

        private void buttonConnectServer_Click(object sender, EventArgs e)
        {
            if (textBoxServerAddress.Text == string.Empty || textBoxServerUserID.Text == string.Empty || textBoxServerUserPassword.Text == string.Empty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            try
            {
                if (buttonConnectServer.Text != "Continue")
                {

                    //Check Connection
                    SqlConnection conn = new SqlConnection($@"Data Source={textBoxServerAddress.Text};User ID={textBoxServerUserID.Text};Password={textBoxServerUserPassword.Text};Connect Timeout=5000000; Database={selectDb.Text};");
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    if(conn.State == ConnectionState.Open)
                    GetDatabaseNames();
                        MessageBox.Show("Sunucu Bağlantısı Başarılı. Lütfen Veritabanı Seçiniz.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.None);
                        selectDb.Enabled = true;
                        selectDbLabel.Enabled = true;
                        buttonConnectServer.Text = "Continue";
                    textBoxServerAddress.Enabled = false;
                    textBoxServerUserID.Enabled = false;
                    textBoxServerUserPassword.Enabled = false;
                    foreach (var item in _databaseNames)
                        {
                            selectDb.Items.Add(item);
                        }
                }
                else
                {
                    if (selectDb.SelectedItem != null)
                    {
                        btnActiveTimer.Enabled = true;
                        MessageBox.Show("Bağlantı Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Veritabanı Seçiniz!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool GetDatabaseNames()
        {
            try
            {
                string sqlQuery = "SELECT name, database_id, create_date  FROM sys.databases;  ";
                using (SqlConnection myConnection = new SqlConnection($@"Data Source={textBoxServerAddress.Text};User ID={textBoxServerUserID.Text};Password={textBoxServerUserPassword.Text};Connect Timeout=10; Database=master;"))
                {
                    SqlCommand oCmd = new SqlCommand(sqlQuery, myConnection);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            _databaseNames.Add(oReader.GetValue(0).ToString());
                        }
                        myConnection.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sunucudan veriler alınırken bir hata oluştu. Lütfen internet bağlantınızı kontrol ediniz. " + ex.Message);
                return false;
            }
        }

        private void BackupTimer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string dd = date.Day + "_" + date.Month;
            SqlConnection con = new SqlConnection($@"Data Source={textBoxServerAddress.Text};User ID={textBoxServerUserID.Text};Password={textBoxServerUserPassword.Text};Connect Timeout=5000000; Database={selectDb.Text};");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("USE " + selectDb.Text + ";", con);
            SqlCommand cmd2 = new SqlCommand("BACKUP DATABASE " + selectDb.Text + " TO DISK = '" + txtPath.Text + "\\" + selectDb.Text + "_" + dd + ".bak' WITH FORMAT ,MEDIANAME = 'Z_SQLServerBackups' , NAME = 'Full Backup of " + selectDb.Text + "';", con);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }
    }
}
