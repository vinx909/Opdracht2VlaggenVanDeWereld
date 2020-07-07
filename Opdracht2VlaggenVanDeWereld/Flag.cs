using System.Drawing;
using System.Windows.Forms;

namespace Opdracht2VlaggenVanDeWereld
{
    public class Flag
    {
        private string countryName;
        private string flagPicturePath;

        public Flag(string countryName, string flagPicturePath)
        {
            this.countryName = countryName;
            this.flagPicturePath = flagPicturePath;
        }

        public string getCountryName()
        {
            return countryName;
        }
        public string getFlagPicturePath()
        {
            return flagPicturePath;
        }
    }
}