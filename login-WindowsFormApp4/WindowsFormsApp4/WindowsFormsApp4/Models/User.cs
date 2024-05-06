using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Models
{
    public class User //created User Class
    {
        public User(string _username, string _password) //created constructor
        {
            username = _username; //bu yapıcı _username ve _password alarak User Class'ının özellekilerine(username,password) atar.
            password = _password;   
        }

        //burada ise username ve password adında iki property tanımlanmıştır.Bunlar sınıfın içinde saklanan kullanıcı adı ve parola bilgilerini temsil ederler. Hem okunabilir (get),hem de yazılabilir (set) özelliklere sahiptir.
        public string username { get; set; } 
        public string password { get; set; }
    }
}
