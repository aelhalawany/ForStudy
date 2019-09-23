using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DBFirstContext())
            {
                var user = new User()
                {
                    UserId = Guid.NewGuid(),
                    Name = "Bill",
                    UserName= "Gates",
                    Password="1234550",
                    Mobile="23434343"
                };
                // add new item
                //context.Users.Add(user);

                // update existing item
                var updateduser = context.Users.Where(x => x.UserId == new Guid("27f3d56d-bad1-4345-aa3e-5bc56861f08f")).FirstOrDefault();
                updateduser.UserName = "updatedUsername";

                // delete item
                var deleteduser = context.Users.Find(new Guid("7827225c-9c01-4fc0-9f07-f2277b41a0ae"));
                if(deleteduser!=null)
                    context.Users.Remove(deleteduser);

                context.SaveChanges();


                // querying
                var x0 = from selecteduser in context.Users
                                    where selecteduser.UserId == new Guid("00914022-4633-40cd-8d2f-ed8aa4c255b6")
                                    select selecteduser;
                Console.WriteLine(x0.FirstOrDefault()?.Name);

                var x1 = context.Users.ToList();
                foreach (var item in x1)
                {
                    Console.WriteLine(item.Name+"\n");
                }

                var x2 = context.Users.SqlQuery("Select * from [User] where UserId=@Id", new SqlParameter("@Id", new Guid("37ba6640-0155-4f20-ae90-d35bd84edb53"))).FirstOrDefault();
                Console.WriteLine(x2.Name + "\n");

                Console.ReadLine();
            }
        }
    }
}
