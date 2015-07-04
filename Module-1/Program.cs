using System;

namespace Programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            DateTime birthDate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string zipPostal;
            string country;

            firstName = "Biff";
            lastName = "the Understudy";
            birthDate = DateTime.ParseExact(
                "1995-01-01 00:00:00,000",
                "yyyy-MM-dd HH:mm:ss,fff",
                System.Globalization.CultureInfo.InvariantCulture);
            addressLine1 = "Infinity loop 1";
            addressLine2 = "Infinity loop 3";
            city = "Cubertino";
            stateProvince = "California";
            zipPostal = "CA 95014";
            country = "United States";

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Birth date: " + birthDate.ToString());
            Console.WriteLine("Address line 1: " + addressLine1);
            Console.WriteLine("Address line 2: " + addressLine2);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State/province: " + stateProvince);
            Console.WriteLine("Zip/postal code: " + zipPostal);
            Console.WriteLine("Country: " + country);
            Console.ReadLine();
        }
    }
}
