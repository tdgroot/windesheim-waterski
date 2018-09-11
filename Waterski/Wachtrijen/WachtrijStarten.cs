using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterski.Wachtrijen
{
    public class WachtrijStarten
    {
        public Queue<Sporter> Wachtrij { get; private set; }

        public WachtrijStarten()
        {
            Wachtrij = new Queue<Sporter>();
        }

        public void VoegSporterToeAanRij(Sporter sporter)
        {
            Wachtrij.Enqueue(sporter);
        }
    }
}
