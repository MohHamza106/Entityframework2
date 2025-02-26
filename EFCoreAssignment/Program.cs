using EFCoreAssignment.Contexts;
using EFCoreAssignment.Entities;

namespace EFCoreAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            using (DBContext db = new DBContext()) {

                // ------------insert , create-----------------


                //Student student = new Student() { FName = "mohamed", Age = 5 };
                //db.Students.Add(student);
                //Console.WriteLine(db.Entry(student).State);
                //db.SaveChanges();

                // ------------retreive-----------------

                //var result = db.Students.Where(student => student.Id == 50).FirstOrDefault();
                //Console.WriteLine(result);


                // ------------update-----------------
                //result.Address = "Alex";
                //Console.WriteLine(db.Entry(result).State);
                //db.SaveChanges();

                // ------------delete-----------------

                //db.Students.Remove(result);
                //Console.WriteLine(db.Entry(result).State);
                //db.SaveChanges();



            }
        }
    }
}
