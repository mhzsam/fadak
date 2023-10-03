using Domain.Entites.Base;
using Domain.Entites.Movies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites.Config
{
    public class MovieConfiguration : BaseConfiguration<Movie>
    {

        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);
            builder.HasOne<Category>().WithMany().HasForeignKey(s => s.CategoryCode).HasPrincipalKey(c => c.Code); ;
        }

    }
}
