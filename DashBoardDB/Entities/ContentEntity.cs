using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardDAL.Entities
{
    public class ContentEntity
    {

        public int Id { get; set; }

        public string Text { get; set; }

        public BoardEntity TitleBoard { get; set; }


    }
}
