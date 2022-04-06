using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    class TacoBell: ITrackable
    {
        public TacoBell() // constructor
        { }
        //Name, Location variable to conform to ITrackable interface
        public string Name { get; set; }
        public Point Location { get; set; }

    }
}
