using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Models
{
    internal class AlapAdatok
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Korosztaly { get; set; }
        public string Poszt { get; set; }

        public AlapAdatok(string firstname, string lastname, DateTime birthdate, string korosztaly, string poszt)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Korosztaly = korosztaly;
            Poszt = poszt;
        }
        public AlapAdatok()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDate = new DateTime();
            Korosztaly = string.Empty;
            Poszt = string.Empty;
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Korosztaly} {Poszt} -({String.Format("{0:yyyy.MM.dd.}", BirthDate)})";
        }
    }
}
