using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentGrades.Models
{
    public static class Repository
    {
        public static List<Person> people= new List<Person>() 
        { 
            new Person(){Id=1,FirstName="Amin",LastName="Noruzi",NationalCode=123456789 },
            new Person(){Id=2,FirstName="Ali",LastName="Hassani",NationalCode=987654321 },
            new Person(){Id=3,FirstName="Ali",LastName="Abasi",NationalCode=951236748 },
        };

    }
}