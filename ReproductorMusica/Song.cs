using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsplaiMusic
{
    class Song
    {
        //Propiedades
        private int ID;
        private string name;
        private string path;
        private string checksum;
        private bool favourite;
        private string year;
        private bool active;

        //Constructores
        public Song()
        {
        }

        public Song(string name, string path, string checksum, bool favourite, string year, bool active)
        {
            this.setID(ID);
            this.setName(name);
            this.setPath(path);
            this.setChecksum(checksum);
            this.setFavourite(favourite);
            this.setyear(year);
            this.setActive(active);
        }

        //Getters y setters
        public int getID()
        {
            return this.ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getPath()
        {
            return this.path;
        }

        public void setPath(string path)
        {
            this.path = path;
        }

        public string getChecksum()
        {
            return this.checksum;
        }

        public void setChecksum(string checksum)
        {
            this.checksum = checksum;
        }

        public bool getFavourite()
        {
            return this.favourite;
        }

        public void setFavourite(bool favourite)
        {
            this.favourite = favourite;
        }

        public string getYear()
        {
            return this.year;
        }

        public void setyear(string year)
        {
            this.year = year;
        }

        public bool getActive()
        {
            return this.active;
        }

        public void setActive(bool active)
        {
            this.active = active;
        }

        //Metodos
        public void addToFavourites()
        {

        }

        public void deleteFromFavourites()
        {

        }
    }
}
