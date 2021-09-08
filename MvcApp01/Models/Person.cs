using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp01.Models
{
    
    public class Person
    {
        public int Id { get; set; }
        public string PName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
/*POCO Class
 Plain Old CLR Objects: The class containing all public properties will be called as POCO classes

The object of this class can host record from a database table

 */