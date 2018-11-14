using System;

namespace Class
{
    class pratice
    {
        static void Main(string[] args)
        {
            Teams[] team = new Teams[2];
            team[0] = new Teams();
            team[1] = new Teams();
            for (int i = 0; i < 2; i++)
                team[i].team_details();
            players p1 = new players();
            p1.players_details();
            p1.display();
        }
    }
    class players
    {
        public string PlayerName;
        public int PlayerScore;
        public int TeamScore = 0;
        public int AverageScore = 0;
        int ManOfTheTeam = 0;
        string name;
        string ManOfTheTeam1;
        string ManOfTheTeam2;
        string ManOfTheMatch;
        Teams t2 = new Teams();

        public void players_details()
        {
            Console.WriteLine("Enter the name of the players ");
            PlayerName = Console.ReadLine();
            Console.WriteLine("Enter the score of " + PlayerName);
            PlayerScore = Convert.ToInt32(Console.ReadLine());


        }
        class Teams
    {
        public string TeamName;
        public int NoOfPlayers;
      
       
       
        public void team_details()
        {
            Console.WriteLine("Enter the name of the team");
            TeamName = Console.ReadLine();
            Console.WriteLine("Enter the no of players of the team" + TeamName);
            NoOfPlayers =int.Parse(Console.ReadLine());
           
            for (int i = 0; i < NoOfPlayers; i++)
            {
                player[i].players_details();
            }
           
           
        }
    }

   
       
           public  void display()
        {
            TeamScore += PlayerScore;
            AverageScore =( (TeamScore) / (t2.NoOfPlayers));
            Console.WriteLine("The total score of " + t2.TeamName + TeamScore);
            Console.WriteLine("The average score of " + t2.TeamName + AverageScore);

        
            for(int i=0;i<t2.NoOfPlayers; i++)
            {
                if(t[0].PlayerScore>ManOfTheTeam)
                {
                    
                    ManOfTheTeam= t2.player[i].PlayerName;

                }
            }
            for (int i = 0; i < t2.NoOfPlayers; i++)
            {
                if (t[1].PlayerScore > ManOfTheTeam)
                {

                    ManOfTheTeam = t2.player[i].PlayerName;

                }
            }

            if (ManOfTheTeam1 > ManOfTheTeam2)
                Console.WriteLine("The man of the match is " + ManOfTheTeam1);
            else
                Console.WriteLine("The man of the match is "  + ManOfTheTeam2);

        }

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class person
    {
        public string name;
        public int age;
    }
    class doctor : person
    {
        public string specialization;
        public string availability;
        public int specializationid;
        public void doctor_details()

        {
            Console.WriteLine(" name       " + "         age         " + "           specialization          " + "               availability          ");
            Console.WriteLine(" messi      " + "         31          " + "           Cardiologist           " + "                    a               ");
            Console.WriteLine(" arthur     " + "         22          " + "           dentist                " + "                    a              ");
            Console.WriteLine(" busqets    " + "         32         " + "           Allergist               " + "                    a               ");
        }
    }
    class patient : person
    {
        public string disease;
        public string DoctorAssigned;
        public void patient_details()
        {
            Console.WriteLine("Enter the patient name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age of the patient");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the patient disease");
            disease = Console.ReadLine();

            Console.WriteLine("PRESS 1 FOR HEART ISSUE");
            Console.WriteLine("PRESS 2 FOR TEETH ISSUE");
            Console.WriteLine("PRESS 2 FOR ALLERGIES ISSUE");
            public void patient_investigation()
            {
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        DoctorAssigned = "messi";
                        break;
                    case 2:
                        DoctorAssigned = "arthur";
                        break;
                    case 3:
                        DoctorAssigned = "busqets";
                        break;
                    default:
                        Console.WriteLine("Doctor is not available");
                        break;
                }
            }
        }
        public void display_details()
        {
            Console.WriteLine(" name         " + "          age         " + "           disease          ");
            Console.WriteLine(name + age + disease);
        }
    }
    class Hospital
    {

    }

    class HospitalAssignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO NO1 HOSPITAL. WE ARE ALWAYS WITH YOU.");
            Console.WriteLine("PRESS 1 FOR DOCTOR DETAILS.");
            Console.WriteLine("PRESS 2 FOR PATIENT DETAILS.");
            Console.WriteLine("PRESS 3 EXIT.");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        doctor d = new doctor();
                        d.doctor_details();

                        break;

                    }
                case 2:
                    {
                        patient p = new patient();
                        p.patient_details();
                        p.display_details();
                        patient p1 = new patient();
                        p1.patient_details();
                        p.display_details();
                        p1.display_details();

                        break;
                    }
                case 3:
                    break;
            }
            Console.Read();
        }
    }
}


