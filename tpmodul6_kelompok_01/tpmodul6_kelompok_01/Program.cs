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



        }
    }
}
