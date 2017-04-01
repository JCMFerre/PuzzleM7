using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puzzle
{
    public class Configuracio
    {

        private int numMovimentsMaxim;

        public Configuracio(int numMovimentsMaxim)
        {
            this.numMovimentsMaxim = numMovimentsMaxim;
        }

        public Configuracio()
        {
            this.numMovimentsMaxim = 12;
        }

        public int getNumMovimentsMaxim()
        {
            return numMovimentsMaxim;
        }

        public void setNumMovimentsMaxim(int numMovimentsMaxim)
        {
            this.numMovimentsMaxim = numMovimentsMaxim;
        }
    }
}
