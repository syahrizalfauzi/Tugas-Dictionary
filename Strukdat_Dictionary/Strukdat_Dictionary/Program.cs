using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukdat_Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> d = new Dictionary<string, int>();

			Console.WriteLine("Masukkan kalimat : ");
			string kalimat = Console.ReadLine();
			string[] arrayKata = kalimat.Split(' ');

			foreach (string kata in arrayKata)
			{
				if(!d.ContainsKey(kata))
					d.Add(kata, 1);
				else{
					int jumlah = d[kata];
					d[kata] = jumlah + 1;
				}
			}
			
			foreach(string key in d.Keys)
			{
				Console.WriteLine(key + " : " + d[key]);
			}

			Console.ReadKey();
		}
	}
}
