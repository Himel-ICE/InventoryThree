using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace InventoryThree.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime DateTime { get; set; }
        public Member Member { get; set; }
        public Equipment()
        {
            Member = new Member();
        }

        public static List<Equipment> EquipmentList()
        {
            List<Equipment> list = new List<Equipment>();
            Random rnd = new Random();
            for (int i = 1; i <= 30; i++)
            {
                int num = rnd.Next(1, 30);
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop - " + i.ToString();
                equipment.Count = num;
                equipment.DateTime = DateTime.Now.Date;
                list.Add(equipment);
            }

            return list;
        }
        public static List<Equipment> AssignedMemberList()
        {
            List<Equipment> list = new List<Equipment>();
            for (int i = 1; i <= 30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop - " + i.ToString();
                equipment.Member.MemberName = "Member " + i.ToString();
                equipment.Member.MemberDesignation = "SKA" + i.ToString();
                equipment.Member.MemberMobileNumber = "0150000" + i.ToString();
                list.Add(equipment);
            }
            return list;
        }

    }
}