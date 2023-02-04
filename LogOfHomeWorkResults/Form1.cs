using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LogOfHomeWorkResults
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;");
        public Form1()
        {
            InitializeComponent();
        }

        private void labelMiddleMark_Click(object sender, EventArgs e)
        {
            string SqlExpression = "USE [LogResults] SELECT SUM(Grade) / 24.0 AS [AverageScore] FROM [dbo].[Results]";
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            MessageBox.Show(reader.GetValue(0).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();  
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SqlExpression = "USE [LogResults] SELECT SUM(Grade) / 24.0 AS [AverageScore] FROM [dbo].[Results]";
            SqlCommand command = new SqlCommand(SqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            MessageBox.Show(reader.GetValue(0).ToString());
        }
    }
}
