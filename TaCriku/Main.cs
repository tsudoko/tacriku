
using System;

namespace TaCriku
{


	public class Program
	{

		public static void Main ()
		{
			MainWindow mw = new MainWindow();
			int count = 0;
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
