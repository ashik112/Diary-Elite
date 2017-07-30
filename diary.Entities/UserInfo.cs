using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diary.Entities
{
    public class UserInfo
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public string Date { get; set; }
        public string Page { get; set; }
        public byte[] Image { get; set; }


    }
}
