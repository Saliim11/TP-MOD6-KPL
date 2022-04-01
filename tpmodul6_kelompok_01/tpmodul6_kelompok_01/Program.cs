using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpmodul6_kelompok_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302203122.ReadJson();
        }
    }
    class DataMahasiswa1302203122
    {

        public static void ReadJson()
        {
            //Baca File Json
            string jsonString = File.ReadAllText("C:/SEMESTER 4/KONSTRUKSI PERANGKAT LUNAK/TP_6/tp6_1_1302203122.json");

            //Desereliase file json menjadi object
            dynamic mahasiswa = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine(mahasiswa.nama.depan +" "+ mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " fakultas " + mahasiswa.fakultas);
        }

    }
}
