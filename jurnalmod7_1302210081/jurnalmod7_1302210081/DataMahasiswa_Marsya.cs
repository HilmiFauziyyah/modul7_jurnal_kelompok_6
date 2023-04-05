using System.Runtime.ExceptionServices;
using System.Text.Json;
class DataMahasiswa_1302213003
{
    public class DataMahasiswa
    {
        public string firstName { get; set;}
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public isi address { get; set; }
        


        public DataMahasiswa() { }

        public DataMahasiswa( string firstName, string lastName, string gender, int age, isi address )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender ;
            this.age = age ;    
            this.address = address ;
             
        }
    }
    public class isi
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public isi() { }

        public isi (string streetAddress, string city, string state)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }
   
    public void ReadJSON()
    {

        string JSON = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Downloads\\modul7_jurnal_kelompok_6\\jurnalmod7_1302210081\\jurnalmod7_1302210081\\jurnal7_1_1302213003.json");
        DataMahasiswa d = JsonSerializer.Deserialize<DataMahasiswa>(JSON);
        Console.WriteLine("----------Data Mahasiwa Tahun Masuk 2021----------");
        Console.WriteLine();
        Console.WriteLine($"Nama Panjang : {d.firstName + " " + d.lastName}");
        Console.WriteLine($"Jenis Kelamin : {d.gender}");
        Console.WriteLine($"Umur :{d.age}");
        Console.WriteLine($"Alamat : Jalan {d.address.streetAddress}, kota {d.address.city}");

    }
}
