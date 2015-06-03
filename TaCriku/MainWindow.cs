
using System;
using System.Windows.Forms;

namespace TaCriku
{
	public class MainWindow : Form
	{
		private Label tb = new Label();

		public MainWindow ()
		{
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowIcon    = false;

			this.MinimumSize = new System.Drawing.Size(75, 75);
			this.Size = new System.Drawing.Size(120, 75);
			this.Font = new System.Drawing.Font("serif", 25);

			tb.Dock = DockStyle.Fill;
			tb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

			this.Controls.Add(tb);
			this.TextChanged += delegate {
				tb.Text = this.Text;
			};
		}
	}
}
