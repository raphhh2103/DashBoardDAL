using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Entities
{
    public class ProjectEntity
    {
        public int Id { get; set; }

        public string NameProject { get; set; }

        public IEnumerable<UserEntity> TeamsUsers { get; set; }
    }
}
