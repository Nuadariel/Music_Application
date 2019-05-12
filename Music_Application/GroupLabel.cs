using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application
{
    class GroupLabel:Label
    {
        public string id;
        public string name;
        public string description;
        public GroupLabel(string id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}
