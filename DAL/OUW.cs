using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UOW
    {
        private Repository<Dish> Dishes;
        private Repository<SeasonDish> SeasonDishes;
        private Repository<TypeDish> TypeDishes;

        public UOW(bool newDB)
        {
            Dishes = new Repository<Dish>(newDB);
            SeasonDishes = new Repository<SeasonDish>(newDB);
            TypeDishes = new Repository<TypeDish>(newDB);
            if (newDB)
            {
                this.Init();
            }
        }

        private void Init()
        {
            this.Dishes.InsertDish(new Dish() { DishId = 1, Name = "Burger", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 2, Name = "Pancake", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 3, Name = "Tea", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 4, Name = "Pasta", OrderId = 0 });
            this.Dishes.InsertDish(new Dish() { DishId = 5, Name = "Teftel", OrderId = 0 });

            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 0, Name = "Burger", Price = 35, Details = "Beef and daycon", Season = "Lunch", Image = "https://images.unsplash.com/photo-1550547660-d9450f859349?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 1, Name = "Pancake", Price = 25, Details = "Maple syrop", Season = "Breakfest", Image = "https://images.unsplash.com/photo-1554520735-0a6b8b6ce8b7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 2, Name = "Tea", Price = 10, Details = "Lime and ice", Season = "Lunch", Image = "https://images.unsplash.com/photo-1556679343-c7306c1976bc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 3, Name = "Pasta", Price = 25, Details = "Basil & parmezan", Season = "Dinner", Image = "https://images.unsplash.com/photo-1531089073319-17596b946d42?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 4, Name = "Teftel", Price = 45, Details = "Tomato & cheese", Season = "Lunch", Image = "https://images.unsplash.com/photo-1515516969-d4008cc6241a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 5, Name = "Cruasan", Price = 15, Details = "Avocado & tomato", Season = "Lunch", Image = "https://images.unsplash.com/photo-1603046891744-1f76eb10aec7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTZ8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 6, Name = "Potato", Price = 30, Details = "Mayoran & butter", Season = "Dinner", Image = "https://images.unsplash.com/photo-1552845683-cfefc701e423?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MzF8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 7, Name = "Cock", Price = 25, Details = "Rosemary", Season = "Dinner", Image = "https://images.unsplash.com/photo-1592483648228-b35146a4330c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NDV8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 8, Name = "Ramen", Price = 55, Details = "Egg an beef", Season = "Dinner", Image = "https://images.unsplash.com/photo-1552611052-33e04de081de?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NTd8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 9, Name = "Cookies", Price = 15, Details = "Chocolate", Season = "Breakfest", Image = "https://images.unsplash.com/photo-1558961363-fa8fdf82db35?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NjB8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.SeasonDishes.InsertDish(new SeasonDish() { DishId = 10, Name = "Tortilla", Price = 20, Details = "Avocado & corn", Season = "Breakfest", Image = "https://images.unsplash.com/photo-1588556008426-af415581d44b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NzR8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });

            this.TypeDishes.InsertDish(new TypeDish() { DishId = 0, Name = "Burger", Price = 35, Details = "Beef and daycon", Type = "Second", Image = "https://images.unsplash.com/photo-1550547660-d9450f859349?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 1, Name = "Pancake", Price = 25, Details = "Maple syrop", Type = "Desert", Image = "https://images.unsplash.com/photo-1554520735-0a6b8b6ce8b7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 2, Name = "Tea", Price = 10, Details = "Lime and ice", Type = "Desert", Image = "https://images.unsplash.com/photo-1556679343-c7306c1976bc?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 3, Name = "Pasta", Price = 25, Details = "Basil & parmezan", Type = "Second", Image = "https://images.unsplash.com/photo-1531089073319-17596b946d42?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8Zm9vZCUyMHBob3RvZ3JhcGh5fGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 4, Name = "Teftel", Price = 45, Details = "Tomato & cheese", Type = "Second", Image = "https://images.unsplash.com/photo-1515516969-d4008cc6241a?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTB8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 5, Name = "Cruasan", Price = 15, Details = "Avocado & tomato", Type = "Desert", Image = "https://images.unsplash.com/photo-1603046891744-1f76eb10aec7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTZ8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 6, Name = "Potato", Price = 30, Details = "Mayoran & butter", Type = "Second", Image = "https://images.unsplash.com/photo-1552845683-cfefc701e423?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MzF8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 7, Name = "Cock", Price = 25, Details = "Rosemary", Type = "Desert", Image = "https://images.unsplash.com/photo-1592483648228-b35146a4330c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NDV8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 8, Name = "Ramen", Price = 55, Details = "Egg an beef", Type = "First", Image = "https://images.unsplash.com/photo-1552611052-33e04de081de?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NTd8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 9, Name = "Cookies", Price = 15, Details = "Chocolate", Type = "Desert", Image = "https://images.unsplash.com/photo-1558961363-fa8fdf82db35?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NjB8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });
            this.TypeDishes.InsertDish(new TypeDish() { DishId = 10, Name = "Tortilla", Price = 20, Details = "Avocado & corn", Type = "Second", Image = "https://images.unsplash.com/photo-1588556008426-af415581d44b?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NzR8fGZvb2QlMjBwaG90b2dyYXBoeXxlbnwwfHwwfHw%3D&auto=format&fit=crop&w=500&q=60" });

        }

        /// <summary>
        /// C-create
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public Dictionary<String, String> CreateOrder(Dictionary<String, String> order)
        {
            var d = new Dish();
            d.Restore(order);
            d.DishId = this.getNextId();
            this.Dishes.InsertDish(d);
            return d.Mapping();
        }
        /// <summary>
        /// R-read
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, String>[] GetSeasonDishes()
        {
            var dict = new List<Dictionary<String, String>>();
            foreach (var i in this.SeasonDishes.GetAll())
            {
                dict.Add(i.Mapping());
            }
            return dict.ToArray();
        }

        public Dictionary<String, String>[] GetTypeDishes()
        {
            var dict = new List<Dictionary<String, String>>();
            foreach (var i in this.TypeDishes.GetAll())
            {
                dict.Add(i.Mapping());
            }
            return dict.ToArray();
        }

        public bool Exists(String name)
        {
            foreach (var i in this.Dishes.GetAll())
            {
                if (i.Name == name)
                    if (i.OrderId == 0)
                        return true;
                    else
                        return false;
            }
            return false;
        }

        /// <summary>
        /// U-update
        /// </summary>
        /// <param name="name"></param>
        /// <param name="orderid"></param>
        /// <returns></returns>
        public bool Order(String name, int orderid)
        {
            foreach (var i in this.Dishes.GetAll())
            {
                if (i.Name == name && i.OrderId == 0)
                {
                    var d = i;
                    d.OrderId = orderid;
                    this.Dishes.UpdateDish(d);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// D-delete
        /// </summary>
        /// <param name="order"></param>
        public void DeleteOrder(Dictionary<String, String> order)
        {
            var d = new Dish();
            d.Restore(order);
            this.Dishes.DeleteDish(d);
        }

        private int getNextId()
        {
            var j = 0;
            foreach (var i in this.Dishes.GetAll())
                j = i.DishId;
            return j + 1;
        }
    }
}
