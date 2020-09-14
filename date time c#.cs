
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace date_time
{
    public class Program
    {
        public static void Main(string[] args)
        {
             int yob;
             int mob;
            int dob;
            
            Console.WriteLine("Enter the year of your birth!");
            int yob = convert.toint32(console.readline());
            
            Console.WriteLine("Enter the month of your birth!");
            int mob = convert.toint32(console.readline());
            
            Console.WriteLine("Enter the year of your birth!");
            int dob = Convert.Toint32(Console.Readline());
			
			
			console.readline();
		}
		
			private static string displayastrologicalsign(int mob,int dob)
			{
				switch(mob) {
					
					case 1: 
						if(dob<=20)
						{
							return "capricorn";
			
						} 
						else
							return "aquarius";
						
					case 2: 
						if(dob<=18)
						{
							return "aquarius";
			
						} 
						else
							return "pisces";
					case 3: 
						if(dob<=20)
						{
							return "pisces";
			
						} 
						else
							return "aries";
					default: return "null";
						
			
			private static bool todaybirthday(int mob, int dob)
			{
				datetime tdy= datetime.today;
				if(mob == tdy.month && dob == tdy.day)
					return true;
				else
					return false;
				
			}
				
            
            
            int rcode = checkbirthdate(yob, mob ,dob);
            
            switch(rcode) 
            {
             case 0: console.writeline("hey you are born today");
                break;
                  case 1: console.writeline("you have entered a future date");
                 break;
                 case 2: console.writeline("you r lucky to have lived >=135");
                 break;
                default:console.writeline("age of the irse is: " + rcode);
                break;
				if(todaybirthday(mob,dob))
					console.writeline("happy  birthday");
            }
            
            console.readline();
        
        }
		
		
            
        private static void checkbirthdate(int yob, int mob, int dob)
        {
            datetime bdate = new datetime(yob,mob,dob);
            int rvalue = datetime.compare(bdate, tdate);
            if(rvalue<0)
            {
            if(tdate.year - bdate.year >= 135);
                return 2;
                else 
                    return (tdate.year - bdate.year);
                
            }
                else if(rvalue > 0)
                {
                    return 1
                }
            else {
                        
        }
    }
}