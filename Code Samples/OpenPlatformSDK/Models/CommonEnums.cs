using System;
namespace Models
{
    public class CommonEnums
    {
        

        public enum OrderStatus
        {
            WaitingForPayment = 0,
            Completed = 1,
            Cancelled = 2
        }

        public enum Gender
        {
            Confidential = 0,
            Male = 1,
            Female = 2
        }
    }
}
