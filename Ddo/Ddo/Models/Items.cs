using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ddo.Models
{
    [NPoco.TableName("dbo.Items")]
    public class Items
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string ItemFullDesc { get; set; }
        public int MinLevel { get; set; }
        public string BoundTo { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Character { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public string Destiny { get; set; }
        public string Notes { get; set; }
    }
}