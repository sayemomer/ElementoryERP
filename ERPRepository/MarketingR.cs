using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
  public  class MarketingR
    {
        private int campaignId;
        private string campaignName;
        private string objective;
        private string placement;
        private string employeeName;
        private string launchDate;
        private string endDate;
        private double runningCost;
        private string report;
        private double budget;
        private string status;

        public int CampaignId
        {
            get { return campaignId; }
            set { campaignId = value; }
        }
        public string CampaignName
        {
            get { return campaignName; }
            set { campaignName = value; }
        }
        public string Objective
        {
            get { return objective; }
            set { objective = value; }
        }
        public string Placement
        {
            get { return placement; }
            set { placement = value; }

        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public string LaunchDate
        {
            get { return launchDate; }
            set { launchDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public double RunningCost
        {
            get { return runningCost; }
            set { runningCost = value; }
        }

        public string Report
        {
            get { return report; }
            set { report = value; }
        }

        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
