using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMining
{
    static class DBSCANClass
    {
        //**********************************DBSCAN Alghorithm *******************************************************
        static public List<List<PointInfo>> GetClusters(List<PointInfo> points, double eps, int minPts)
        {
            if (points == null) return null;
            List<List<PointInfo>> clusters = new List<List<PointInfo>>();
            eps *= eps; // square eps
            int clusterId = 1;
            for (int i = 0; i < points.Count; i++)
            {
                PointInfo p = points[i];
                if (p.ClusterId == PointInfo.UNCLASSIFIED)
                {
                    if (ExpandCluster(points, p, clusterId, eps, minPts)) clusterId++;
                }
            }
            // sort out points into their clusters, if any
            int maxClusterId = points.OrderBy(p => p.ClusterId).Last().ClusterId;
            if (maxClusterId < 1) return clusters; // no clusters, so list is empty
            for (int i = 0; i < maxClusterId; i++) clusters.Add(new List<PointInfo>());
            foreach (PointInfo p in points)
            {
                if (p.ClusterId > 0) clusters[p.ClusterId - 1].Add(p);
            }
            return clusters;
        }

        static List<PointInfo> GetRegion(List<PointInfo> points, PointInfo p, double eps)
        {
            List<PointInfo> region = new List<PointInfo>();
            for (int i = 0; i < points.Count; i++)
            {
                int distSquared = PointInfo.DistanceSquared(p, points[i]);
                if (distSquared <= eps) region.Add(points[i]);
            }
            return region;
        }

        static bool ExpandCluster(List<PointInfo> points, PointInfo p, int clusterId, double eps, int minPts)
        {
            List<PointInfo> seeds = GetRegion(points, p, eps);
            if (seeds.Count < minPts) // no core point
            {
                p.ClusterId = PointInfo.NOISE;
                return false;
            }
            else // all points in seeds are density reachable from point 'p'
            {
                for (int i = 0; i < seeds.Count; i++) seeds[i].ClusterId = clusterId;
                seeds.Remove(p);
                while (seeds.Count > 0)
                {
                    PointInfo currentP = seeds[0];
                    List<PointInfo> result = GetRegion(points, currentP, eps);
                    if (result.Count >= minPts)
                    {
                        for (int i = 0; i < result.Count; i++)
                        {
                            PointInfo resultP = result[i];
                            if (resultP.ClusterId == PointInfo.UNCLASSIFIED || resultP.ClusterId == PointInfo.NOISE)
                            {
                                if (resultP.ClusterId == PointInfo.UNCLASSIFIED) seeds.Add(resultP);
                                resultP.ClusterId = clusterId;
                            }
                        }
                    }
                    seeds.Remove(currentP);
                }
                return true;
            }
        }
    }
}
