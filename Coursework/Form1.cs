using Coursework.Forms;
using Coursework.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Form1 : Form
    {
        ConnectToDB connectToDB;
        private Form form;
        public Form1()
        {
            InitializeComponent();
            
        }
        //Бел-Вэб
        private void button2_Click(object sender, EventArgs e)
        {
            showBank(new bank(belweb.Text));
        }


        //Альфа банк
        private void button1_Click(object sender, EventArgs e)
        {
            showBank(new bank(Alfa.Text));
        }




        private void showBank(Form fm) 
        {
            if (form != null)
                form.Close();
            form = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fm);
            this.panel2.Tag = fm;
            fm.BringToFront();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showBank(new bank(BTB.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showBank(new bank(Dabrabit.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showBank(new bank(BelBank.Text));
        }


        //Рассчеты
        private void button6_Click(object sender, EventArgs e)
        {
            showBank(new count());
        }
    }
}
