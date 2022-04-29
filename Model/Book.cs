using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        private String title;
        private byte[] picture;

        public string Title
        {
            get => title;
            set => title = value;
        }

        public byte[] Picture
        {
            get => picture;
            set => picture = value;
        }
    }
}