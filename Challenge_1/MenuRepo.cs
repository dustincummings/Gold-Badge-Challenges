using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class MenuRepo
    {
        List<Menu> _menuItems = new List<Menu>();
        
        public void AddItemToMenu(Menu item)
        {
            _menuItems.Add(item);
        }

        public void RemoveItemFromMenu(Menu removedItem)
        {
            _menuItems.Remove(removedItem);
        }
        public List<Menu> GetMenuList()
        {
            return _menuItems;
        }

       
        
    }
}
