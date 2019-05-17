using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;


namespace Vezba1.Controllers
{
    public class ValuesController : ApiController
    {
        string[] grupa = new string[] { "Ime1 Prezime1", "Ime2 Prezime2", "Ime3 Prezime3" };
        int[] numbers = new int[] { 1, 34, 65, 3, 7, 85436, 34, 6, 8, -1, 3654 };
                
        //GET: util/date
        [Route("util/date")]
        [HttpGet]
        public string DateAndTime()
        {
            return DateTime.Now.ToString();
        }

        //GET: util/family
        [HttpGet]
        [Route("util/family")]
        public IEnumerable<string> FamilyMembers()
        {
            return new string[] { "Goran", "Milica", "Lazar", "Dusan" };
        }
        
        //GET util/myclass
        [HttpGet]
        [Route("util/myclass")]
        public HttpResponseMessage Grupa()
        {
            var response = new HttpResponseMessage();
            StringBuilder sb = new StringBuilder("<html><body><table><tr><th>Ime</th><th>Prezime</th></tr>");

            foreach (string nameSurname in grupa)
            {
                string[] thisPerson = nameSurname.Split(' ');
                
                sb.Append($"<tr><td>{thisPerson[0]}</td><td>{thisPerson[1]}</td></tr>");                
            }

            sb.Append("</table></body></html>");
                        
            response.Content = new StringContent(sb.ToString());
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
        
        //GET math/array
        [HttpGet]
        [Route("math/array")]
        public int[] myArray()
        {
            return numbers;
        }

        //GET math/sortarray
        [HttpGet]
        [Route("math/sortarray")]
        public int[] SortedArray()
        {
            int[] retVal = numbers;
            Array.Sort(retVal);
            return retVal;            
        }
        
        [HttpGet]
        [Route("math/minmax")]
        public Dictionary<string, int> GetMinMax()
        {
            int min = numbers.Min();
            int max = numbers.Max();

            Dictionary<string, int> retVal = new Dictionary<string, int>();

            retVal.Add("minimum", min);
            retVal.Add("maximum", max);

            return retVal;            
        }
    }
}
