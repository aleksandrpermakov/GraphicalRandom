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
		TextBox tb2;
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
			//tb2.Text = e.Location.X.ToString() + "  " + e.Location.Y.ToString();
		}

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
			Point clickMouse = mouse.Location;
            TextBox tbXY = new TextBox();
            tbXY.Location = clickMouse;
            tbXY.Size = tbX_location.Size;
            tbXY.TabIndex = tbX_location.TabIndex + tb.TabIndex +1;
            tbXY.Name = "tbXY";
            tbXY.Text = "Y - " + mouse.Location.Y.ToString() + "  " + "X - " + mouse.Location.X.ToString();
            tbXY.Font = tb.Font;
			this.tb2 = tbXY;
           
            Controls.Add(tbXY);
            

        }
    }
}
