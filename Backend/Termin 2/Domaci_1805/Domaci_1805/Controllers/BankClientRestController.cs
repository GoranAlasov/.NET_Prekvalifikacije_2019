using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using Domaci_1805.Models;

namespace Domaci_1805.Controllers
{
    [RoutePrefix("api/clients")]
    public class BankClientRestController : ApiController
    {
        // GET: api/clients
        [Route("")]
        public IEnumerable<BankClientModel> GetAll()
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));
            return clients;
        }

        /*1.1 endpoint koji iz liste klijenata banke uzima samo email adrese svih klijenata i vraća listu email adresa
        putanja /api/clients/emails*/

        // GET: api/clients/emails
        [Route("emails")]
        public List<string> GetEmails()
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));

            List<string> emails = new List<string>();

            foreach (var item in clients)
            {
                emails.Add(item.Email);
            }

            return emails;
        }

        /* 1.2 endpoint koji vraća listu koja sadrži imena klijenata, čije ime počinje na slovo koje je prosleđeno kao parametar
        putanja /api/clients/{firstLetter}*/

        [Route("{letter:alpha}")]
        public List<string> GetNamesByFirstLetter(char letter)
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));
            clients.Add(new BankClientModel(5, "Marko", "Kraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Backa Palanka"));

            List<string> firstNames = new List<string>();

            foreach (var item in clients)
            {
                if (char.ToLower(letter) == char.ToLower(item.Name[0]))
                {
                    firstNames.Add(item.Name);
                }
            }

            return firstNames;
        }

        /*1.3 endpoint koji vraća listu koja sadrži imena i prezimena klijenata,čije ime počinje na slovo koje je prosleđeno kao parametar i 
          čije prezime počinje na slovo koje je prosleđeno kao parametar
          putanja /api/clients/firstLetters*/

        [Route("{initials:length(2)}")]
        public List<string> GetNameSurnameByInitials(string initials)
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));
            clients.Add(new BankClientModel(5, "Marko", "Kraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Backa Palanka"));
            clients.Add(new BankClientModel(6, "Marko", "Krrrraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Nis"));

            List<string> retVal = new List<string>();
            char nameInitial = initials[0];
            char surnameInitial = initials[1];

            foreach (var item in clients)
            {
                if (char.ToLower(nameInitial) == char.ToLower(item.Name[0]) && char.ToLower(surnameInitial) == char.ToLower(item.Surname[0]))
                {
                    retVal.Add(item.Name + " " + item.Surname);
                }
            }

            return retVal;
        }

        /*1.4 endpoint koji vraća listu koja sadrži imena klijenata, koja su
        sortirana u redosledu koji je prosleđen kao parameter
        putanja /api/clients/sort/{order}*/

        [Route("sort/{order:regex(^(ascending|descending)$)}")]
        public List<string> GetNamesOrdered(string order)
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));
            clients.Add(new BankClientModel(5, "Marko", "Kraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Backa Palanka"));
            clients.Add(new BankClientModel(6, "Marko", "Krrrraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Nis"));

            if (order == "ascending")
            {
                List<string> retVal = clients.OrderBy(x => x.Name).Select(x => x.Name).ToList();
                return retVal;
            }
            else if (order == "descending")
            {
                List<string> retVal = clients.OrderByDescending(x => x.Name).Select(x => x.Name).ToList();
                return retVal;
            }

            return null;
        }

        /*2.1 endpoint koji u listi klijenata banke, svakom klijentu, postavlja
        polje bonitet na ‘P’ (pozitivan) ako je klijent mlađi od 65 godina ili
        ‘N’ negativan ako je klijent stariji od 65 godina
        • putanja /api/clients/bonitet
        • u klasu BankClientModel dodati atribute datum rođenja i bonitet - napravio sam novu klasu i kontroler*/

        // PUT: api/clients/bonitet
        [Route("bonitet")]
        [HttpPut]
        public void SetBonitet()
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));

            foreach (var item in clients)
            {
                TimeSpan age = DateTime.Now.Subtract(item.Dob);

                if (age.TotalDays / 365 < 65)
                {
                    item.Bonitet = 'P';
                }
                else if (age.TotalDays / 365 > 65)
                {
                    item.Bonitet = 'N';
                }
            }
        }

        /*2.2 endpoint koji briše klijenta iz liste klijenta ukoliko klijent nema
        jednu od vrednosti: ime, prezime, email
        • putanja /api/clients/delete*/

        //DELETE: api/clients/delete
        [Route("delete")]
        public void DeleteWithNulls()
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", null, new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, null, "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", null, "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));

            clients.RemoveAll(x => x.Name == null || x.Surname == null || x.Email == null);
        }

        /*2.3 endpoint koji vraća ukupan broj klijenata u listi klijenata koji
        imaju manje od broja godina koje je prosleđeno kao parametar
        • putanja /clients/countLess/{years}*/

        //GET: /api/clients/countLess/43
        [Route("countLess/{age:int}")]
        [HttpGet]
        public int CountYoungerThan(int age)
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));
            clients.Add(new BankClientModel(5, "Marko", "Kraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Backa Palanka"));
            clients.Add(new BankClientModel(6, "Marko", "Krrrraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Nis"));

            int retVal = 0;

            foreach (var item in clients)
            {
                double thisAge = DateTime.Now.Subtract(item.Dob).TotalDays / 365;

                if (thisAge < age)
                {
                    retVal++;
                }
            }

            return retVal;
        }
        
        /*2.4 endpoint koji prosečan broj godina klijenata iz liste klijenata
        • putanja /api/clients/averageYears*/

        //GET: /api/clients/averageYears
        [Route("averageYears")]
        public double GetAvgAge()
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));
            clients.Add(new BankClientModel(5, "Marko", "Kraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Backa Palanka"));
            clients.Add(new BankClientModel(6, "Marko", "Krrrraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Nis"));

            double sumAgeInDays = 0;
            int count = 0;
            double avgAge = 0;

            foreach (var item in clients)
            {
                if (item.Dob != null)
                {
                    sumAgeInDays += DateTime.Now.Subtract(item.Dob).TotalDays;
                    count++;
                }
            }

            avgAge = (sumAgeInDays / count) / 365;
            return Math.Round(avgAge, 2);
        }

        /*3.1 endpoint koji omogućuje izmenu mesta stanovanja klijenta
        • putanja /api/clients/changelocation/{clientId}
        • u klasu BankClientBean dodati atribut grad
        • novu vrednost mesta stanovanja proslediti kao FromUri*/

        //PUT /api/clients/changelocation/5?city=beograd
        [Route("changelocation/{id}")]
        public void PutLocation(int id, [FromUri]string city)
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Subotica"));
            clients.Add(new BankClientModel(5, "Marko", "Kraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Backa Palanka"));
            clients.Add(new BankClientModel(6, "Marko", "Krrrraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Nis"));

            int index = clients.FindIndex(x => x.Id == id);

            clients[index].City = city;
        }

        /*3.2 endpoint koji vraća klijente banke koji žive u gradu koji je
        prosleđen kao parametar
        • putanja /api/clients/from/{city}*/

        //GET /api/clients/from/beograd
        [Route("from/{city}")]
        public List<BankClientModel> GetClientsByCity(string city)
        {
            List<BankClientModel> clients = new List<BankClientModel>();
            clients.Add(new BankClientModel(1, "Goran", "Alasov", "alasov@gmail.com", new DateTime(1983, 12, 21), "Novi Sad"));
            clients.Add(new BankClientModel(2, "Petar", "Petrovic", "petrovic@gmail.com", new DateTime(1977, 8, 3), "Beograd"));
            clients.Add(new BankClientModel(3, "Mitar", "Miric", "mitar@gmail.com", new DateTime(1951, 7, 14), "Kragujevac"));
            clients.Add(new BankClientModel(4, "Svetlana", "Raznjatovic", "srpska.majka@gmail.com", new DateTime(1969, 11, 15), "Kragujevac"));
            clients.Add(new BankClientModel(5, "Marko", "Kraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Backa Palanka"));
            clients.Add(new BankClientModel(6, "Marko", "Krrrraljevic", "junak.srpski@gmail.com", new DateTime(1988, 9, 5), "Novi Sad"));
                        
            return clients.FindAll(x => x.City.ToLower() == city.ToLower());
        }

        /*endpoint koji proverava validnost stringa prosledjene email adrese. Delimican izvor: https://en.m.wikipedia.org/wiki/Email_address */

        //GET /coki/check_email/
        [Route("~/coki/check_email")]
        public bool GetCheckEmailVaild([FromUri] string email)
        {
            if (!email.Contains("@"))
            {
                return false;
            }
            else
            {
                if (email.IndexOf('@') == 0 || email.IndexOf('@') == email[email.Length - 1] || email.Count(x => x == '@') > 1)
                {
                    return false;
                }
                else
                {
                    int indexOfAt = email.IndexOf('@');
                    string local = email.Substring(0, indexOfAt);
                    string domain = email.Substring(indexOfAt + 1, email.Length - (indexOfAt + 1));

                    if (local.Length > 64 || domain.Length > 255)
                    {
                        return false;
                    }
                    else
                    {
                        Regex domainRule = new Regex(@"^[a-zA-Z0-9-.]*$");
                        Regex localRule = new Regex(@"^[a-zA-Z0-9!#$%&'*+-/=?^_`{|}~.]*$");

                        if (domainRule.IsMatch(domain))
                        {
                            if (domain[0] == '-' || domain[domain.Length - 1] == '-')
                            {
                                return false;
                            }
                            else
                            {
                                if (localRule.IsMatch(local))
                                {
                                    if (local[0] == '.' || local[local.Length - 1] == '.')
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        for (int i = 0; i < local.Length - 2; i++)
                                        {
                                            if (local[i] == '.' && local[i + 1] == '.')
                                            {
                                                return false;
                                            }
                                            else
                                            {
                                                return true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        return false;
                    }
                }
            }
        }
    }
}

