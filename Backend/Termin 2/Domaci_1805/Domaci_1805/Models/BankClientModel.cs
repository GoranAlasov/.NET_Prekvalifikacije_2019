using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domaci_1805.Models
{
    public class BankClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public char Bonitet { get; set; }
        public string City { get; set; }

        public BankClientModel()
        {

        }

        public BankClientModel(int id, string name, string surname, string email, DateTime dob, char bonitet )
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Dob = dob;
            Bonitet = bonitet;
        }

        public BankClientModel(int id, string name, string surname, string email, DateTime dob, string city)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Dob = dob;
            City = city;
        }
    }
}