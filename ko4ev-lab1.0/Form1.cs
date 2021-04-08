using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ko4ev_lab1._0
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbb1.mdb;";

        private OleDbConnection myConnection;
        public int id = 1;
        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbb1DataSet.master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.dbb1DataSet.master);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbb1DataSet.holdings". При необходимости она может быть перемещена или удалена.
            this.holdingsTableAdapter.Fill(this.dbb1DataSet.holdings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbb1DataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.dbb1DataSet.clients);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            string myVariable = id.ToString();

            string qode = "SELECT COUNT(1) FROM clients";
            OleDbCommand main_command = new OleDbCommand(qode, myConnection);



            int main_id = Convert.ToInt32(main_command.ExecuteScalar().ToString());

            if (id < 0 || id > main_id)
                  {
                   MessageBox.Show("Більше клієнтів немає");
                  }
            else
            {
                id = id + 1;

                string dqd = "SELECT Код from clients where Код = ";
                string kod = (dqd + myVariable);
                OleDbCommand kodd = new OleDbCommand(kod, myConnection);
                textBox16.Text = kodd.ExecuteScalar().ToString();



                string query = "SELECT LAST_NAME from clients where Код = ";
                string qqq = (query + myVariable);
                string query1 = "SELECT FIRST_NAME from clients where Код = ";
                string qqq1 = (query1 + myVariable);
                string query2 = "SELECT ACCT_NBR from clients where Код = ";
                string qqq2 = (query2 + myVariable);
                string query3 = "SELECT ADDRESS_1 from clients where Код = ";
                string qqq3 = (query3 + myVariable);
                string query4 = "SELECT CITY from clients where Код = ";
                string qqq4 = (query4 + myVariable);
                string query5 = "SELECT STATE from clients where Код = ";
                string qqq5 = (query5 + myVariable);
                string query6 = "SELECT ZIP from clients where Код = ";
                string qqq6 = (query6 + myVariable);
                string query7 = "SELECT TELEPHONE from clients where Код = ";
                string qqq7 = (query7 + myVariable);
                string query8 = "SELECT DATE_OPEN from clients where Код = ";
                string qqq8 = (query8 + myVariable);
                string query9 = "SELECT SS_NUMBER from clients where Код = ";
                string qqq9 = (query9 + myVariable);
                string query10 = "SELECT BIRTH_DATE from clients where Код = ";
                string qqq10 = (query10 + myVariable);
                string query11 = "SELECT RISK_LEVEL from clients where Код = ";
                string qqq11 = (query11 + myVariable);
                string query12 = "SELECT OCCUPATION from clients where Код = ";
                string qqq12 = (query12 + myVariable);
                string query13 = "SELECT OBJECTIVES from clients where Код = ";
                string qqq13 = (query13 + myVariable);
                string query14 = "SELECT INTERESTS from clients where Код = ";
                string qqq14 = (query14 + myVariable);
                string query15 = "SELECT PICTURE from clients where Код = ";
                string qqq15 = (query15 + myVariable);


                OleDbCommand command = new OleDbCommand(qqq, myConnection);
                textBox1.Text = command.ExecuteScalar().ToString();
                OleDbCommand command1 = new OleDbCommand(qqq1, myConnection);
                textBox2.Text = command1.ExecuteScalar().ToString();
                OleDbCommand command2 = new OleDbCommand(qqq2, myConnection);
                textBox3.Text = command2.ExecuteScalar().ToString();
                OleDbCommand command3 = new OleDbCommand(qqq3, myConnection);
                textBox4.Text = command3.ExecuteScalar().ToString();
                OleDbCommand command4 = new OleDbCommand(qqq4, myConnection);
                textBox9.Text = command4.ExecuteScalar().ToString();
                OleDbCommand command5 = new OleDbCommand(qqq5, myConnection);
                textBox5.Text = command5.ExecuteScalar().ToString();
                OleDbCommand command6 = new OleDbCommand(qqq6, myConnection);
                textBox6.Text = command6.ExecuteScalar().ToString();
                OleDbCommand command7 = new OleDbCommand(qqq7, myConnection);
                textBox10.Text = command7.ExecuteScalar().ToString();
                OleDbCommand command8 = new OleDbCommand(qqq8, myConnection);
                textBox7.Text = command8.ExecuteScalar().ToString();
                OleDbCommand command9 = new OleDbCommand(qqq9, myConnection);
                textBox8.Text = command9.ExecuteScalar().ToString();
                OleDbCommand command10 = new OleDbCommand(qqq10, myConnection);
                textBox11.Text = command10.ExecuteScalar().ToString();
                OleDbCommand command11 = new OleDbCommand(qqq11, myConnection);
                textBox14.Text = command11.ExecuteScalar().ToString();
                OleDbCommand command12 = new OleDbCommand(qqq12, myConnection);
                textBox13.Text = command12.ExecuteScalar().ToString();
                OleDbCommand command13 = new OleDbCommand(qqq13, myConnection);
                textBox12.Text = command13.ExecuteScalar().ToString();
                OleDbCommand command14 = new OleDbCommand(qqq14, myConnection);
                textBox15.Text = command14.ExecuteScalar().ToString();

                string qr12 = "SELECT IMAGE from clients where Код = ";
                string qr13 = (qr12 + myVariable);
                OleDbCommand qr1 = new OleDbCommand(qr13, myConnection);
                string put = qr1.ExecuteScalar().ToString();

                pictureBox1.Load(put);




                string dg1 = "SELECT * FROM holdings where ACCT_NBR= ";
                string q1q = command2.ExecuteScalar().ToString();
                string q1q1 = (dg1 + "'" + q1q + "'");

                OleDbCommand command20 = new OleDbCommand(q1q1, myConnection);



                DataSet dataSet = new DataSet();
                OleDbDataAdapter adapter_Books = new OleDbDataAdapter(new OleDbCommand(q1q1, myConnection));
                var cb_adapter_Books = new OleDbCommandBuilder(adapter_Books);
                adapter_Books.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.Columns[1].HeaderText = "Номер аккаунту";
                dataGridView1.Columns[2].HeaderText = "Символ";
                dataGridView1.Columns[3].HeaderText = "Акції";
                dataGridView1.Columns[4].HeaderText = "Вартість покупки";
                dataGridView1.Columns[5].HeaderText = "Дата придбання";
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string qode = "SELECT COUNT(1) FROM clients";
            OleDbCommand main_command = new OleDbCommand(qode, myConnection);
            textBox16.Text = main_command.ExecuteScalar().ToString();
            int main_id = Convert.ToInt32(main_command.ExecuteScalar().ToString());
            if (id == 1 )
            {
                MessageBox.Show("Більше клієнтів немає");
            }
            else
            {

                id = id - 1;
                string myVariable = id.ToString();

                string dqd = "SELECT Код from clients where Код = ";
                string kod = (dqd + myVariable);
                OleDbCommand kodd = new OleDbCommand(kod, myConnection);
                textBox16.Text = kodd.ExecuteScalar().ToString();

                string query = "SELECT LAST_NAME from clients where Код = ";
                string qqq = (query + myVariable);
                string query1 = "SELECT FIRST_NAME from clients where Код = ";
                string qqq1 = (query1 + myVariable);
                string query2 = "SELECT ACCT_NBR from clients where Код = ";
                string qqq2 = (query2 + myVariable);
                string query3 = "SELECT ADDRESS_1 from clients where Код = ";
                string qqq3 = (query3 + myVariable);
                string query4 = "SELECT CITY from clients where Код = ";
                string qqq4 = (query4 + myVariable);
                string query5 = "SELECT STATE from clients where Код = ";
                string qqq5 = (query5 + myVariable);
                string query6 = "SELECT ZIP from clients where Код = ";
                string qqq6 = (query6 + myVariable);
                string query7 = "SELECT TELEPHONE from clients where Код = ";
                string qqq7 = (query7 + myVariable);
                string query8 = "SELECT DATE_OPEN from clients where Код = ";
                string qqq8 = (query8 + myVariable);
                string query9 = "SELECT SS_NUMBER from clients where Код = ";
                string qqq9 = (query9 + myVariable);
                string query10 = "SELECT BIRTH_DATE from clients where Код = ";
                string qqq10 = (query10 + myVariable);
                string query11 = "SELECT RISK_LEVEL from clients where Код = ";
                string qqq11 = (query11 + myVariable);
                string query12 = "SELECT OCCUPATION from clients where Код = ";
                string qqq12 = (query12 + myVariable);
                string query13 = "SELECT OBJECTIVES from clients where Код = ";
                string qqq13 = (query13 + myVariable);
                string query14 = "SELECT INTERESTS from clients where Код = ";
                string qqq14 = (query14 + myVariable);
                string query15 = "SELECT PICTURE from clients where Код = ";
                string qqq15 = (query15 + myVariable);


                OleDbCommand command = new OleDbCommand(qqq, myConnection);
                textBox1.Text = command.ExecuteScalar().ToString();
                OleDbCommand command1 = new OleDbCommand(qqq1, myConnection);
                textBox2.Text = command1.ExecuteScalar().ToString();
                OleDbCommand command2 = new OleDbCommand(qqq2, myConnection);
                textBox3.Text = command2.ExecuteScalar().ToString();
                OleDbCommand command3 = new OleDbCommand(qqq3, myConnection);
                textBox4.Text = command3.ExecuteScalar().ToString();
                OleDbCommand command4 = new OleDbCommand(qqq4, myConnection);
                textBox9.Text = command4.ExecuteScalar().ToString();
                OleDbCommand command5 = new OleDbCommand(qqq5, myConnection);
                textBox5.Text = command5.ExecuteScalar().ToString();
                OleDbCommand command6 = new OleDbCommand(qqq6, myConnection);
                textBox6.Text = command6.ExecuteScalar().ToString();
                OleDbCommand command7 = new OleDbCommand(qqq7, myConnection);
                textBox10.Text = command7.ExecuteScalar().ToString();
                OleDbCommand command8 = new OleDbCommand(qqq8, myConnection);
                textBox7.Text = command8.ExecuteScalar().ToString();
                OleDbCommand command9 = new OleDbCommand(qqq9, myConnection);
                textBox8.Text = command9.ExecuteScalar().ToString();
                OleDbCommand command10 = new OleDbCommand(qqq10, myConnection);
                textBox11.Text = command10.ExecuteScalar().ToString();
                OleDbCommand command11 = new OleDbCommand(qqq11, myConnection);
                textBox14.Text = command11.ExecuteScalar().ToString();
                OleDbCommand command12 = new OleDbCommand(qqq12, myConnection);
                textBox13.Text = command12.ExecuteScalar().ToString();
                OleDbCommand command13 = new OleDbCommand(qqq13, myConnection);
                textBox12.Text = command13.ExecuteScalar().ToString();
                OleDbCommand command14 = new OleDbCommand(qqq14, myConnection);
                textBox15.Text = command14.ExecuteScalar().ToString();

                string qr12 = "SELECT IMAGE from clients where Код = ";
                string qr13 = (qr12 + myVariable);
                OleDbCommand qr1 = new OleDbCommand(qr13, myConnection);
                string put = qr1.ExecuteScalar().ToString();

                pictureBox1.Load(put);




                string dg1 = "SELECT * FROM holdings where ACCT_NBR= ";
                string q1q = command2.ExecuteScalar().ToString();
                string q1q1 = (dg1 + "'" + q1q + "'");

                OleDbCommand command20 = new OleDbCommand(q1q1, myConnection);



                
                DataSet dataSet = new DataSet();
                OleDbDataAdapter adapter_Books = new OleDbDataAdapter(new OleDbCommand(q1q1, myConnection));
                var cb_adapter_Books = new OleDbCommandBuilder(adapter_Books);
                adapter_Books.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];



            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void helpContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Process.Start(@"D:\QUARANTIN III\Технол. створ. програм. прод\help/lab2help.chm");
            Help.ShowHelp(this, "D:/QUARANTIN III/Технол. створ. програм. прод/help/lab2help.chm", HelpNavigator.Topic, "topic2.html");
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void проНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "D:/QUARANTIN III/Технол. створ. програм. прод/help/lab2help.chm", HelpNavigator.Topic, "about.html");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
