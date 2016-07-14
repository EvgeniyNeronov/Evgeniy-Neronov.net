using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosoyPerEntityDB.Model
{
    public class KosoiDataProvider
    {
        public List<string> GetOrdersItemInfo()
        {
            List<string> list = new List<string>();

            using (var cntx = new klimovskii_kosoiEntities())
            {
                var items = (from r in cntx.wp_kosoiwoocommerce_order_items select r).ToList();

                items.ForEach((x) => 
                {
                    list.Add($"{x.order_id} {x.order_item_name}");

                });
            }

            return list;
        }
    }
}
