using System.Text.RegularExpressions;
namespace AggregateFilterOnAssociatedCollection {
    using System;
    using DevExpress.Xpo;
    
    
	[Persistent("Customers")]
	public class Customer : XPLiteObject {
        public Customer(Session session) : base(session) { }

        [Key]
        public string CustomerID;

        private string _CompanyName;
        public string CompanyName {
            get {
                return _CompanyName;
            }
            set {
                SetPropertyValue("CompanyName", ref _CompanyName, value);
            }
        }
        private string _ContactTitle;
        public string ContactTitle {
            get {
                return _ContactTitle;
            }
            set {
                SetPropertyValue("ContactTitle", ref _ContactTitle, value);
            }
        }

		[Association("CustomerOrders")]
		public XPCollection<Order> Orders {
			get {
				return GetCollection<Order>("Orders");
			}
		}
	}

	[Persistent("Orders")]
	public class Order : XPLiteObject {
        public Order(Session session) : base(session) { }

		[Key]
		public int OrderID;

        private Customer _Customer;
		[Persistent("CustomerID"), Association("CustomerOrders")]
        public Customer Customer {
            get {
                return _Customer;
            }
            set {
                SetPropertyValue("Customer", ref _Customer, value);
            }
        }

        private Employee _Employee;
        [Persistent("EmployeeID"), Association("EmployeeOrders")]
        public Employee Employee {
            get {
                return _Employee;
            }
            set {
                SetPropertyValue("Employee", ref _Employee, value);
            }
        }

        private DateTime _OrderDate;
        public DateTime OrderDate {
            get {
                return _OrderDate;
            }
            set {
                SetPropertyValue("OrderDate", ref _OrderDate, value);
            }
        }

        private decimal _Freight;
        public decimal Freight {
            get {
                return _Freight;
            }
            set {
                SetPropertyValue("Freight", ref _Freight, value);
            }
        }
	}

	[Persistent("Employees")]
	public class Employee : XPLiteObject {
        public Employee(Session session) : base(session) { }
		[Key]
		public int EmployeeID;

        private string _FirstName;
        public string FirstName {
            get {
                return _FirstName;
            }
            set {
                SetPropertyValue("FirstName", ref _FirstName, value);
            }
        }

        private string _LastName;
        public string LastName {
            get {
                return _LastName;
            }
            set {
                SetPropertyValue("LastName", ref _LastName, value);
            }
        }

		[Association("EmployeeOrders")]
		public XPCollection<Order> Orders {
			get {
                return GetCollection<Order>("Orders");
			}
		}
	}
}
