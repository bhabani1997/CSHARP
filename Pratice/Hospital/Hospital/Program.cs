using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        class Program
        {
           



            static string[] DN = new string[3];
            static string[] DS = new string[3];
            static string[] DA = new string[3];
            static string[] PN = new string[3];
            static int[] PA = new int[3];
            static string[] PC = new string[3];
            static int[] PI = new int[7];


            static void Main(string[] args)
            {

                DN[0] = "dembele";
                DN[1] = "umtitti";
                DN[2] = "suarez";

                DS[0] = "Cardiac electrophysiologist";
                DS[1] = "Allergist";
                DS[2] = "Colon and rectal surgeon";

                DA[0] = "A";
                DA[1] = "A";
                DA[2] = "A";

                PN[0] = "messi";
                PN[1] = "arthur ";
                PN[2] = "malcom";

                PA[0] = 31;
                PA[1] = 21;
                PA[2] = 22;

                PI[0] = 10;
                PI[1] = 8;
                PI[2] = 14;

                PC[0] = "cancer";
                PC[1] = "brain tumor";
                PC[2] = "fever";




                Console.WriteLine("WELCOME TO NO1 HOSPITAL.  WE ARE ALWAYS FOR YOU.");
                Console.WriteLine("PLEASE ENTER YOUR CHOICE");
                int choice;
                int new_choice = 0;
                int PID;
                Console.WriteLine("PRESS 1 FOR DOCTORS INFORMATION");
                Console.WriteLine("PRESS 2 FOR PATIENTS INFORMATION");
                Console.WriteLine("PRESS 3 EXIT");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("PRESS 1 FOR HEART ISSUES");
                    Console.WriteLine("Press 2 FOR ALLERGIES ISSUES");
                    Console.WriteLine("PRESS 3 FOR RECTUM ISSUES");
                    new_choice = Convert.ToInt32(Console.ReadLine());
                    switch (new_choice)
                    {
                        case 1:
                            Console.WriteLine("DOCTOR NAME                    DOCTOR SPECIALIZATION                             AVAILABILITY");
                            Console.WriteLine(DN[0] + "                           " + DS[0] + "                                          " + DA[0]);
                            break;
                        case 2:
                            Console.WriteLine("DOCTOR NAME                   DOCTOR SPECIALIZATION                              AVAILABILITY");
                            Console.WriteLine(DN[1] + "                           " + DS[1] + "                                          " + DA[1]);
                            break;
                        case 3:
                            Console.WriteLine("DOCTOR NAME                   DOCTOR SPECIALIZATION                              AVAILABILITY");
                            Console.WriteLine(DN[2] + "                           " + DS[2] + "                                          " + DA[2]);
                            break;
                        default:
                            Console.WriteLine("NO DOCTOR IS AVAILABLE");
                            break;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("PRESS 1 FOR ALL PATIENTS DETAILS");
                    Console.WriteLine("PRESS 2 FOR SPECIFIC PATIENTS DETAILS");
                    Console.WriteLine("PRESS 3 FOR NEW PATIENT DETAILS");
                    int PChoice = Convert.ToInt32(Console.ReadLine());

                    if (PChoice == 1)
                    {
                        Console.WriteLine("PATIENT NAME            PATIENT AGE               PATIENT CONDITION             PATIENT ID");
                        Console.WriteLine(" ");
                        for (int i = 0; i <= 2; i++)
                        {

                            Console.WriteLine(PN[i] + "                     " + PA[i] + "                             " + PC[i] + "                        " + PI[i]);
                        }
                    }
                    else if (PChoice == 2)
                    {
                        Console.WriteLine("TELL YOUR PATIENT ID");
                        PID = Convert.ToInt32(Console.ReadLine());
                        switch (PID)
                        {
                            case 1:
                                Console.WriteLine("PATIENT NAME            PATIENT AGE               PATIENT CONDITION                PATIENT ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(PN[0] + "                     " + PA[0] + "                             " + PC[0] + "                        " + PI[0]);
                                break;
                            case 2:
                                Console.WriteLine("PATIENT NAME            PATIENT AGE                PATIENT CONDITION              PATIENT ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(PN[1] + "                     " + PA[1] + "                             " + PC[1] + "                        " + PI[1]);
                                break;
                            case 3:
                                Console.WriteLine("PATIENT NAME          PATIENT AGE                 PATIENT CONDITION              PATIENT ID");
                                Console.WriteLine(" ");
                                Console.WriteLine(PN[2] + "                     " + PA[2] + "                             " + PC[2] + "                        " + PI[2]);
                                break;
                        }
                    }
                    else if (PChoice == 3)
                    {
                        Console.WriteLine("ENTER THE NEW PATIENTS NAME");
                        string NP1 = Console.ReadLine();
                        Console.WriteLine("ENTER THE NEW PATIENTS AGE");
                        int NPA1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ENTER the PATIENTS CONDITION");

                        Console.WriteLine("PRESS 1 FOR HEART ISSUES");
                        Console.WriteLine("Press 2 FOR ALLERGIES ISSUES");
                        Console.WriteLine("PRESS 3 FOR RECTUM ISSUES");
                        new_choice = Convert.ToInt32(Console.ReadLine());
                        switch (new_choice)
                        {
                            case 1:
                                Console.WriteLine("                 PATIENT REPORT");
                                Console.WriteLine("   ");
                                Console.WriteLine("PATIENT NAME:    " + NP1);
                                Console.WriteLine("PATIENT AGE:     " + NPA1);
                                Console.WriteLine("PATIENT CONDITION  " + " HEART ISSUES");
                                Console.WriteLine("   ");
                                Console.WriteLine("DOCTOR NAME                   DOCTOR SPECIALIZATION                            AVAILABILITY");
                                Console.WriteLine("   ");
                                Console.WriteLine(DN[0] + "                           " + DS[0] + "                                          " + DA[0]);
                                break;
                            case 2:
                                Console.WriteLine("                 PATIENT REPORT");
                                Console.WriteLine("  ");
                                Console.WriteLine("PATIENT NAME:    " + NP1);
                                Console.WriteLine("PATIENT AGE:     " + NPA1);
                                Console.WriteLine("PATIENT CONDITION  ALLERGIES ISSUES");
                                Console.WriteLine("   ");
                                Console.WriteLine("DOCTOR's NAME                    DOCTOR SPECIALIZATION                         AVAILABILITY");
                                Console.WriteLine("   ");
                                Console.WriteLine(DN[1] + "                           " + DS[1] + "                                          " + DA[1]);
                                break;
                            case 3:
                                Console.WriteLine("                  PATIENT REPORT");
                                Console.WriteLine("  ");
                                Console.WriteLine("PATIENT NAME: " + NP1);
                                Console.WriteLine("PATIENT AGE:     " + NPA1);
                                Console.WriteLine("PATIENT CONDITION RECTUM ISSUES");
                                Console.WriteLine("   ");
                                Console.WriteLine("DOCTOR's NAME                       DOCTOR SPECIALIZATION                         AVAILABILITY");
                                Console.WriteLine("   ");
                                Console.WriteLine(DN[2] + "                           " + DS[2] + "                                          " + DA[2]);
                                break;
                            default:
                                Console.WriteLine("NO DOCTOR IS AVAILABLE");
                                break;
                        }
                    }
                }
                else
                {
                    System.Environment.Exit(1);
                }
                Console.Read();
            }
        }
    
