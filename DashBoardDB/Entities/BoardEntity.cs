using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Entities
{
    public class BoardEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public UserEntity UserOwner { get; set; }
        public IEnumerable<ContentEntity> Contents { get; set; }
    }
}
