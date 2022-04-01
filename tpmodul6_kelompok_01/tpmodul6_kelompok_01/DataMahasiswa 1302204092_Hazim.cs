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
            String jsonString = File.ReadAllText("C:/Users/ASUS/Documents/SE4401/Semester 4/Konstruksi Perangkat Lunak/W6/TP/TP_MOD6/TP-MOD6-KPL/tpmodul6_kelompok_01/tpmodul6_kelompok_01/tp6_1_1302204092.json");

            //Deserialize Json file menjadi objek
            dynamic mahasiswa = JsonConvert.DeserializeObject(jsonString);
            
            Console.WriteLine("Nama " + mahasiswa.nama.depan + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        
        }
    }
}
