using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
   public class ClassManagenment
    {
       public Class[] GetClasses()
       {
           var db = new OOPCS2Entities();
          return db.Classes.ToArray();
       }
       public void AddClass(string name, string Description)
       {
           var newclass = new Class();
           newclass.Name = name;
           newclass.Description = Description;
           var db = new OOPCS2Entities();
           db.Classes.Add(newclass);
           db.SaveChanges();
       }
       public void EditClass(int id, string name, string Description)
       {
           var db = new OOPCS2Entities();
           var oldclass = db.Classes.Find(id);

           oldclass.Name = name;
           oldclass.Description = Description;
           db.Entry(oldclass).State = System.Data.Entity.EntityState.Modified;
           db.SaveChanges();
       }
       public void DeleteClass(int id)
       {
           var db = new OOPCS2Entities();
           var @class = db.Classes.Find(id);
           db.Classes.Remove(@class);
           db.SaveChanges();


       }
       public Class GetClass(int id)
       {
           var db = new OOPCS2Entities();
           return db.Classes.Find(id);
       }
    }
}
