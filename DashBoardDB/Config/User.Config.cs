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
    public class UserEntityConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable(nameof(UserEntity));

            builder.HasKey(t => t.Id)
                .HasName("PK_User");
            /*.IsClustered();fait en sorte d'enregistrer" plus vite" fonctionne pas en 5.0.16 mais de retour en 6.0 */

            //champ
            builder.Property(t => t.Id).HasColumnName("IdUser");
            builder.Property(t=> t.Pseudo).HasMaxLength(50).IsRequired();
            builder.Property(t=>t.Email).HasMaxLength(254).IsRequired();
            builder.Property(t => t.PssWd).IsRequired();
            builder.Property(t => t.Salt).IsRequired();

            //contraintes

            builder.HasIndex(t => t.Pseudo).HasDatabaseName("UK_Pseudo").IsUnique();
            builder.HasIndex(t => t.Email).HasDatabaseName("UK_Email").IsUnique();


            //FK -> Many to one ... un user peut avoir plusieurs boards 
            builder.HasMany<BoardEntity>(d => d.Boards).WithOne(b => b.UserOwner).HasForeignKey(q=>q.Id);
            builder.HasMany<TeamEntity>(t => t.Teams).WithMany(u => u.TeamUsers);
        

        }
    }
}
