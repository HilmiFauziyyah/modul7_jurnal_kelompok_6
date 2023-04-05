using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace mod7_jurnal_1302210081
{
    public class DataMahasiswa1302210081
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public alamat address { get; set; }
        public int age { get; set; }
        public string code { get; set; }
        public string matkul { get; set; }

        public string gender { get; set; }
        public DataMahasiswa1302210081() { }

        public DataMahasiswa1302210081(string firstName, string lastName, string gender, int age, alamat address, string code, string matkul)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.gender = gender;
            this.age = age;
            this.address= address;
            this.code = code;
            this.matkul = matkul;
        }
        public class alamat
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public alamat() { }
            public alamat (string streetAddress, string city, string state)
            {
                this.streetAddress = streetAddress; 
                this.city = city;
                this.state = state;
            }

        }


        public void ReadJSON()
        {
            string file = ("C:\\Users\\PRAKTIKAN\\Documents\\modul7_jurnal_kelompok_6\\jurnalmod7_1302210081\\jurnalmod7_1302210081\\DataMahasiswa.json");
            string JSON = File.ReadAllText(file);
            DataMahasiswa1302210081 M = JsonSerializer.Deserialize<DataMahasiswa1302210081>(JSON);
            Console.WriteLine($"Nama :  {M.firstName + " " + M.lastName}");
            Console.WriteLine($"Umur : {M.age}");
            Console.WriteLine($"Gender : {M.gender}");
            Console.WriteLine($"Alamat: jalan {M.address.streetAddress}, kota {M.address.city}");
        }

    }
}

