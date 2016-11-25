using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMining
{
    class PointInfo
    {
        public const int NOISE = -1;
        public const int UNCLASSIFIED = 0;
        public int X, Y, ClusterId;
        public PointInfo(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", X, Y);
        }

        public static int DistanceSquared(PointInfo p1, PointInfo p2)
        {
            int diffX = p2.X - p1.X;
            int diffY = p2.Y - p1.Y;
            return diffX * diffX + diffY * diffY;
        }
    }
}
