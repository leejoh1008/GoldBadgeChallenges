using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneRepo
{
    
    public class MenuMethods
    {
        List<MenuItems> _menuItems = new List<MenuItems>();     

        public bool AddMenu(MenuItems item)           //create
        {
            if(item is null)
            { return false; }
            _menuItems.Add(item);
            return true;
        }
        public List<MenuItems> GetMenu()              //read
        {
            return _menuItems;
        }


        public bool RemoveItemById( int itemId)
        {
            MenuItems menu = GetItemInMenu(itemId);

            if (menu == null)
            {
                return false;
            }
            int initialCount = _menuItems.Count;
            _menuItems.Remove(menu);

            if (initialCount > _menuItems.Count)
            {
                return true;
            }
            else { return false; }
        }
        private MenuItems GetItemInMenu(int id)
        {
            foreach (MenuItems items in _menuItems)
            {
                if(items.Id == id)
                {
                    return items;
                }

            }
            return null;
        }

    }
}
