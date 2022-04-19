using System.Data.Entity.Migrations;

namespace ToDoList.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.ToDoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
