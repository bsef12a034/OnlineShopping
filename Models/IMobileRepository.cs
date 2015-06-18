using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Term_Project.Models
{
    public class MobileRepository:IMobile
    {
        public void saveMobile(mobile m)
        {
            using (
            OnlineMobileShopEntities1 db = new OnlineMobileShopEntities1())
            {
                db.mobiles.Add(m);
                db.SaveChanges();
            }
        }
        public void updateMobile(mobile m)
        {
            using (
            OnlineMobileShopEntities1 db = new OnlineMobileShopEntities1())
            {
                mobile nz = db.mobiles.Where(nm=>nm.name==m.name).FirstOrDefault();
                nz.brand = m.brand;
                nz.name = m.name;
                nz.price = m.price;
                nz.processor = m.processor;
                nz.os = m.os;
                nz.display = m.display;
                nz.camera = m.camera;
                nz.battery = m.battery;
                nz.other = m.other;
                nz.image = m.image;
                db.SaveChanges();
            }
        }
    }
}