using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace WindowsForms
{
	public partial class Font : Form
	{
		public System.Drawing.Font NewFont	{ get; set; }
		public System.Drawing.Font OldFont	{ get; set; }
		public Font()
		{
			InitializeComponent();
			if(Directory.GetCurrentDirectory().Contains("bin"))Directory.SetCurrentDirectory("..\\..\\Font");//меняем директорию на нашу папку
			string currentDirectory = Directory.GetCurrentDirectory();//записываем адрес в строку
			//MessageBox.Show(this,currentDirectory,"Current directory",MessageBoxButtons.OK);//выводим всплывающее окно с исправленным адресом
			foreach (string i in Directory.GetFiles(currentDirectory))
			{
				if(i.Split('\\').Last().Contains(".ttf"))this.cbFont.Items.Add(i.Split('\\').Last());//условие для вывода определенного типа файла
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			OldFont = NewFont;
			this.Close();
		}

		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			PrivateFontCollection pfs = new PrivateFontCollection();
			pfs.AddFontFile(cbFont.SelectedItem.ToString());
			NewFont = new System.Drawing.Font(pfs.Families[0],lblExample.Font.Size);
			lblExample.Font = NewFont;
		}
	}
}
