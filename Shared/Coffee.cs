using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePicker.Shared
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Ingredients { get; set; }

        public Coffee() {}

        public Coffee(int Id, string Title, string Description, string[] Ingredients)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Ingredients = Ingredients;
        }
    }
}
