using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht2VlaggenVanDeWereld
{
    class FlagGatherer
    {
        private static List<Flag> flags;
        public static List<Flag> GatherAllFlags()
        {
            if (flags == null)
            {
                createFlags();
            }
            return flags;
        }

        private static void createFlags()
        {
            flags = new List<Flag>();
            flags.Add(new Flag("netherlands", @"C:\Users\vinx.909\Documents\ITvitae\C#Leerhumpmiddel\Rood\Opdracht2VlaggenVanDeWereld\flags\dutch.jpg"));
            flags.Add(new Flag("french",      @"C:\Users\vinx.909\Documents\ITvitae\C#Leerhumpmiddel\Rood\Opdracht2VlaggenVanDeWereld\flags\french.jpg"));
            flags.Add(new Flag("german",      @"C:\Users\vinx.909\Documents\ITvitae\C#Leerhumpmiddel\Rood\Opdracht2VlaggenVanDeWereld\flags\german.jpg"));
            flags.Add(new Flag("belgium",     @"C:\Users\vinx.909\Documents\ITvitae\C#Leerhumpmiddel\Rood\Opdracht2VlaggenVanDeWereld\flags\belgium.png"));
        }
    }
}
