using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        public void ShowReport(string reportFileName, string reportTitle, string recordFilter)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument
                rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            string reportFile = string.Format("{0}\\Reports\\{1}", Application.StartupPath, reportFileName);

            rpt.Load(reportFile);
            // cập nhật dtb
            CrystalDecisions.Shared.TableLogOnInfo tableLogOnInfo = new CrystalDecisions.Shared.TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.DatabaseName = ".\\SQLEXPRESS";
            tableLogOnInfo.ConnectionInfo.DatabaseName = "db_BTLQuanLiDeThiTracNghiem";
            tableLogOnInfo.ConnectionInfo.UserID = "";
            tableLogOnInfo.ConnectionInfo.Password = "";
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in rpt.Database.Tables)
            {
                table.ApplyLogOnInfo(tableLogOnInfo);
            }
            //tiêu đề
            rpt.SummaryInfo.ReportTitle = reportTitle;
            //lọc bản ghi
            if (!string.IsNullOrEmpty(recordFilter))
            {
                rpt.RecordSelectionFormula = recordFilter;
            }
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }
    }
}
