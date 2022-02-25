using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagement.Models
{
    public class TravelViewModel
    {
        public Travel Travel { get; set; }

        public TravelViewModel()
        {
        }
        public TravelViewModel(Travel travel)
        {
            Travel = travel;
        }
    }
}
