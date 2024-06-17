using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ToDoListProject.DataAccess;

namespace  ToDoListProject
{
    [Serializable]
    //am pus public ptc XmlSerializer necesita ca toate tipurile implicate în serializare sa fie publice
    public class  Task
    {

        public string Description { get; set; }=string.Empty;

        public Category Category { get; set; }
        public DateTime StartDate { get; set; }=DateTime.Now;
        public DateTime EndDate { get; set; }= DateTime.Today.AddDays(1);   //make it expire tomorror by default

        public bool Done { get; set; } = false;

        public Task()
        {

        }
        public Task(Category category,string description = "no_description", DateTime startDate = new DateTime(), DateTime endDate = new DateTime(), bool done = false)
        {
            if(description.Length>2)
                this.Description = description;
           this.Category = category;
            this.StartDate = startDate;
            if(endDate>DateTime.Now)
                this.EndDate = endDate;
            if(done==true || done==false)
                this.Done = done;
        }
        public Task(Task t)
        {
            if (t.Description.Length > 2)
                this.Description = t.Description;
            this.Category = t.Category;
            this.StartDate = t.StartDate;
            if (t.EndDate > DateTime.Now)
                this.EndDate = EndDate;
            if (t.Done == true || t.Done == false)
                this.Done = t.Done;
        }

        


    }
}
