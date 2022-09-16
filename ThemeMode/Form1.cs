using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel1.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel2.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel3.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel4.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel5.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel6.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel7.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, flowLayoutPanel1.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, panel2.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, panel3.Controls, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewGetData();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000; //WS_EX_COMPOSITED
                return handleParam;
            }
        }

        public void DataGridViewGetData()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add("Row" + i, "Row" + i, "Row" + i, "Row" + i, "Row" + i);
                dataGridView2.Rows.Add("Row" + i, "Row" + i, "Row" + i, "Row" + i, "Row" + i);
            }

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel1.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel2.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel3.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel4.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel5.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel6.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, tableLayoutPanel7.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, flowLayoutPanel1.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, panel2.Controls, this);
            Theme.ChangeTheme(checkBox1.Checked, panel3.Controls, this);
        }      
    }
}
