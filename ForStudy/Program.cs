using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("xxx".StringCount(6));
            //Child_1 x = new Child_1();
            //x.cal();
            //Child xy = new Child();
            //xy.Create
            // Data source.
            //Person p = new Person("Mandy", "Dejesus");
            ////Console.WriteLine(p.MakeSum());
            //Console.WriteLine($"My Name is {nameof(p.Sum)}");


           
            ////GetAuthor(out string authorName, out string bookTitle, out long publishedYear);
            ////Console.WriteLine("Author: {0}, Book: {1}, Year: {2}",
            ////authorName, bookTitle, publishedYear);
            ////Console.ReadKey();

            //Console.ReadLine();


            // Entity Framework
            using (var context = new ForStudyEntities())
            {
                //for (int i = 1; i <= 5; i++)
                //{
                //    var usr = new User()
                //    {
                //        UserName = "UserName"+i,
                //        Mobile = "0100000"+i,
                //        Name = "Name"+i,
                //        Password = "123",
                //        UserId = Guid.NewGuid()
                //    };
                //    context.Users.Add(usr);
                //}

                //var existinguser = context.Users.First<User>();
                //existinguser.UserId = Guid.NewGuid();
                //existinguser.Name = "New NAme";
                //context.Users.Remove(existinguser);
                //context.SaveChanges();

                var users1 = context.Users.Where(s => s.Name == "Mohamed ALi").FirstOrDefault<User>();
                var users2 = from usr in context.Users
                             where usr.UserName == "UserName5"
                             select usr;
                var users3 = context.Users.Find(new Guid("00914022-4633-40cd-8d2f-ed8aa4c255b6"));
                var Users4 = context.Users.Include("Address");
                //var user5 = from usr in Users4
                //            where usr.UserId == new Guid("00914022-4633-40cd-8d2f-ed8aa4c255b6")
                //            select usr;
                //foreach (var item in user5.FirstOrDefault<User>())
                //{
                //    Console.WriteLine(item.FullAddress);
                //}
                
            }
            Console.ReadLine();
        }

        static void GetAuthor(out string name, out string title, out long year)
        {
            name = "Mahesh Chand";
            title = "A Programmer's Guide to ADO.NET with C#";
            year = 2001;
        }
    }
}
