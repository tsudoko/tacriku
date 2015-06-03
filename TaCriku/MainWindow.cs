
using System;
using System.Windows.Forms;

namespace TaCriku
{


	public class MainWindow : Form
	{
		private Label tb = new Label();
		

		public MainWindow ()
		{
			this.Size = new System.Drawing.Size(120, 75);
			tb.Dock = DockStyle.Fill;
			this.Font = new System.Drawing.Font("Arial", 25);
			tb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Controls.Add(tb);
			this.TextChanged += delegate {
				tb.Text = this.Text;
			};

			
		}
	}
}
