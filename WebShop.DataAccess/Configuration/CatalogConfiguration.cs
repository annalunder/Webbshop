using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebShop.DataAccess.Configuration
{
    public class CatalogConfiguration : IEntityTypeConfiguration<Catalog>
    {
        public void Configure(EntityTypeBuilder<Catalog> builder)
        {
            
        }
    }
}