using DashBoardDAL.Config;
using DashBoardDAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL
{
    public class DBConnect :DbContext
    {

        private readonly string _constr;

        public DbSet<BoardEntity> Board { get; set; }
        public DbSet<ContentEntity> Content { get; set; }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<TeamEntity> team { get; set; }
        public DbSet<ProjectEntity> Project { get; set; }


        public DBConnect()
        {
            this._constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Db_DashBoard;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //this._constr = @"Data Source=RAPH;Initial Catalog=Db_DashBoard;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public DBConnect(string connectionString):base()
        {
            this._constr=connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.UseSqlServer(_constr);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BoardConfig());
            modelBuilder.ApplyConfiguration(new UserEntityConfig());
            modelBuilder.ApplyConfiguration(new ContentConfig());
            modelBuilder.ApplyConfiguration(new TeamConfig());
            modelBuilder.ApplyConfiguration(new ProjectConfig());


            base.OnModelCreating(modelBuilder);
        }

    }
}
