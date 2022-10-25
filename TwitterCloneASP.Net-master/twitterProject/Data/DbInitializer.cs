using twitterProject.Models;
using System;
using System.Linq;

namespace twitterProject.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TwitterContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            //Add users on the time of DB creation
            var users = new User[]
            {
            new User{FirstName="Jeetu",LastName="kumar", Email="jeetu@gmail.com", ImageUrl="https://avatars.githubusercontent.com/u/56978370?v=4", Password="12345",},
           
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

        }
    }
}