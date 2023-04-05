using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace jurnalmod7_1302210081
{
    internal class DataMahasiswa_1302210076
    {
        public class DataMahasiswa
        {
            public namaMahasiswa nama { get; set; }

            public int age { get; set; }

            public string gender { get; set; }

            public string address { get; set; }

            public string courses { get; set; }

            public DataMahasiswa(namaMahasiswa nama, int age, string gender, alamat address, matkul course)
            {
                this.nama = nama;
                this.age = age;
                this.gender = gender;
                this.address = address;
                this.courses = course;
            }
        }
        public class namaMahasiswa
        {
            public string depan { get; set; }
            public string belakang { get; set; }



            public namaMahasiswa(string depan, string belakang)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }

        public class alamat
        {
            public string jalan { get; set; }
            public string city { get; set; }
            public string state { get; set; }



            public alamat(string jalan, string city, string state)
            {
                this.jalan = jalan;
                this.city = city;
                this.state = state;
            }

            public static implicit operator string(alamat v)
            {
                throw new NotImplementedException();
            }
        }

        public class matkul
        {
            public string code { get; set; }

            public string name { get; set; }


            public matkul(string code, string name)
            {
                this.code = code;
                this.name = name;
            }

            public static implicit operator string(matkul v)
            {
                throw new NotImplementedException();
            }
        }

        public void ReadJSON()
        {
            string file = "C:\\Users\\PRAKTIKAN\\source\\repos\\modul7_jurnal_kelompok_6_1302210076\\" +
                "jurnalmod7_1302210081\\jurnalmod7_1302210081\\jurnal7_1_1302210076.json";
            string JSON = File.ReadAllText(file);
            DataMahasiswa d = JsonSerializer.Deserialize<DataMahasiswa>(JSON);
            Console.WriteLine($"Nama {d.nama.depan + " " + d.nama.belakang} umur {d.age} gender " +
                $"{d.gender} matkul {d.courses} dan alamat {d.address}");

        }
    }
}
