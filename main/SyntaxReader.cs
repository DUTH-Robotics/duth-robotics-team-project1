using System;
using System.IO;
using System.Collections;

namespace ColorSyntaxEditor
{
	public class SyntaxReader
	{
		private string TheFile;
		private  ArrayList Keywords = new ArrayList();
		private ArrayList  Functions = new ArrayList();
		private ArrayList  Comments = new ArrayList();
		public SyntaxReader(string file)
		{
			FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);
			TheFile = sr.ReadToEnd();
			sr.Close();
			fs.Close();
			FillArrays();
		}

		public void FillArrays()
		{
			StringReader sr = new StringReader(TheFile);
			string nextLine;

			nextLine = sr.ReadLine();
			nextLine = nextLine.Trim();

			// find functions header
			while (nextLine != null)
			{
				if (nextLine == "[FUNCTIONS]")
				{
					// read all of the functions into the arraylist
					nextLine = sr.ReadLine();
					if (nextLine != null)
						nextLine = nextLine.Trim();
					while (nextLine != null && nextLine[0] != '[' 
						)
					{
						Functions.Add(nextLine);

						nextLine = "";
						while (nextLine != null && nextLine == "")
						{
							nextLine = sr.ReadLine();
							if (nextLine != null)
								nextLine = nextLine.Trim();
						}
					}
				}

				if (nextLine == "[KEYWORDS]")
				{
					// read all of the functions into the arraylist
					nextLine = sr.ReadLine();
					if (nextLine != null)
						nextLine = nextLine.Trim();
					while (nextLine != null && nextLine[0] != '[' 
						)
					{
						Keywords.Add(nextLine);

						nextLine = "";
						while (nextLine != null && nextLine == "")
						{
							nextLine = sr.ReadLine();
							if (nextLine != null)
							nextLine = nextLine.Trim();
						}
						
					}
				}

				if (nextLine == "[COMMENTS]")
				{
					// read all of the functions into the arraylist
					nextLine = sr.ReadLine();
					if (nextLine != null)
						nextLine = nextLine.Trim();
					while (nextLine != null && nextLine[0] != '[' 
						)
					{
						Comments.Add(nextLine);

						nextLine = "";
						while (nextLine != null && nextLine == "")
						{
							nextLine = sr.ReadLine();
							if (nextLine != null)
								nextLine = nextLine.Trim();
						}
						
					}
				}

				if (nextLine != null && nextLine.Length > 0 && nextLine[0] == '[')
				{
				}
				else
				{
					nextLine = sr.ReadLine();
					if (nextLine != null)
						nextLine = nextLine.Trim();
				}
			}

			Keywords.Sort();
			Functions.Sort();
			Comments.Sort();
											
		}

		public bool IsKeyword(string s)
		{
			int index = Keywords.BinarySearch(s);
			if (index >= 0)
				return true;

			return false;
		}

		public bool IsFunction(string s)
		{
			int index = Functions.BinarySearch(s);
			if (index >= 0)
				return true;

			return false;
		}

		public bool IsComment(string s)
		{
			int index = Comments.BinarySearch(s);
			if (index >= 0)
				return true;

			return false;
		}


	}
}
