using System;
using System.Windows.Forms;

namespace TaCriku
{
	public class Program
	{
		public static void Main ()
		{
			int count = 0;
			MainWindow mw = new MainWindow();
			mw.Text = count.ToString();

			mw.Controls[0].MouseClick += delegate(Object s, MouseEventArgs e) {
				switch(e.Button) {
					case MouseButtons.Left:
						count++;
					break;
					case MouseButtons.Right:
						count--;
					break;
				}

				mw.Text = count.ToString();
			};

			mw.ShowDialog();
			Console.WriteLine(count);
		}
	}
}
