using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_01
{
    internal class KuliahMahasiswa1302200119
    {
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("A://Aliim/Semester 4/Konstruksi Perangkat Lunak/Minggu 6/praktikum/TP/tpmodul6_kelompok_01/tpmodul6_kelompok_01/tp6_2_1302200119.json");

            dynamic dataList = JsonConvert.DeserializeObject(jsonString);

            int index = 0;
            foreach (var item in dataList.courses)
            {
                index++;
                Console.WriteLine("MK "+index+" "+item.code+" - "+item.name);
            }
        }
    }
}
