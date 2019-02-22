using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserRegSytem
{
    class Class1
    {
        string name;
        public string Name { get => name; set => name = value; }
        string password;
        public string Password { get => password; set => password = value; }
        int age;
        public int Age { get => age; set => age = value; }
        string ageRange;
        public string AgeRange { get => ageRange; set => ageRange = value; }
        string[] genre = new string[3];
        public string[] Genre { get => genre; set => genre = value; }
        string sex;
        public string Sex { get => sex; set => sex = value; }
        string phoneNumber;
        public string Phone { get => phoneNumber; set => phoneNumber = value; }
        string picturepath;
        public string Picturepath { get => picturepath; set => picturepath = value; }
        public Class1()
        {

        }
        public Class1(string n, string p, int a, string s, string phone, string pix, string ar, string[] g)
        {
            name = n;
            password = p;
            age = a;
            sex = s;
            phoneNumber = Phone;
            picturepath = pix;
            AgeRange = ar;
            genre = g;
        }
        public void saveData()
        {
            using (StreamWriter sw = File.AppendText("UserData.csv"))
            {
                string eachItem = "";
                foreach (var item in genre)
                {
                    eachItem += "-" + eachItem;
                }
                sw.WriteLine(name + "," + password + "," + age + "," + Sex + "," + phoneNumber + "," + picturepath + "," + eachItem);

            }


        }


    }
}
