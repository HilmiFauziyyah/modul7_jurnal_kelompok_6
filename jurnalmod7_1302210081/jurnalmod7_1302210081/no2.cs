using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace mod7_jurnal_1302210081
{
    public class no2
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int gender { get; set; }
        public int age { get; set; }
        public no2() { }
        public no2(string firtName, string lastName, int gender, int age)
        {
            this.firstName = firtName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
        }
        public void ReadJSON()
        {
            string file = ("C:\\Users\\PRAKTIKAN\\Documents\\modul7_jurnal_kelompok_6\\jurnalmod7_1302210081\\jurnalmod7_1302210081\\jurnar7_2_1302210081.json");
            string JSON = File.ReadAllText(file);
            DataMahasiswa1302210081 M = JsonSerializer.Deserialize<DataMahasiswa1302210081>(JSON);
            Console.WriteLine($"Nama :  {M.firstName + " " + M.lastName}");
            Console.WriteLine($"Umur : {M.age}");
            Console.WriteLine($"Gender : {M.gender}");
        }
    }
}