using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static int choice;
        

        static void Main(string[] args)
        {

            void Doc_DB()
            {
                string[] DN = new string[3];
                string[] DA = new string[3];
                string[] DS = new string[3];
                Console.WriteLine("Enter Details for Doctors");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter Doctor Name");
                    DN[i] = Console.ReadLine();

                    Console.WriteLine("Enter Doctor Availability");
                    DA[i] = Console.ReadLine();


                    Console.WriteLine("Enter Doctor Specialization.");
                    DS[i] = Console.ReadLine();
                }
            }

            void Pat_DB()
            {
                 string[] PN = new string[3];
                 int[] PA = new int[3];
                 string[] PP = new string[3];
                 int[] PI = new int[3];
                Console.WriteLine("Enter Details for Patient");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter Patient Name");
                    PN[i] = Console.ReadLine();

                    Console.WriteLine("Enter Patient Age");
                    PA[i] = int.Parse(Console.ReadLine());


                    Console.WriteLine("Enter Patient ID");
                    PI[i] = int.Parse(Console.ReadLine());


                    Console.WriteLine("Enter Patient Problem.");
                    PP[i] = Console.ReadLine();
                }
            }


            Console.WriteLine("WELCOME TO NO1 HOSPITAL");
            Console.WriteLine("ENTER 1 TO CHECK THE DETAILS OF DOCTOr");
            Console.WriteLine("ENTER 2 TO CHECK THE DETAILS OF PATIENT");
            Console.WriteLine("ENTER 3 TO CHECK THE DETAILS OF NEW PATIENTS");
            Console.WriteLine("ENTER 4 TO EXIT");
            choice = Convert.ToInt32(Console.ReadLine());
           if(choice==1)
            {
                Doc_DB();
            }
           else if(choice==2)
            {
                Pat_DB();
            }
           /* switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome to doctors Database.");
                    Console.WriteLine("Doctor's Name                  Doctor's specialization                           Availability");
                    Console.WriteLine(DN[0] + "                         " + DS[0] + "                                        " + DA[0]);
                    Console.WriteLine(DN[1] + "                         " + DS[1] + "                                        " + DA[1]);
                    Console.WriteLine(DN[2] + "                         " + DS[2] + "                                        " + DA[2]);
                    Console.ReadLine();
            
                  break;

                case 2:
                    Console.WriteLine("Welcome to patients Database.");
                    int pat=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Patient's Name            Patient's Age               Patient's Problem              Patient's ID");
                    Console.WriteLine(PN[pat] + "                  " + PA[pat] + "               " + PP[pat - 1] + "                  " + PI[pat - 1]);
                   
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter the Patiemts Name");
                    string Newpatient1 = Console.ReadLine();
                    Console.WriteLine("Enter the Patiemts Age");
                    int NewpatientAge1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Patiemts Problem");

                    Console.WriteLine("Press 1 for Skin Issues");
                    Console.WriteLine("Press 2 for Heart Issues");
                    Console.WriteLine("Press 3 for Bone Issues");
                    DSelection = Convert.ToInt32(Console.ReadLine());
                    switch (DSelection)
                    {
                        case 1:
                            Console.WriteLine("                 Patients REport");
                            Console.WriteLine("   ");
                            Console.WriteLine("Patients Name:    " + Newpatient1);
                            Console.WriteLine("Patients Age:     " + NewpatientAge1);
                            Console.WriteLine("Patients Problem  " + "Skin Issue");
                            Console.WriteLine("   ");
                            Console.WriteLine("Doctor's Name                    Doctor's specialization                             Availability");
                            Console.WriteLine("   ");
                            Console.WriteLine(DoctorName[1] + "                           " + DoctorSpecialization[1] + "                                          " + DoctoesAvailibility[1]);
                            break;
                        case 2:
                            Console.WriteLine("                 Patients REport");
                            Console.WriteLine("  ");
                            Console.WriteLine("Patients Name:    " + Newpatient1);
                            Console.WriteLine("Patients Age:     " + NewpatientAge1);
                            Console.WriteLine("Patients Problem  Heart Problem");
                            Console.WriteLine("   ");
                            Console.WriteLine("Doctor's Name                    Doctor's specialization                             Availability");
                            Console.WriteLine("   ");
                            Console.WriteLine(DoctorName[0] + "                           " + DoctorSpecialization[0] + "                                          " + DoctoesAvailibility[0]);
                            break;
                        case 3:
                            Console.WriteLine("                 Patients REport");
                            Console.WriteLine("  ");
                            Console.WriteLine("Patients Name: " + Newpatient1);
                            Console.WriteLine("Patients Age:     " + NewpatientAge1);
                            Console.WriteLine("Patients Problem  " + "Bone Issue");
                            Console.WriteLine("   ");
                            Console.WriteLine("Doctor's Name                    Doctor's specialization                             Availability");
                            Console.WriteLine("   ");
                            Console.WriteLine(DoctorName[2] + "                           " + DoctorSpecialization[2] + "                                         

                    Console.WriteLine("Welcome to new patients Database.");
                    break; */
                    Console.ReadLine();
            }

        }
    }



