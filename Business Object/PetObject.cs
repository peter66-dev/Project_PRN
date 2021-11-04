using System;

namespace Business_Object
{
    public class PetObject
    {
        public int PetID { get; set; }
        public string PetName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Color { get; set; }
        public int QuantityInStock { get; set; }
        public int CategoryID { get; set; }
        public decimal ImportPrice { get; set; }
        public decimal ExportPrice { get; set; }
        public bool Status { get; set; }

        public PetObject()
        {

        }

        public PetObject(int id, string name, string color, int age, decimal price, bool gender, int quantityBuy)
        {
            PetID = id;
            PetName = name;
            Color = color;
            Age = age;
            ExportPrice = price;
            Gender = gender;
            QuantityInStock = quantityBuy;
        }

        public PetObject(int id, string name, int age, bool gen, string color, int quantity, int cateid, 
            decimal import, decimal export, bool status)
        {
            PetID = id;
            PetName = name;
            Age = age;
            Gender = gen;
            Color = color;
            QuantityInStock = quantity;
            CategoryID = cateid;
            ImportPrice = import;
            ExportPrice = export;
            Status = status;
        }
    }
}
