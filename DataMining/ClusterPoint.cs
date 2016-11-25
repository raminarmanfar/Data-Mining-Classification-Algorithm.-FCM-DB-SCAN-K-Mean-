using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DataMining
{
	public class ClusterPoint
	{
        public double X { get; set; }

        public double Y { get; set; }

        public object Tag { get; set; }

        public double ClusterIndex { get; set; }

        public ClusterPoint(double x, double y)
		{
			this.X = x;
            this.Y = y;
            this.ClusterIndex = -1;
		}

        public ClusterPoint(double x, double y, object tag)
        {
            this.X = x;
            this.Y = y;
            this.Tag = tag;
            this.ClusterIndex = -1;
        }
	}

}
