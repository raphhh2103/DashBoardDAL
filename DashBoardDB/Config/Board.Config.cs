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
    internal class BoardConfig : IEntityTypeConfiguration<BoardEntity>
    {
        public void Configure(EntityTypeBuilder<BoardEntity> builder)
        {
            builder.ToTable(nameof(BoardEntity));

            builder.HasKey(x => x.Id).HasName("PK_Board");


            builder.HasIndex(x => x.Title);


            builder.HasOne<UserEntity>(t=>t.UserOwner).WithMany(x => x.Boards).HasForeignKey(x => x.Id);

            builder.HasMany<ContentEntity>(d => d.Contents).WithOne(d => d.TitleBoard).HasForeignKey(x => x.Id);
        }
    }
}
