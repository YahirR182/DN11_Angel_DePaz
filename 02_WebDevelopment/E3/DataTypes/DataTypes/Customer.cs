using System;
namespace DataTypes
{
	public class Customer
	{


		public int ID { get; set; }
        public string CustomerName { get; set; }
		public string CustomerLastName { get; set; }
		public DateTime CustomerDate { get; set; }


		public Customer(int ID,string CustomerName,string CustomerLastName,DateTime CustomerDate)
		{
			this.ID = ID;
			this.CustomerName = CustomerName;
			this.CustomerLastName = CustomerLastName;
			this.CustomerDate = CustomerDate;
		}




	}
}

