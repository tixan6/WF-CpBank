using Coursework.Scripts;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class count : Form
    {
        private DataTable table = null;
        public count()
        {
            InitializeComponent();
        }

        private void count_Load(object sender, EventArgs e)
        {
            ConnectToDB db = new ConnectToDB();
            NpgsqlDataReader result = db.connection("SELECT * FROM publics.\"Calc\";");


            List<string[]> data = new List<string[]>();

            while (result.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = result[0].ToString();
                data[data.Count - 1][1] = result[1].ToString();
                data[data.Count - 1][2] = result[2].ToString();
                data[data.Count - 1][3] = result[3].ToString();
                data[data.Count - 1][4] = result[4].ToString();
                data[data.Count - 1][5] = result[5].ToString();
                data[data.Count - 1][6] = result[6].ToString();
                data[data.Count - 1][7] = result[7].ToString();
                data[data.Count - 1][8] = result[8].ToString();
            }

            result.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);


        }
    }
}
