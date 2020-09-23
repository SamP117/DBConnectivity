using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DBConnectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        SQLiteConnection con = new SQLiteConnection(@"datasource = C:\Users\admin\Desktop\Databases\sms.db"); // we are going to connect to this db.

        private void btnMediaFiles_Click(object sender, EventArgs e)
        {
            // connection object - connect to db
            //command object - write sql query
            string query = "SELECT * FROM MediaFiles";
            SQLiteCommand cmd = new SQLiteCommand(query, con); //what query to execute, what connection
                                                               // adapter - read data from db
                                                               // datatable - adapter will read data and write into datatable
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //execute this command and give us the data
            adapter.Fill(dt);

            dataGridView1.DataSource = dt; //where will I read data from
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            // connection object - connect to db
            //command object - write sql query
            string query = "SELECT * FROM MediaFiles WHERE FileType LIKE 'MP3'";
            SQLiteCommand cmd = new SQLiteCommand(query, con); //what query to execute, what connection
                                                               // adapter - read data from db
                                                               // datatable - adapter will read data and write into datatable
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //execute this command and give us the data
            adapter.Fill(dt);

            dataGridView1.DataSource = dt; //where will I read data from
        }

        private void btnImages_Click(object sender, EventArgs e)
        {
            // connection object - connect to db
            //command object - write sql query
            string query = "SELECT * FROM MediaFiles WHERE FileType LIKE 'JPEG'";
            SQLiteCommand cmd = new SQLiteCommand(query, con); //what query to execute, what connection
                                                               // adapter - read data from db
                                                               // datatable - adapter will read data and write into datatable
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //execute this command and give us the data
            adapter.Fill(dt);

            dataGridView1.DataSource = dt; //where will I read data from
        }

        private void btnShowFiles_Click(object sender, EventArgs e)
        {
            // connection object - connect to db
            //command object - write sql query
            string query = "SELECT * FROM MediaFiles WHERE FileType LIKE 'DOC' OR FileType LIKE 'XLS'";
            SQLiteCommand cmd = new SQLiteCommand(query, con); //what query to execute, what connection
                                                               // adapter - read data from db
                                                               // datatable - adapter will read data and write into datatable
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd); //execute this command and give us the data
            adapter.Fill(dt);

            dataGridView1.DataSource = dt; //where will I read data from
        }
    }
}
