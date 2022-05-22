using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Dish
    {
        public int Id;
        public String Name;
        public int OrderId;

        public String toString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
