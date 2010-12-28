
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
			tb.Left = 0;
			tb.Top = 0;
			tb.Size = new System.Drawing.Size(120, 75);
			this.Font = new System.Drawing.Font("Arial", 25);
			tb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.Controls.Add(tb);
			this.TextChanged += delegate {
				tb.Text = this.Text;
			};

			
		}
	}
}
