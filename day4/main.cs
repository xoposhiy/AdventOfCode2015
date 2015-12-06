using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Text;

public class Day03
{
	public static void Main()
	{
		var key = "yzbqklnj";
		var md5 = MD5.Create();
		var q = 
			from i in Enumerable.Range(0, int.MaxValue)
			let hash = string.Join("", md5.ComputeHash(Encoding.ASCII.GetBytes(key + i)).Select(b => b.ToString("x2")))
			select new {i, hash};
			
		Console.WriteLine(q.First(h => h.hash.StartsWith("00000")).i);
		Console.WriteLine(q.First(h => h.hash.StartsWith("000000")).i);
	}
}