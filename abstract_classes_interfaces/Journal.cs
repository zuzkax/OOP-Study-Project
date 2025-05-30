﻿namespace lab_03
{
    class Journal : Item
    {
        public int Number { get; set; }
    
        public Journal() 
            :base()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
            :base(title, id,  publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"Journal | {base.ToString()}, Number: {Number}";
        }
        public override string GenerateBarCode()
        {
            string output = "Barcode....";
            return output;
        }
}
}
