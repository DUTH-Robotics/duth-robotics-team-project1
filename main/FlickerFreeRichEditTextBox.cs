using System;
using System.Windows.Forms;
namespace ColorSyntaxEditor
{
	/// <summary>
	/// Summary description for FlickerFreeRichEditTextBox.
	/// </summary>
	public class FlickerFreeRichEditTextBox : RichTextBox
	{

// #define WM_PAINT                        0x000F

		const short  WM_PAINT = 0x00f;

		public FlickerFreeRichEditTextBox()
		{
			//
			// TODO: Add constructor logic here
			//
//			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
//			SetStyle(ControlStyles.DoubleBuffer , true);
//			SetStyle(ControlStyles.UserPaint , true);
		}


		public static bool _Paint = true;
		protected override void WndProc(ref System.Windows.Forms.Message m) 
		{

			// sometimes we want to eat the paint message so we don't have to see all the 
			//  flicker from when we select the text to change the color.

			if (m.Msg == WM_PAINT) 
			{

				if (_Paint)

					base.WndProc(ref m);

				else

					m.Result = IntPtr.Zero;

			}

			else

				base.WndProc (ref m);

		}

 


	}
}
