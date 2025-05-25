using EcommerseWebApi.Model.Table;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EcommerseWebApi
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
    : base(options)
        {

        }

       public DbSet<ProductCategory> ProductCategories { get; set; }

       public DbSet<Product> Products{ get; set; }

        public DbSet<CommMessage> commMessages { get; set; }

        public DbSet<SpecificationType> SpecificationTypes { get; set; }

        public DbSet<ProductSpeficationTypeSpecification> ProductSpeficationTypeSpecifications { get; set; }

        public DbSet<Specification> Specifications { get; set; }

        public DbSet<ProductSpeficationType> ProductSpeficationTypes { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }

    }
}
