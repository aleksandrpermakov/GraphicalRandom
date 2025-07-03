using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
        TextBox tb; 
		public Form1()
		{
			InitializeComponent();
			CreetyTextBox(tbX_location); 

		}
		public void CreetyTextBox(TextBox tb)
		{
			TextBox tbY = new TextBox();
			tbY.Location = new Point(tb.Size.Width + 200, tb.Location.Y);
			tbY.Size = tbX_location.Size;
			tbY.TabIndex = tbX_location.TabIndex +1;
            tbY.Name = "tbY";
            tbY.Text = tb.Location.Y.ToString();
			tbY.Font = tb.Font;
            Controls.Add(tbY);
			this.tb = tbY;


        }

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			tbX_location.Text =  e.Location.X.ToString();
			tb.Text = e.Location.Y.ToString();
		}
	}
}
