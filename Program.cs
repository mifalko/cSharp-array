// pgm_person_srring
// author : mifalko
// creation date 20230801
// update date 20230801
// Release 1.0

// Purpose
// use of string fields to create a person

using System;
using System.Text;   // to be able to use encoding


namespace pgm_person_string;
class Program
{

    
    // Main program

    enum Defperson
    {
        familyName,
        firstName,
        ageString,
        gender,
        country
    }
    static void Main(string[] args)
    {
        

        Console.WriteLine("Hello, program 04b!");
        Console.WriteLine(Defperson.familyName );


        Console.OutputEncoding = Encoding.UTF8;

        DateOnly todayOnly  = new DateOnly();

        string familyName = string.Empty;
        string firstName = string.Empty;
        string ageString = string.Empty;
        int age = 0;

        // family contains the global information of a person within a unic string
        string family;

        // array of 10 persons

        string[,] persons = new string[9,5];
        
        int index = 0;
        string continueOK = "Y";

        while (index < persons.Length/5 && continueOK == "Y")
        {
            familyName = Tools_01.FamilyNameInput();
            
            
            firstName = Tools_01.FirstNameInput();
            ageString = Tools_01.AgeInput(); 
            
            age = Convert.ToInt32(ageString);

            string gender = Tools_01.GenderInput();
            string country = Tools_01.CountryInput();

            // 1st solution : use of a string which concatenates (+) every person fields 
            Tools_01.PersonDisplay(familyName, firstName, age, gender, country);
            string personRef = Tools_01.PersonReference(familyName, firstName, age, gender, country);
            

            /*
            persons[index, 0 ] = familyName;
            persons[index, 1 ] = firstName;
            persons[index, 2 ] = ageString;
            persons[index, 3 ] = gender;
            persons[index, 4 ] = country;
            */

            persons[0, (int)Defperson.familyName] = familyName;
            persons[index, (int)Defperson.firstName ] = firstName;
            persons[index, (int)Defperson.ageString ] = ageString;
            persons[index, (int)Defperson.gender ] = gender;
            persons[index, (int)Defperson.country] = country;
            
            //Console.WriteLine($"reference of the family (index) : {persons[index]}");
            index++;

            Console.Write ("Continue (Y,N) : ");
            continueOK = Console.ReadLine();
            
        }
       
        int i = 0;
        while (i < index)
        {
            Console.WriteLine($"reference of the array family (while): {persons[i,0]}, {persons[i,1]},{persons[i,2]},{persons[i,3]}{persons[i,4]}");
            i++;
            
        }
        
    
        
        
        
        




    }
}
