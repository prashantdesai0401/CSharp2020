namespace exercise4_person
	{
		class person {
			
		private string firstname;
		private string lastname;
		private string email;
		private string dob;
		private datetime dob;
 		
		
		public person(string firstname, string lastname, string email) {
			
			this.firstname= firstname;
			this.lastname= lastname;
			this.email = email;
			
		}
		
			public person(string firstname, string lastname, string email, datetime dob) {
			
			this.firstname= firstname;
			this.lastname= lastname;
			this.email = email;
			this.dob = dob;
		}
	
	
		public string dob { get =>  dob.Tostring(); set => dob = new datetime(convert.toint32(value.substring(0,4), value.substring(4,2,), value.substring(4,2))); }
		public string email { get =>  email; set => email = value; }	
		public string firstname { get =>  firstname; set => firstname = value; }
		public string lastname { get =>  lastname; set => lastname = value; }
		public datetime dob {get => dob; set => dob = value; }


		public bool adult {
			get {
				
				if((datetime.today.year - dob.year) >= 18)
					return true;
				else 
					return false;
			) 
			
			public bool birthday {
				get {
					if(dob.month == datetime.today.month) && (dob.day == datetime.today.day)
					{
						
						return true;
					}
					else {
						return false;
			
			public string screename {
				get {
					string screename;
					screenname = firstname.substring(0,4) + dob.month.tostring();
					return screenname;
					}
				}
				
				
				interface ipayable {
					 int retrievedueamount();
					 void addtodueamount(int dueamount);
					 void paymentaddress(string address);
					
				}					
					 
					
		
		
		class program {
			static void main(String []args){
				
				string fname,, lname, email, dob;
				
				console.writeline("enter first name");
				fname=console.readline();
				console.writeline("enter last name");
				lname=console.readline();
				console.writeline("enter email");
				email=console.readline();
				console.writeline("enter dob");
				dob=console.readline();
				
				datetime dt = new datetime(convert.toint32(dob.substring(0,4)), convert.toint32(dob.substring(6,4)));
				
				person p1 = new person(fname, lname, email, dt);
				
				console.writeline("the person is an adult?": + p1.adult);
				console.writeline("the sunsign?": + p1.sunsign);
				console.writeline("today birthday?": + p1 .birthday);
				console.writeline("thescreenname?": + p1.screenname);
				
				console.readline();
				
			}
		}
		
				