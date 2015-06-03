using System;

namespace TaCriku
{
	public class Program
	{
		public static void Main ()
		{
			int count = 0;
			MainWindow mw = new MainWindow();
			mw.Text = count.ToString();

			mw.Controls[0].Click += delegate {
				count++;
				mw.Text = count.ToString();
			};

			mw.ShowDialog();
			Console.WriteLine(count);
		}
	}
}
