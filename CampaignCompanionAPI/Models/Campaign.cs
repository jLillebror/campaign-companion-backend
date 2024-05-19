using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CampaignCompanionAPI.Models
{
    public class Campaign
    {
        [Key]
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GameSystem { get; set; }
        public string CampaignSetting { get; set; }
        public string AdditionalNotes { get; set; }

        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
