using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ddo.Models;
using NPoco;

namespace Ddo.Data
{
    public class DdoRepository
    {
        public Database db = new Database("DDO");

        public List<Items> GetItems(int userId)
        {
            var items = db.Fetch<Items>("SELECT * FROM dbo.Items WHERE [UserId] = @0", userId);
            return items;
        }

        

    }
}