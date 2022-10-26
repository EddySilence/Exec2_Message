using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultButton_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			string result = string.Empty;
			if (hour >= 0 && hour < 12)
			{
				result = "早安";
			}
			else if (hour >= 12 && hour < 19)
			{
				result = "午安";
			}
			else
			{
				result = "晚安";
			}
			MessageBox.Show($"{now:yyyy/MM/dd HH:mm:ss}");
			resultLabel.Text = $"你好，{result}   {now}";
		}
	}
}
