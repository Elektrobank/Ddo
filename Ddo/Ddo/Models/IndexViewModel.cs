using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ddo.Models
{
    public class IndexViewModel
    {
        public List<Items> ItemList { get; set; }
        public IndexViewModel()
        {
            ItemList = new List<Items>();
        }
    }
}