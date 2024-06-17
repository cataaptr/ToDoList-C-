using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListProject
{
    public class Category
    {
    
        public int id { get; set; }
        public string CategoryName { get; set; }=string.Empty;

        public Category()
        {
        }

        public Category(int id, string categoryName)
        {
            this.id = id;
            this.CategoryName = categoryName;
        }

        public Category(Category other)
        {
            this.id = other.id;
            this.CategoryName = other.CategoryName;
        }

    }
}
