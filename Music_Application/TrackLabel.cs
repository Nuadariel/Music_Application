using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Application
{
    class TrackLabel:Label
    {
        public string name;
        public string duration;
        public string text;
        public int listen_number;
        public byte[] data;
        public TrackLabel(string name, string duration, string text,int listen_number, byte[] data)
        {
            this.name = name;
            this.duration = duration;
            this.text = text;
            this.listen_number = listen_number;
            this.data = data;
        }
    }
    
}
