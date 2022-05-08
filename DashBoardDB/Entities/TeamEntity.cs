using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<UserEntity> TeamUsers { get; set; }
    }
}
