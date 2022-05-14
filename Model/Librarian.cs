using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Librarian
    {
        private String name;
        private string password;
        private int id;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
    }
}