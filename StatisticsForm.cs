using _1var.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1var
{
    public partial class StatisticsForm : Form
    {
        private readonly MyDbContext _dbContext;
        public int DisplayedApplicationsCount { get; private set; }
        public StatisticsForm(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            LoadStatistics();
            DisplayedApplicationsCount = 8;
        }
        public int GetDisplayedApplicationsCount()
        {
            return DisplayedApplicationsCount;
        }

        public void LoadStatistics()
        {
            var statistics = _dbContext.Applicas
                .GroupBy(a => a.ClientId)
                .Select(g => new
                {
                    ClientId = g.Key,
                    ApplicationCount = g.Count(),
                    TotalCost = g.Sum(a => a.ExecCost)
                })
                .ToList();

            statisticsDataGridView.DataSource = statistics;
        }
        public List<dynamic> GetStatisticsData()
        {
            return statisticsDataGridView.DataSource as List<dynamic>;
        }
    }
}
