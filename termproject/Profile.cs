using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termproject
{
    public class Profile
    {
        private string type;
        private string name;
        private string gender;
        private int age;
        private System.Drawing.Image avatar;

        public Profile()
        {
            this.name = "Computer";
        }

        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public Image Avatar { get => avatar; set => avatar = value; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
