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
			string input = Console.ReadLine();
			string[] inputArray = input.Split(' ');

			foreach (string s in inputArray)
			{
				int jumlah;
				d.TryGetValue(s, out jumlah);
				
				if(!d.ContainsKey(s))
					d.Add(s, jumlah+1);
				else{
					d[s] = jumlah + 1;
				}
			}

			d.ToList().ForEach(x => Console.WriteLine(x.Key + " : " + x.Value));

			Console.ReadKey();
		}
	}
}
