using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthleteManagement
{
    internal class ParticipantResult
    {
        public string BibNumber { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public TimeSpan FinishTime { get; set; }
        // Add other relevant properties like checkpoint times
    }
}
