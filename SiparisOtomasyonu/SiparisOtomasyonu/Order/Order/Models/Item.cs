using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Models
{
    public class Item 
    {
        public string ItemType { get; set; }
        public string ItemMaterial { get; set; }
        public string ItemQuantity { get; set; }
        public string ItemSize { get; set; }
        public int ShippingWeight { get; set; }

       public string ItemDescription { get; set; }

        public  int BedenAgirligi { get; set; }

        public  double KumasKGfiyati { get; set; }

      

        public int Price { get; set; }
        public Item()
        {
            Price = 1;
            ShippingWeight = 1;
            BedenAgirligi=100;
            KumasKGfiyati=10;
        }

         public int getPriceForQuantity(string kumas,string Tür)
        {
            // KUMAŞA GÖRE FİYATI HESAPLAMA
            if (kumas=="Kadife")
                KumasKGfiyati*=1.5;
            else if (kumas=="Keten")
                KumasKGfiyati*=1.25;
            else if (kumas=="Pamuk")
                KumasKGfiyati*=1;
      

            if (Tür=="Sweatshirt")
                Price*=11;
            else if (Tür=="Gömlek")
                Price*=9;
            else if (Tür=="Ceket")
                Price*=7;
            else if (Tür=="Kazak")
                Price*=5;

            Price*=Convert.ToInt32(KumasKGfiyati);

            return Price;
        }

        public int getWeight(string beden,string Tür)
        {

            // BEDENE GÖRE ÜRÜNÜN AĞIRLIĞINI HESAPLAMA
            if (beden =="XL")
                BedenAgirligi*=5;
            else if (beden =="L")
                BedenAgirligi*=4;
            else if (beden =="M")
                BedenAgirligi*=3;
            else if (beden =="S")
                BedenAgirligi*=2;
            else if (beden =="XS")
                BedenAgirligi*=1;

            if (Tür=="Sweatshirt")
                BedenAgirligi*=5;
            else if (Tür=="Gömlek")
                BedenAgirligi*=4;
            else if (Tür=="Ceket")
                BedenAgirligi*=3;
            else if (Tür=="Kazak")
                BedenAgirligi*=2;



            ShippingWeight= BedenAgirligi;

            return ShippingWeight;

        }


    }
}
