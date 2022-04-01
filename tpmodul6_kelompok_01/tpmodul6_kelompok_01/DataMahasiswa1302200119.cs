using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul6_kelompok_01
{
    internal class DataMahasiswa1302200119
    {
        //public namaMahasiswa nama { get; set; }
        //public int nim { get; set; }
        //public string fakultas { get; set; }
        public static void ReadJson()
        {
            //Baca file Json
            String jsonString = File.ReadAllText("A://Aliim/Semester 4/Konstruksi Perangkat Lunak/Minggu 6/praktikum/TP/tpmodul6_kelompok_01/tpmodul6_kelompok_01/tp6_1_1302200119.json");

            //Deserialize file json menjadi object
            //cara 1
            dynamic mahasiswa = JsonConvert.DeserializeObject(jsonString);

            //cara 2 tetapi menggunakan atribut di atas
            //DataMahasiswa1302200119 mahasiswa = JsonConvert.DeserializeObject<DataMahasiswa1302200119>(jsonString);
            Console.WriteLine(mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }

    }

    public class namaMahasiswa { 
        public string depan { get; set; }
        public string belakang { get; set; }

    }
}
