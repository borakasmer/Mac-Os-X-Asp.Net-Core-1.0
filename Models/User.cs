using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    public enum Hobi  
    {
        Music=1,        
        Picture=2,
        Sport=3,
        Game=4
    }
    public class User
    {
        public User()
        {            
                   
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public  Hobi Interested { get; set; }
    }
}        