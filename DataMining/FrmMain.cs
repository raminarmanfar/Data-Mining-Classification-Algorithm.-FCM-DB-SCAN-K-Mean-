using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Excel = Microsoft.Office.Interop.Excel; 

namespace DataMining
{
    public partial class FrmMain : Form
    {
        bool IsExecuted;
        public bool dataImported { get; set; }
        public FrmMain()
        {
            IsExecuted = dataImported = false;
            InitializeComponent();

            nudEps.Enabled = nudMinPts.Enabled = true;
            nudNumberOfClusters.Enabled = false;
            dgvGiven.Columns[3].Visible = false;
            cbShowMethod.SelectedIndex = 0;
        }

        private void btnToolNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All data will be erased. Are you sure?", "Creating new Project...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                IsExecuted = true;
                progressBar1.Value = 0;
                txtResult.Clear();
                dgvGiven.Rows.Clear();
                pbDrawingSurface.CreateGraphics().Clear(Color.White);

                pbDrawingSurface.Cursor = Cursors.Cross;
                lblDataCounts.Text = (dgvGiven.Rows.Count - 1).ToString();
            }
        }

        private void btnToolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToolAbout_Click(object sender, EventArgs e)
        {
            FrmAboutProgram frm = new FrmAboutProgram();
            frm.ShowDialog(this);
        }

        private Color getColor(int n)
        {
            Color cl=Color.Black;
            switch (n % 21)
            {
                case 0: cl = Color.Red; break;
                case 1: cl = Color.Blue; break;
                case 2: cl = Color.Green; break;
                case 3: cl = Color.HotPink; break;
                case 4: cl = Color.Lime; break;
                case 5: cl = Color.DarkSeaGreen; break;
                case 6: cl = Color.Magenta; break;
                case 7: cl = Color.Olive; break;
                case 8: cl = Color.RoyalBlue; break;
                case 9: cl = Color.Violet; break;
                case 10: cl = Color.YellowGreen; break;
                case 11: cl = Color.Tomato; break;
                case 12: cl = Color.RosyBrown; break;
                case 13: cl = Color.Navy; break;
                case 14: cl = Color.MintCream; break;
                case 15: cl = Color.DarkOrchid; break;
                case 16: cl = Color.DarkOrange; break;
                case 17: cl = Color.Crimson; break;
                case 18: cl = Color.Azure; break;
                case 19: cl = Color.Aqua; break;
                case 20: cl = Color.AliceBlue; break;
            }

            if (n == -1) return Color.Black;
            else if (n == -2) return Color.Gray;
            return cl;
        }

        private void PutPoint(Point pt, Color cl, int scale)
        {
            int ptSize = 5;
            Graphics g = pbDrawingSurface.CreateGraphics();
            SolidBrush brush = new SolidBrush(cl);
            int pointSize = 2 * ptSize;
            int xLoc=pt.X * scale - ptSize;
            int yLoc=pt.Y * scale - ptSize;
            switch (cbShowMethod.SelectedIndex)
            {
                case 0:
                    g.FillEllipse(brush, xLoc, yLoc, pointSize, pointSize);
                    break;
                case 1:
                    g.FillEllipse(brush, xLoc, pbDrawingSurface.Height - (yLoc+pointSize+5), pointSize, pointSize);
                    break;
            }
        }

        private void ShowResultLog(List<List<PointInfo>> clusters, List<PointInfo> points)
        {
            Point pt = new Point();
            string plural = (clusters.Count != 1) ? "s" : "";
            txtResult.Text = string.Format("{0} Cluster{1} where found...\r\n", clusters.Count.ToString(), plural);
            int total = 0;
            Color cl = Color.Gold;
            for (int i = 0; i < clusters.Count; i++)
            {
                cl = getColor(i);
                int count = clusters[i].Count;
                total += count;
                plural = (count != 1) ? "s" : "";
                string str = string.Format("\r\nCluster {0} consists of the following {1} point{2}: (COLOR={3})", i + 1, count, plural, cl.Name);
                txtResult.Text += str;
                foreach (PointInfo p in clusters[i])
                {
                    txtResult.Text += "\r\n(" + p.X + ", " + p.Y + ")";
                    pt.X = p.X;
                    pt.Y = p.Y;
                    PutPoint(pt, getColor(i),tbZoom.Value+1);
                }
                Console.WriteLine();
            }
            // print any points which are NOISE
            total = points.Count - total;
            if (total > 0)
            {
                plural = (total != 1) ? "s" : "";
                string verb = (total != 1) ? "are" : "is";
                string str = string.Format("\r\nThe following {0} point{1} {2} NOISE: (COLOR={3})", total, plural, verb, "Gray");
                txtResult.Text += str;
                foreach (PointInfo p in points)
                {
                    if (p.ClusterId == PointInfo.NOISE)
                    {
                        txtResult.Text += "\r\n(" + p.X + ", " + p.Y + ")";
                        pt.X = p.X;
                        pt.Y = p.Y;
                        PutPoint(pt, getColor(-2), tbZoom.Value+1);
                    }
                }
            }
            else
            {
                txtResult.Text += "\r\nNo points are NOISE";
            }

            progressBar1.Value = 100;
        }

        private void ExecAlg()
        {
            progressBar1.Value = 0;
            Point pt = new Point();
            if (dgvGiven.Rows.Count - 1 > 0)
            {
                txtResult.Clear();

                List<PointInfo> points = new List<PointInfo>();
                for (int i = 0; i < dgvGiven.Rows.Count - 1; i++)
                {
                    pt.X = Convert.ToInt32(dgvGiven.Rows[i].Cells[0].Value);
                    pt.Y = Convert.ToInt32(dgvGiven.Rows[i].Cells[1].Value);
                    points.Add(new PointInfo(pt.X, pt.Y));
                }

                if (rbAlgDBSCAN.Checked)
                {
                    double eps = (double)nudEps.Value;
                    int minPts = (int)nudMinPts.Value;

                    List<List<PointInfo>> clusters = DBSCANClass.GetClusters(points, eps, minPts);

                    ShowResultLog(clusters, points);
                }
                else if (rbAlgKMean.Checked)
                {
                    int K = (int)nudNumberOfClusters.Value;
                    int PointsCount = dgvGiven.Rows.Count - 1;
                    double[][] rawData = new double[PointsCount][];
                    for (int i = 0; i < PointsCount; i++)
                    {
                        rawData[i] = new double[] { Convert.ToDouble(dgvGiven.Rows[i].Cells[0].Value), Convert.ToDouble(dgvGiven.Rows[i].Cells[1].Value) };
                    }
                    List<List<PointInfo>> clusters = K_Mean.GetClusters(rawData, K);
                    //List<PointInfo> results = KMeanPoints.OrderBy(x => x.ClusterId).ToList();
                    ShowResultLog(clusters, points);
                }
                else if (rbAlgFCM.Checked)
                {
                    int CentroidCount = 0;
                    List<ClusterPoint> clusterPoints = new List<ClusterPoint>();
                    List<ClusterCentroid> centroids = new List<ClusterCentroid>();

                    for (int i = 0; i < dgvGiven.Rows.Count - 1; i++)
                    {
                        double x = Convert.ToDouble(dgvGiven.Rows[i].Cells[0].Value);
                        double y = Convert.ToDouble(dgvGiven.Rows[i].Cells[1].Value);
                        clusterPoints.Add(new ClusterPoint(x, y));
                        if ((bool)dgvGiven.Rows[i].Cells[3].Value == true)
                        {
                            CentroidCount++;
                            centroids.Add(new ClusterCentroid(x, y));
                        }
                    }

                    if (CentroidCount != (int)nudNumberOfClusters.Value)
                    {
                        MessageBox.Show("The number of Centroids (Clusters) is not equal to number of selected centroid points\r\nPlease choose centroid points equal to number of clusters count", "Error on centroid points selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CMeansAlgorithm alg = new CMeansAlgorithm(clusterPoints, centroids, (float)nudFuzzyExp.Value);
                        int iterations = alg.Run(Math.Pow(10, -5), (int)nudIterations.Value);

                        double[,] Matrix = alg.U;

                        txtResult.Clear();
                        txtResult.Text = string.Format("FCM Algorithm Results with ({0}):\r\n", iterations);
                        for (int j = 0; j < clusterPoints.Count; j++)
                        {
                            for (int i = 0; i < centroids.Count; i++)
                            {
                                ClusterPoint p = clusterPoints[j];
                                txtResult.Text += string.Format("\r\n{0:00} Point: ({1};{2}) ClusterIndex: {3} Value: {4:0.000}", j + 1, p.X, p.Y, p.ClusterIndex, Matrix[j, i]);
                                pt.X = (int)p.X;
                                pt.Y = (int)p.Y;
                                PutPoint(pt, getColor((int)p.ClusterIndex), tbZoom.Value + 1);
                            }
                        }

                        txtResult.Text += string.Format("\r\nIteration count: {0}", iterations);
                    }
                }
            }
            else
            {
                MessageBox.Show("There are no ay information to calculate DBSCAN", "No data exist to mining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnToolExecute_Click(object sender, EventArgs e)
        {
            IsExecuted = true;
            ExecAlg();
        }

        private void pbDrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            lblCurRow.Text = e.Y.ToString();
            lblCurCol.Text = e.X.ToString();
        }

        private void RefreshPoints()
        {
            pbDrawingSurface.CreateGraphics().Clear(Color.White);
            Point pt = new Point();
            for (int i = 0; i < dgvGiven.Rows.Count - 1; i++)
            {
                pt.X = Convert.ToInt32(dgvGiven.Rows[i].Cells[0].Value);
                pt.Y = Convert.ToInt32(dgvGiven.Rows[i].Cells[1].Value);
                PutPoint(pt, getColor(-1), tbZoom.Value + 1);
            }
            lblDataCounts.Text = (dgvGiven.Rows.Count - 1).ToString();
        }

        private void btnPtRefresh_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            txtResult.Clear();
            RefreshPoints();
        }

        private void dgvGiven_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RefreshPoints();
        }

        private void btnToolImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            openFileDialog1.Filter = "Excel Files (*.xls,*.xlsx)|*.xls;*.xlsx";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Import data from file";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IsExecuted = false;
                    System.Data.OleDb.OleDbConnection MyConnection;
                    System.Data.DataSet DtSet;
                    System.Data.OleDb.OleDbDataAdapter MyCommand;
                    FileInfo fi = new FileInfo(openFileDialog1.FileName);
                    string excelObject = "Provider=Microsoft.{0}.OLEDB.{1};Data Source={2};Extended Properties=\"Excel {3};HDR=YES\"";

                    if (fi.Extension.Equals(".xls"))
                    {
                        excelObject = string.Format(excelObject, "Jet", "4.0", openFileDialog1.FileName, "8.0");
                    }
                    else if (fi.Extension.Equals(".xlsx"))
                    {
                        excelObject = string.Format(excelObject, "Ace", "12.0", openFileDialog1.FileName, "12.0");
                    }
                    MyConnection = new System.Data.OleDb.OleDbConnection(excelObject);
                    MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                    MyCommand.TableMappings.Add("Table", "TestTable");
                    DtSet = new System.Data.DataSet();
                    MyCommand.Fill(DtSet);

                    if (dgvGiven.RowCount - 1 > 0)
                    {
                        if (MessageBox.Show("Do you want to replace imported points with current ones?", "Add or replace imported point", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            dgvGiven.Rows.Clear();
                        }
                    }
                    dgv1.DataSource = DtSet.Tables[0];
                    bool bVal;
                    string cVal;
                    for (int i = 0; i < dgv1.Rows.Count-1; i++)
                    {
                        bVal = false;
                        if (dgv1.Columns.Count == 4) bVal = (bool)dgv1.Rows[i].Cells[3].Value;
                        cVal = string.Empty;
                        if (dgv1.Columns.Count >= 3)
                            dgvGiven.Rows.Add(Convert.ToInt16(dgv1.Rows[i].Cells[0].Value), Convert.ToInt16(dgv1.Rows[i].Cells[1].Value), dgv1.Rows[i].Cells[2].Value, bVal, -1);
                    }

                    lblDataCounts.Text = (dgvGiven.Rows.Count - 1).ToString();
                    progressBar1.Value = 0;
                    txtResult.Clear();
                    RefreshPoints();

                    MyConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pbDrawingArea_MouseClick(object sender, MouseEventArgs e)
        {
            PutPoint(e.Location, getColor(-1), tbZoom.Value+1);
            dgvGiven.Rows.Add(e.X, e.Y, 0, false,-1);
            lblDataCounts.Text = (dgvGiven.Rows.Count - 1).ToString();
        }

        private void rbAlgDBSCAN_CheckedChanged(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            txtResult.Clear();
            RefreshPoints();

            if (rbAlgDBSCAN.Checked)
            {
                nudEps.Enabled = nudMinPts.Enabled = true;
                nudNumberOfClusters.Enabled = false;
                nudFuzzyExp.Enabled = nudIterations.Enabled = false;
                dgvGiven.Columns[3].Visible = false;
            }
            else if (rbAlgKMean.Checked)
            {
                nudEps.Enabled = nudMinPts.Enabled = false;
                nudNumberOfClusters.Enabled = true;
                nudFuzzyExp.Enabled = nudIterations.Enabled = false;
                dgvGiven.Columns[3].Visible = false;
            }
            else if (rbAlgFCM.Checked)
            {
                nudEps.Enabled = nudMinPts.Enabled = false;
                nudNumberOfClusters.Enabled = true;
                nudFuzzyExp.Enabled = nudIterations.Enabled = true;
                dgvGiven.Columns[3].Visible = true;
            }
        }
        //--------------------------------------
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnPtExport_Click(object sender, EventArgs e)
        {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            saveFileDialog1.Filter = "Excel Files (*.xls,*.xlsx)|*.xls;*.xlsx";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.Title = "Export data to file";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
				/*
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                for (i = 0; i <= dgvGiven.RowCount - 1; i++)
                {
                    for (j = 0; j <= dgvGiven.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgvGiven[j, i];
                        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Excel file created , you can find the file " + saveFileDialog1.FileName);
*/
            }
        }

        private void tbZoom_ValueChanged(object sender, EventArgs e)
        {
            pbDrawingSurface.CreateGraphics().Clear(Color.White);
            if(IsExecuted) ExecAlg();
            else RefreshPoints();
        }
    }
}
