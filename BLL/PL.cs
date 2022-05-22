using System;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PLController : ApiController
    {
        private Process bll = new Process();

        [HttpGet]
        public String GET(String action, String name)
        {
            String response;
            switch (action)
            {
                case "Season":
                    response = JsonConvert.SerializeObject(this.bll.GetSeasonDishes());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"GET request: /PL/Season - response 200");
                    Console.ForegroundColor = ConsoleColor.White;
                    return response;
                case "Type":
                    response = JsonConvert.SerializeObject(this.bll.GetTypeDishes());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"GET request: /PL/Type - response 200");
                    Console.ForegroundColor = ConsoleColor.White;
                    return response;
                case "Exist":
                    response = bll.Exists(name);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"GET request: /PL/Exist - response 200");
                    Console.ForegroundColor = ConsoleColor.White;
                    return response;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"GET request: /PL/{action} - response 400");
            Console.ForegroundColor = ConsoleColor.White;
            return "Bad request";
        }

        [HttpPost]
        public String POST([FromBody] Dish[] Data)
        {
            var response = bll.CreateOrder(JsonConvert.SerializeObject(Data));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"POST request: /PL/{response} - response 200");
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }

        [HttpPut]
        public String PUT([FromBody] Dish Data)
        {
            var response = bll.Order(Data.Name, Data.OrderId);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"PUT request: /PL/{response} - response 200");
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }

        [HttpDelete]
        public String DELETE([FromBody] Dish[] Data)
        {
            var response = bll.RemoveOrder(JsonConvert.SerializeObject(Data));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"DELETE request: /PL/{response} - response 200");
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }
    }
}
