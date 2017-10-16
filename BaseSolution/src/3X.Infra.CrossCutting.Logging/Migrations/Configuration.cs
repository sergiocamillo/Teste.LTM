using System.Data.Entity.Migrations;
using X.Infra.CrossCutting.Logging.Data;

namespace X.Infra.CrossCutting.Logging.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LogginContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LogginContext context)
        {

        }
    }
}
