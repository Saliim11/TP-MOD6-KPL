﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul6_kelompok_01
{
    internal class DataMahasiswa_1302204116
    {
		public static void ReadJson()
		{
			string jsonString = File.ReadAllText("C:/RAFI/KULIAH/Semester 4/Kontruksi Perangkat Lunak/TP/tpmodul6_kelompok_01/TP-MOD6-KPL/tpmodul6_kelompok_01/tpmodul6_kelompok_01/tp6_1_1302204116.json");

			dynamic mahasiswa = JsonConvert.DeserializeObject(jsonString);

			Console.WriteLine(mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim : " + mahasiswa.nim + " " + mahasiswa.fakultas);
		}
	}
}
