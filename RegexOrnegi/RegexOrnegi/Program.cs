using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexOrnegi
{
    /// <summary>
    /// Regular Expression ile text üzerinde veri yakalama
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 08.06.2019 01:25
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "veri.txt");
            List<int[]> liste = ParseData(path);

            Console.WriteLine($"Toplam {liste.Count} adet veri bulundu.\r\nVeriler şu şekildedir : ");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine($"Sıra : {i+1} Veri 1 : {liste[i][0]} Veri 2 : {liste[i][1]} Veri 3 : {liste[i][2]}");
            }
        }

        private static List<int[]> ParseData(string path)
        {
            List<int[]> retList = new List<int[]>();

            string pattern = @"\[(\d+) (\d+) (\d+)\]";

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string veri = reader.ReadToEnd();
                    MatchCollection result = Regex.Matches(veri, pattern, RegexOptions.Multiline | RegexOptions.IgnoreCase);
                    if (result.Count > 0)
                    {
                        for (int i = 0; i < result.Count; i++)
                        {
                            if (result[i].Groups.Count == 4)
                            {
                                try
                                {
                                    int[] retArray = new int[3];
                                    int.TryParse(result[i].Groups[1].Value, out retArray[0]);
                                    int.TryParse(result[i].Groups[2].Value, out retArray[1]);
                                    int.TryParse(result[i].Groups[3].Value, out retArray[2]);
                                    retList.Add(retArray);
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                        }

                    }
                }
            }
            return retList;
        }
    }
}
