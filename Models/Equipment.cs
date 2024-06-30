using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class Equipment
    {
        public string EquipmentId { get; set; }
        public string Name { get; set; }
        public int Qty{ get; set; }
        public DateTime EntryDate { get; set; }

        //Member list create 
        public Member Member { get; set; }
        public Equipment() {
            Member = new Member();
        }

        public static List<Equipment> ListEquipment()
        {
            List<Equipment> list = new List<Equipment>();
            for (int i = 1; i <= 25; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop"+i.ToString();
                equipment.Qty = i*5;
                equipment.EntryDate = DateTime.Now.Date;
                list.Add(equipment);
            }        
            return list;
        }

        public static List<Equipment> ListAssinedEquipment()
        {
            List<Equipment> list = new List<Equipment>();
            for (int i = 1; i <= 25; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop" + i.ToString();
                equipment.Qty = i * 5;
                equipment.EntryDate = DateTime.Now.Date;

                equipment.Member.MemberName = "Member " + i.ToString();
                equipment.Member.MemberDesgination = "EEE";
                equipment.Member.MobileNumber = 132465789;

                list.Add(equipment);
            }
            return list;
        }




    }
}