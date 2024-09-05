﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CampaignAds
    {
        public CampaignAds()
        {
            ProductClassification = new HashSet<ProductClassification>();
        }

        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Type { get; set; }
        public string Note { get; set; }
        public string ScriptSocial { get; set; }

        public virtual ICollection<ProductClassification> ProductClassification { get; set; }
    }
}
