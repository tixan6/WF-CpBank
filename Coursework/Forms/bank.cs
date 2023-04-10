using Coursework.Scripts;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework.Forms
{
    public partial class bank : Form
    {
        ConnectToDB connectToDB = new ConnectToDB();
        private string name0fBank;
        private string pick;
        private decimal perc;
        private decimal sum;
        private decimal term;
        private decimal yesrs;
        private decimal result;
        private decimal all;
        private decimal everyMonthPay;
        public bank(string name)
        {
            InitializeComponent();
            nameBank.Text = name;
            this.name0fBank = name;
            Percent(name);
            TypeOfLoan();
        }
        private void TypeOfLoan()
        {        
            NpgsqlDataReader data = connectToDB.connection("SELECT DISTINCT \"type_name\" FROM publics.\"TypeOfLoan\";");
            if (data is NpgsqlDataReader)
            {
                while (data.Read())
                {
                    comboBox1.Items.Add(data.GetValue(0).ToString());
                }

            }
            else { MessageBox.Show("Ошибка вывода данных из базы"); }
        }   


        private void Percent(string name)
        {        
            NpgsqlDataReader data = connectToDB.connection($"SELECT publics.\"TypeOfLoan\".\"percent\" FROM publics.\"TypeOfLoan\" JOIN publics.\"Banks\" ON publics.\"TypeOfLoan\".\"id\"= publics.\"Banks\".\"id_typeLoan\" where \"Banks\".\"name\" = '{name}'");
            if (data is NpgsqlDataReader)
            {
                while (data.Read())
                {
                    comboBox2.Items.Add(data.GetValue(0).ToString() + "%");
                }
            }
            else { MessageBox.Show("Ошибка вывода данных из базы"); }
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            if (all != 0 && pick != null && pick != string.Empty)
            {
                connectToDB.connection($"INSERT INTO publics.\"Calc\" (\"prepayment\", \"amount\", \"data\", \"type\", \"sum\", \"perc\", \"nameofBank\", \"everyMonth\") VALUES ('{all.ToString()}', '{result.ToString()}', '{DateTime.Now.Date}', '{pick}', '{sum.ToString()}', '{perc.ToString()}', '{name0fBank}', '{everyMonthPay.ToString()}')");
                MessageBox.Show("Данные были успешно занесены в базу");
            }
            else
            {
                MessageBox.Show("Завершите рассчеты");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {   
            try
            {
                pick = comboBox1.Text;
                //Процент
                perc = Convert.ToDecimal(comboBox2.Text.Replace("%", ""));
                //Сумма
                sum = Convert.ToDecimal(textBox1.Text);
                //Срок кредитования
                term = Convert.ToDecimal(textBox2.Text);

                //Проценты по займу в год
                yesrs = (perc / 100) * 365 * 10;
                result = sum * yesrs / 365 * term;
                result = result / 100;
                label9.Text = result.ToString();
                all = result + sum;
                everyMonthPay = all / term;
                label10.Text = all.ToString();
                label11.Text = everyMonthPay.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка ввода!");
            }
        }

        private void bank_Load(object sender, EventArgs e)
        {

        }
    }
}
