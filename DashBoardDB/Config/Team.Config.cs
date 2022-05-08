using DashBoardDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Config
{
    internal class TeamConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<TeamEntity>
    {
        public void Configure(EntityTypeBuilder<TeamEntity> builder)
        {
                builder.ToTable(nameof(TeamEntity));

            builder.HasKey(t => t.Id).HasName("PK_Team");

            builder.Property(t => t.Name).HasColumnName("Name");


            builder.HasMany<UserEntity>(d => d.TeamUsers).WithMany(r => r.Teams);
        }
    }
}
