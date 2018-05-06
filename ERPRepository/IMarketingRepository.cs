using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPRepository
{
    interface IMarketingRepository
    {
        bool Insert(MarketingR i);
        bool Update(MarketingR i);
        bool Delete(string CampaignId);
        List<MarketingR> GetAllCampaign();
    }
}
