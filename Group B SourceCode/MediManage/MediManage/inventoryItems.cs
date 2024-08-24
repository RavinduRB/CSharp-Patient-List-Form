using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediManage
{
    
    public class inventoryItems
    {
       
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Created {  get; set; }

        public Category Category { get; set; }
        public string  Quantity { get; set; }
        
        public inventoryItems()
        {
            Created = new DateTime();
            Category = new Category();
            
        }

    }

    
}
