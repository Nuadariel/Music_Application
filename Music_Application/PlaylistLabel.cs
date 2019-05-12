using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Music_Application
{
    
    class PlaylistLabel:Label
    {
        public string id;
        public string name;
        public PlaylistLabel(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
