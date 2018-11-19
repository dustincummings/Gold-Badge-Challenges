using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class BadgeRepo
    {
        List<string> _doorList = new List<string>();
        Dictionary<int, List<string>> _badgeID = new Dictionary<int, List<string>>();

        public void AddDoorToList(string door)
        {
            _doorList.Add(door);
        }
        public void RemoveDoorFromList(string door)
        {
            _doorList.Remove(door);
        }
        public List<string> ShowDoorList()
        {
            return _doorList;
        }
        public void AddBadge(Badge badge)
        {
            _badgeID.Add(badge.BadgeNum, badge.Doors);
        }
        //public Dictionary<int, List<string> ShowBadgeList() 
        //{
        //    return _badgeId;
        //}
}
}
