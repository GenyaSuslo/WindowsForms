using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			label3.Text = DateTime.Now.ToString("HH:mm:ss ");
			if(cbShowDate.Checked)label3.Text+=$"\n{DateTime.Now.ToString("dd.MM.yyyy")}";
		}

		private void label3_DoubleClick(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.Sizable;
			this.TransparencyKey = Color.AliceBlue;
			this.ShowInTaskbar = true;
			this.cbShowDate.Visible = true;
			this.button1.Visible = true;
			

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = Control.DefaultBackColor;
            this.ShowInTaskbar = false;
            this.cbShowDate.Visible = false;
            this.button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
			this.Close();
        }

    }
}
