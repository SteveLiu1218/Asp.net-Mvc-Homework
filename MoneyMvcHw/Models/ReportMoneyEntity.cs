namespace MoneyMvcHw
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MoneyMvcHw.Models.ViewModel;

    public partial class ReportMoneyEntity : DbContext
    {
        public ReportMoneyEntity()
            : base("name=ReportMoneyEntity")
        {
        }

        public virtual DbSet<AccountBook> AccountBook { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        } 
    }
}
