using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_01
{
    internal class DataMahasiswa1302200089
    {
        public static void ReadJson()
        {
            //baca file json
            String jsonString = File.ReadAllText("A://Aliim/Semester 4/Konstruksi Perangkat Lunak/Minggu 6/praktikum/TP/tpmodul6_kelompok_01/tpmodul6_kelompok_01/tp6_1_1302200089.json");

            //Deserealize file json jadi object
            dynamic mahasiswa = JsonConvert.DeserializeObject(jsonString);
            //ntahlah
            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan NIM " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
        
    }
}
