namespace KiksApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<KiksApp.Data.KiksAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(KiksApp.Data.KiksAppDbContext context)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
