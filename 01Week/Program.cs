using System;
using System.Text;

namespace ConsoleApplication
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
            //We have crated a new person
            Person person = new Person();

            //Add the values of the properties that define that new person
            Console.WriteLine("Enter the First Name");
            person.firstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name");
            person.lastName = Console.ReadLine();

            Console.WriteLine("Enter favorite team");
            person.favoriteTeam = Console.ReadLine();

            Console.WriteLine("Enter the ethnicity");
            person.ethnicity = Console.ReadLine();

            Console.WriteLine("Enter the gender");
            person.gender = Console.ReadLine();
            
            Console.WriteLine(DatingProfile(person));

        }

        public static string DatingProfile(Person person)
        {
            StringBuilder strDescription = new StringBuilder("{0} likes to hike in the outdoors. Favorite team is the {1}. Ethnicity is {2}.");
            //string strDescription = "{0} likes to hike in the outdoors. Favorite team is the {1}. Ethnicity is {2}.";

            if(person.favoriteTeam == "s")
            {
                strDescription.Append(" Go SPURS GO");
                //strDescription += " Go SPURS GO";
            }else
            {
                strDescription.Append(" ROCKETS ROCK!!");
                //strDescription += " ROCKETS ROCK!!";
            }

            
            return string.Format(strDescription.ToString(), person.firstName, person.favoriteTeam, person.ethnicity);
        }


    }
}
