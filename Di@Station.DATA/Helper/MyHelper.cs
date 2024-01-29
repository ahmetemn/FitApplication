using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Station.DATA.Helper
{
	public class MyHelper
	{
		public static string TurkishToEnglish(string charcter)
		{
			string turkishChracter = "ığüşöç ";
			string englishChracter = "igusoc-";

			for (int i = 0; i < turkishChracter.Length; i++)
			{
				charcter = charcter.ToLower().Replace(turkishChracter[i], englishChracter[i]);
			}

			return charcter;
		}
	}
}