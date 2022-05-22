using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    class Process
    {
        private UOW DAL = new UOW(true);

        public String GetSeasonDishes()
        {
            return JsonConvert.SerializeObject(this.DAL.GetSeasonDishes());
        }

        public String GetTypeDishes()
        {
            return JsonConvert.SerializeObject(this.DAL.GetTypeDishes());
        }

        public String Exists(String name)
        {
            return this.DAL.Exists(name).ToString();
        }

        public String Order(String name, int orderid)
        {
            return this.DAL.Order(name, orderid).ToString();
        }

        public String CreateOrder(String order)
        {
            Dictionary<String, String>[] d = JsonConvert.DeserializeObject<Dictionary<String, String>[]>(order);
            List<Dictionary<String, String>> d2 = new List<Dictionary<string, string>>();
            foreach (var i in d)
                d2.Add(this.DAL.CreateOrder(i));
            return JsonConvert.SerializeObject(d2);
        }

        public String RemoveOrder(String order)
        {
            Dictionary<String, String>[] d = JsonConvert.DeserializeObject<Dictionary<String, String>[]>(order);
            foreach (var i in d)
                this.DAL.DeleteOrder(i);
            return true.ToString();
        }
    }
}
