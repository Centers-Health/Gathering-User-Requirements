using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRequirementsLibrary
{
    public class Stakeholder
    {
        public int StakeholderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Requirement> Requirements { get; set; }
    }
}
