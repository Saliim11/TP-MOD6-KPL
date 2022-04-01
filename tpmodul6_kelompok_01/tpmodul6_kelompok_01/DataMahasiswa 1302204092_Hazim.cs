using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul6_kelompok_01
{
    internal class DataMahasiswa_1302204092_Hazim
    {
        public void ReadJSON()
        {
            //baca file Json
            String jsonString = File.ReadAllText("A://Aliim/Semester 4/Konstruksi Perangkat Lunak/Minggu 6/praktikum/TP/tpmodul6_kelompok_01/tpmodul6_kelompok_01/tp6_1_1302204092.json");

            //Deserialize Json file menjadi objek
            dynamic mahasiswa = JsonConvert.DeserializeObject(jsonString);
            
            Console.WriteLine("Nama " + mahasiswa.nama.depan + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        
        }
    }
}
