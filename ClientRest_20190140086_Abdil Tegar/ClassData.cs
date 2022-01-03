using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;


namespace ClientRest_20190140086_Abdil_Tegar
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach (var mhs in data)
            {
                Console.WriteLine("NIM : " + mhs.nim+" | Nama : "+mhs.nama+" | Prodi : "+mhs.prodi+" | Angkatan : "+mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}
