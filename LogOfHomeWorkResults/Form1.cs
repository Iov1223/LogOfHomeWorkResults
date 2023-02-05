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
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;");
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string _date = comboBoxDate.Text;
                string _SqlExpression = $"USE [LogResults] SELECT [Grade] FROM [dbo].[Results] WHERE [HomeWorkFrom] = '{_date}'";
                SqlCommand command = new SqlCommand(_SqlExpression, connection);
                connection.Open();
                var reader = command.ExecuteScalar();
                if (reader != null)
                {
                    textBoxMark.Text = reader.ToString();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные.");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось получить данные.");
            }
        }

        private void buttonMiddleMark_Click(object sender, EventArgs e)
        {
            try
            {
                string _SqlExpression = "USE [LogResults] SELECT SUM(Grade) / 24.0 AS [AverageScore] FROM [dbo].[Results]";
                SqlCommand command = new SqlCommand(_SqlExpression, connection);
                connection.Open();
                var reader = command.ExecuteScalar();
                if (reader != null)
                {
                    double _tmp = Convert.ToDouble(reader);
                    buttonMiddleMark.Text = "Средний балл за курс \"Введение в WF и WPF\" = " + _tmp.ToString("0.0");
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные.");
                }
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось получить данные.");
            }
        }
    }
}
