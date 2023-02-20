using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cirieshka
{
    public class Archery
    {
        public delegate void Shoot(int result);
        public Shoot ShootChangeHandler { get; set; }

        public void Start()
        {

            for (int i = 0; i < 4; i++)
            { 
                int shooting = (new Random()).Next(0,5);
                ShootChangeHandler(shooting);
                Thread.Sleep(1000);
                
            }
            }
        }
}
