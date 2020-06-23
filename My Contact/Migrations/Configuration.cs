namespace My_Contact.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using My_Contact.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<My_Contact.DAL.MyContactContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(My_Contact.DAL.MyContactContext context)
        {
            var contacts = new List<Contact>
            {
                new Contact { FirstName = "Krzysztof", LastName = "Jarzyna", Address = "Kwiatkowskiego 11 39-300 Mielec", Email = "kjarzyna@gmail.com", Company = "Krzys", Phone = "456 456 456" },
                new Contact { FirstName = "Jan", LastName = "Kowalski", Address = "Kwiatowa 18 39-300 Mielec", Email = "j.kowalski@interia.eu", Company = "Motorola", Phone = "798 256 143" },
                new Contact { FirstName = "Ewelina", LastName = "Nowakowska", Address = "Kopernika 25/18 35-025 Rzeszów", Email = "eveline56@poczta.onet.pl", Company = "Eveline", Phone = "882 357 949" },
                new Contact { FirstName = "Marek", LastName = "Pieróg", Address = "Solskiego 11/120 30-021 Kraków", Email = "w99126@student.wsiz.rzeszow.pl", Company = "WSIZ", Phone = "596 321 005" },
                new Contact { FirstName = "Adam", LastName = "Nowak", Address = "Grunwaldzka 2A/5 30-021 Kraków", Email = "nowak.adam@gmail.com", Company = "Nowak i spółka", Phone = "821 523 696" },
                new Contact { FirstName = "Anna", LastName = "Jaworska", Address = "Niepodległości 11/62 39-300 Mielec", Email = "a.j.96@gmail.com", Company = "Grand Parade", Phone = "564 011 256" },
                new Contact { FirstName = "Natalia", LastName = "Tabor", Address = "Sosnowa 15 39-300 Mielec", Email = "natab81@interia.eu", Company = "Ericsson", Phone = "528 630 751" },
                new Contact { FirstName = "Karolina", LastName = "Kawa", Address = "Ossolińskiego 11/98 39-300 Mielec", Email = "kawka12@poczta.onet.pl", Company = "CompSoft", Phone = "776 521 867" },
                new Contact { FirstName = "Jakub", LastName = "Parys", Address = "Sucharskiego 28/63 35-025 Rzeszów", Email = "j.parys@interia.pl", Company = "Onwelo", Phone = "642 125 224" },
                new Contact { FirstName = "Kinga", LastName = "Hamala", Address = "Obrońców Westerplatte 9 30-021 Kraków", Email = "kinia91@op.pl", Company = "UBS", Phone = "897 531 624" },
                new Contact { FirstName = "Adrian", LastName = "Małysz", Address = "Krzywa 10/1 30-021 Kraków", Email = "a.malysz@poczta.onet.pl", Company = "Revolut", Phone = "885 900 240" },
                new Contact { FirstName = "Robert", LastName = "Gawlik", Address = "Kurzei 13 30-021 Kraków", Email = "rob_gawlik@interia.eu", Company = "Ideo", Phone = "17 25 68 542" },
                new Contact { FirstName = "Grzegorz", LastName = "Urban", Address = "Korczaka 2/25 39-300 Mielec", Email = "grzegorz256@gmail.com", Company = "Shell", Phone = "956 881 563" },
                new Contact { FirstName = "Weronika", LastName = "Sosna", Address = "Sportowa 8 35-025 Rzeszów", Email = "sosna_weronika@gamil.com", Company = "Technojobs", Phone = "664 895 236" },
                new Contact { FirstName = "Paulina", LastName = "Kowal", Address = "Lachnita 21/18 35-025 Rzeszów", Email = "w84271@student.wsiz.rzeszow.pl", Company = "Elastic", Phone = "821 520 110" },
                new Contact { FirstName = "Norbert", LastName = "Zuch", Address = "Wróblewskiego 6 39-300 Mielec", Email = "norbi661@poczta.onet.pl", Company = "C+N", Phone = "569 128 333" },
                new Contact { FirstName = "Joanna", LastName = "Zatorska", Address = "Piramowicza 20/83 39-300 Mielec", Email = "j.zatorska@op.pl", Company = "ZHR", Phone = "984 625 894" },
                new Contact { FirstName = "Daria", LastName = "Polak", Address = "Skarżyńskiego 3 39-300 Mielec", Email = "daria_polak@interia.eu", Company = "Polak Photography", Phone = "842 535 264" },
                new Contact { FirstName = "Marian", LastName = "Kołodziej", Address = "Wojska Polskiego 7/11 39-300 Mielec", Email = "marian55@interia.eu", Company = "Bank Spółdzielczy Mielec", Phone = "861 243 792" }
            };

            contacts.ForEach(c => context.Contacts.AddOrUpdate(p => p.LastName, c));
            context.SaveChanges();
        }
    }
}
