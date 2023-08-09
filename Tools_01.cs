namespace pgm_person_string
{
    class Tools_01
    {

        const int ageMin = 1;
        const int ageMax = 130;
        static bool NameCheck(string name)
        {
            if (string.IsNullOrEmpty(name) )
            {
                Console.WriteLine("!Error :Name is null");
                return false;
            }
       
            if (!name.All(Char.IsLetter))
                {
                    Console.WriteLine ($"! error. you must enter only letters");
                    return false;
                } 
            
            if (!(name.Length <= 32))
                {
                    Console.WriteLine ($"! the length of your data is > 32 ");
                    return false;
                }
        
            return true;
                
        }

        static public string FamilyNameInput()
        {
            string familyName = "";
            do
            {
                Console.Write("Your family name ? ");
                familyName = Console.ReadLine();
                Console.WriteLine("Family name : " + familyName);
            }
            while ( !NameCheck(familyName) );
            
            return familyName;
        }

        static public string FirstNameInput()
        {
            string firstName = "";
            do
            {
                Console.Write("Your first name ? ");
                firstName = Console.ReadLine();
                Console.WriteLine("First name : " + firstName);
            }
            while (!NameCheck(firstName) );
            
            return firstName;
        }

        static public string AgeInput()
        {
            string age = "";
            do
            {
                Console.Write("input your age ? ");
                age = Console.ReadLine();
            }
            while (!AgeCheck(age) );
            
            Console.WriteLine("your age is  " + age );
            
            return age;
        }

        static public string GenderInput()
        {
            string gender = "";
            do 
            {
                Console.Write("input your gender (M, F) ? ");
                gender = Console.ReadLine();
            }
            while (gender != "M" && gender !="F");
            
            Console.WriteLine("Your gender : " + gender);

            return gender;
        }

        static public string CountryInput()
        {
            string? country  = "";
            do 
            {
                Console.Write("input your country ? ");
                country = Console.ReadLine();
            }
            while (country?.Length != 2 && country?.Length != 3);
            
            Console.WriteLine("Your country : " + country);

            return country;
        }

        
               
        static bool AgeCheck(string ageString)
        {
            bool isParsable = int.TryParse(ageString, out int age);

            if (!isParsable)
            {
                Console.WriteLine("Age could not be parsed.");
                return false;
            }
            if (age < ageMin || age > ageMax)
            {
                Console.WriteLine("Age is not inside norman values");
                return false;
            }
            return true;
        }

        static public void PersonDisplay(string familyName, string firstName, int age ,string gender, string country)
        {
            Console.WriteLine($"Your family name : {familyName} and first name : {firstName}, your age {age} years old and you are {gender} and your country {country}");
            
        }

        static public string PersonReference(string familyName, string firstName, int age ,string gender, string country)
        {
            
            string personRef = $"{familyName}, {firstName}, {age}, {gender}, {country}";

            return personRef;
        }

        // Use of tuples to return the fields of the familly
        static public Tuple<string, string, int, string ,string > PersonReferenceT(string familyName, string firstName, int age ,string gender, string country)
        {
            Tuple<string, string, int, string ,string > personRefT;
            personRefT = new(familyName, firstName, age, gender, country);

            return personRefT;
        }

        static public void PersonDisplayT(Tuple<string, string, int, string ,string > p)
        {
            Console.WriteLine($"Your family name (Tuple) : {p.Item1} and first name : {p.Item2}, your age {p.Item3} years old and you are {p.Item4} and your country {p.Item5}");
            
        }


    }
}