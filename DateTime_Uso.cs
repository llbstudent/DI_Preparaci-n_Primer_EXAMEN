//DateTime
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);


            //Con formato
            DateTime date4 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date4.ToString("yyyy-MM-dd"));

            //Sin formato
            DateTime date5 = new DateTime(2015, 12, 25);
            Console.WriteLine(date5.ToString());

            //Añadir días a una fecha
            DateTime today = DateTime.Now; 
            DateTime newDate2 = today.AddDays(30); 
            Console.WriteLine(newDate2);

            // Parsing  
            string dateString = "Wed Dec 30, 2015";
            DateTime dateTime12 = DateTime.Parse(dateString);

            // DateTime Properties
            DateTime myDate = new DateTime(2015, 12, 25, 10, 30, 45);
            int year = myDate.Year; // 2015  
            int month = myDate.Month; //12  
            int day = myDate.Day; // 25  
            int hour = myDate.Hour; // 10  
            int minute = myDate.Minute; // 30  
            int second = myDate.Second; // 45  
            int weekDay = (int)myDate.DayOfWeek; // 5 due to Friday 

            //DateTime Formatting
            DateTime tempDate = new DateTime(2015, 12, 08); // creating date object with 8th December 2015  
            Console.WriteLine(tempDate.ToString("MMMM dd, yyyy")); //December 08, 2105.

            //Calcular diferencia de dias ((EndDate - StartDate).TotalDays):
            DateTime d1;
            DateTime d2;
            return (d1 - d2).TotalDays;