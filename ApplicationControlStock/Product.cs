using System;

namespace ApplicationControlStock
{
    public class Product
    {
        public int Count { get; set; }
        public string Name { get; set; }

        public double Price { get; set; } 
        public DateTime TimeDelivery { get; set; }
        public int ID { get; set; }

        public SenderInfo Sender { get; set; }
        public RecipientInfo Recipient { get; set; }
    }
}
