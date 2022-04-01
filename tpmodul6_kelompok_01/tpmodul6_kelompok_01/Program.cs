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

            DataMahasiswa_1302204092_Hazim obj1 = new DataMahasiswa_1302204092_Hazim();
            obj1.ReadJSON();


            DataMahasiswa1302200089.ReadJson();

            DataMahasiswa1302203122.ReadJson();

            DataMahasiswa_1302204116.ReadJson();

            DataMahasiswa1302200119.ReadJson();

            //Data Kuliah Alim
            KuliahMahasiswa1302200119.ReadJSON();

        }
    }

    class DataMahasiswa1302203122
    {

        public static void ReadJson()
        {
            //Baca File Json
            string jsonString = File.ReadAllText("A://Aliim/Semester 4/Konstruksi Perangkat Lunak/Minggu 6/praktikum/TP/tpmodul6_kelompok_01/tpmodul6_kelompok_01/tp6_1_1302203122.json");

            //Desereliase file json menjadi object
            dynamic mahasiswa = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine(mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " fakultas " + mahasiswa.fakultas);
        }

    }
}
