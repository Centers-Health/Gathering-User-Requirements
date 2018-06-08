using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRequirementsLibrary
{
    public class Requirement
    {
        public int RequirementId {get;set;}
        public string Details { get; set; }
        public string Purpose { get; set; }
        public string SuccessfulWhen { get; set; }

        public int StakeholderId { get; set; }
        public Stakeholder Stakeholder { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
