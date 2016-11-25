using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DataMining
{
    public sealed class CMeansAlgorithm
    {
        private List<ClusterPoint> Points;
        private List<ClusterCentroid> Clusters;
        public double[,] U;
        private double Fuzzyness;
        private double Eps = Math.Pow(10, -5);
        private double J { get; set; }
        public string Log { get; set; }
        public CMeansAlgorithm(List<ClusterPoint> points, List<ClusterCentroid> clusters, float fuzzy)
        {
            if (points == null)
            {
                throw new ArgumentNullException("points");
            }

            if (clusters == null)
            {
                throw new ArgumentNullException("clusters");
            }

            this.Points = points;
            this.Clusters = clusters;
            U = new double[this.Points.Count, this.Clusters.Count];
            //Uk = new double[this.Points.Count, this.Clusters.Count];
            this.Fuzzyness = fuzzy;
            double diff;
            // Iterate through all points to create initial U matrix
            for (int i = 0; i < this.Points.Count; i++)
            {
                ClusterPoint p = this.Points[i];
                double sum = 0.0;

                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    ClusterCentroid c = this.Clusters[j];
                    diff = Math.Sqrt(Math.Pow(p.X - c.X, 2.0) + Math.Pow(p.Y - c.Y, 2.0));
                    U[i, j] = (diff == 0) ? Eps : diff;
                    sum += U[i, j];
                }

                double sum2 = 0.0;
                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    U[i, j] = 1.0 / Math.Pow(U[i, j] / sum, 2.0 / (Fuzzyness - 1.0));
                    sum2 += U[i, j];
                }

                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    U[i, j] = U[i, j] / sum2;
                }
            }

            this.RecalculateClusterIndexes();
        }

        private CMeansAlgorithm()
        {
        }

        private void RecalculateClusterIndexes() 
        {
            for (int i = 0; i < this.Points.Count; i++)
            {
                double max = -1.0;
                var p = this.Points[i];

                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    if (max < U[i, j])
                    {
                        max = U[i, j];
                        p.ClusterIndex = (max == 0.5) ? 0.5 : j;
                    }
                }
            }
        }

        public void Step()
        {
            for (int c = 0; c < Clusters.Count; c++)
            {
                for (int h = 0; h < Points.Count; h++)
                {
                    double top = CalculateEulerDistance(Points[h], Clusters[c]);
                    if (top < 1.0) top = Eps;

                    // Bottom is the sum of distances from this data point to all clusters.
                    double sumTerms = 0.0;
                    for (int ck = 0; ck < Clusters.Count; ck++)
                    {
                        double thisDistance = CalculateEulerDistance(Points[h], Clusters[ck]);
                        if (thisDistance < 1.0) thisDistance = Eps;
                        sumTerms += Math.Pow(top / thisDistance, 2.0 / (this.Fuzzyness - 1.0));
                    }
                    
                    // Then the MF can be calculated as...
                    U[h, c] = (double)(1.0 / sumTerms);                    
                }
            }

            this.RecalculateClusterIndexes();
        }

        private double CalculateEulerDistance(ClusterPoint p, ClusterCentroid c) 
        {
            return Math.Sqrt(Math.Pow(p.X - c.X, 2) + Math.Pow(p.Y - c.Y, 2));
        }

        private double CalculateObjectiveFunction()
        {
            double Jk = 0;

            for (int i = 0; i < this.Points.Count;i++)
            {
                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    Jk += Math.Pow(U[i, j], this.Fuzzyness) * Math.Pow(this.CalculateEulerDistance(Points[i], Clusters[j]), 2);
                }
            }
            return Jk;
        }

        private void CalculateClusterCenters()
        {
            for (int j = 0; j < this.Clusters.Count; j++)
            {
                ClusterCentroid c = this.Clusters[j];
                double uX = 0.0;
                double uY = 0.0;
                double l = 0.0;

                for (int i = 0; i < this.Points.Count; i++)
                {
                    ClusterPoint p = this.Points[i];

                    double uu = Math.Pow(U[i, j], this.Fuzzyness);
                    uX += uu * c.X;
                    uY += uu * c.Y;
                    l += uu;
                }

                c.X = ((int)(uX / l));
                c.Y = ((int)(uY / l));

                this.Log += string.Format("Cluster Centroid: ({0}; {1})" + System.Environment.NewLine, c.X, c.Y);
            }
        }

        public int Run(double accuracy,int numberOfIteration)
        {
            int i = 0;
            do
            {
                i++;
                this.J = this.CalculateObjectiveFunction();
                this.CalculateClusterCenters();
                this.Step();
                double Jnew = this.CalculateObjectiveFunction();
                if (Math.Abs(this.J - Jnew) < accuracy) break;  
            }
            while (numberOfIteration > i);
            return i;
        }
    }
}
