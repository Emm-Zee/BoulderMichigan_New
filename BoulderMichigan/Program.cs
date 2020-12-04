using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//
//________________________________________________________________________________________
//________________________________________________________________________________________
//
//Title: Boulder Michigan
//Application Type: Console
//Description: Have people view services and book visits, classes, and memberships at an 
//             indoor climbing()facility
//Author: Emily Crull
//Date Created: November 22, 2020
//Last Modified:
//________________________________________________________________________________________
//________________________________________________________________________________________
//
//

namespace BoulderMichigan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Welcome());
        }
    }
}





/*

using System;



namespace BoulderMichigan
{
    class Program
    {
        static void Main(string[] args)
        {



            OpeningScreen();

        }

        #region OPENING SCREEN
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                     OPENING SCREEN
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void OpeningScreen()
        {
            Console.CursorVisible = false;


            DisplayHeader("Welcome to Boulder Michigan.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Continue();
            Console.Clear();
            MainMenu();
        }
        #endregion

        #region CONTINUE PROMPT
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                     CONTINUE PROMPT
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void Continue()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tcontinue to learn more.");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region RETURN TO MAIN MENU PROMPT
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                RETURN TO MAIN MENU PROMPT
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void ReturnToMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t[return to main menu.]");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region RETURN TO SERVICES MENU PROMPT
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                RETURN TO SERVICES MENU PROMPT
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void ReturnToServicesMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t[return to services]");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region RETURN TO MEMBERSHIPS MENU PROMPT
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                RETURN TO MEMBERSHIPS MENU PROMPT
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void ReturnToMembershipsMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t[return to memberships]");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region CLOSING SCREEN PROMPT
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                CLOSING SCREEN PROMPT
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        // Send user this message if they didn't book services

        static void ClosingScreenPrompt()
        {
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region DISPLAY HEADER
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                     DISPLAY HEADER
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void DisplayHeader(string headerText)
        {
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion

        #region MAIN MENU
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                     MAIN MENU
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void MainMenu()
        {

            bool quitApplication = false;
            string menuChoice;

            do
            {

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("\t[A] services");
                Console.WriteLine("\t[B] booking");
                Console.WriteLine("\t[C] FAQ");
                Console.WriteLine("\t[D] sign waiver");
                Console.WriteLine("\t[E] about");
                Console.WriteLine("\t[F] contact");
                Console.WriteLine("\t[G] login");
                Console.WriteLine("\t[H] leave");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tselect an option: ");
                menuChoice = Console.ReadLine().ToLower();


                switch (menuChoice)
                {
                    case "a":
                        Console.Clear();
                        ServicesMenu();
                        break;

                    case "b":
                        Console.Clear();
                        Booking();
                        break;

                    case "c":
                        Console.Clear();
                        FAQ();
                        break;

                    case "d":
                        Console.Clear();
                        SignWaiver();
                        break;

                    case "e":
                        Console.Clear();
                        AboutUs();
                        break;

                    case "f":
                        Console.Clear();
                        Contact();
                        break;

                    case "g":
                        Console.Clear();
                        Login();
                        break;

                    case "h":
                        quitApplication = true;
                        LeaveApplication();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("\t\t be sure to select from one of the menu options below: ");
                        Console.WriteLine();
                        break;
                }

            } while (!quitApplication);

            Console.Clear();


        }
        #endregion

        #region SERVICES MENU
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                     SERVICES MENU
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void ServicesMenu()
        {
            bool quitApplication = false;
            string menuChoice;

            do
            {
                Console.WriteLine();
                DisplayHeader("- services -");

                Console.WriteLine("\t[A] daily rates");
                Console.WriteLine("\t[B] memberships");
                Console.WriteLine("\t[C] group rates");
                Console.WriteLine("\t[D] classes");
                Console.WriteLine("\t[E] specials");
                Console.WriteLine("\t[F] equipment rental");
                Console.WriteLine("\t[G] fitness lab");
                Console.WriteLine("\t[H] return to main menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tselect an option: ");
                menuChoice = Console.ReadLine().ToLower();



                switch (menuChoice)
                {
                    case "a":
                        Console.Clear();
                        DailyRates();
                        break;

                    case "b":
                        Console.Clear();
                        MembershipMenu();
                        break;

                    case "c":
                        Console.Clear();
                        GroupRates();
                        break;

                    case "d":
                        Console.Clear();
                        ClassesMenu();
                        break;

                    case "e":
                        Console.Clear();
                        Specials();
                        break;

                    case "f":
                        Console.Clear();
                        EquipmentRentalMenu();
                        break;

                    case "g":
                        Console.Clear();
                        FitnessLab();
                        break;

                    case "h":
                        Console.Clear();
                        MainMenu();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("\t\t be sure to select from one of the menu options below: ");
                        Console.WriteLine();
                        break;
                }

            } while (!quitApplication);
        }

        #endregion

        #region DAILY RATES
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                      DAILY RATES
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void DailyRates()
        {

            DisplayHeader("- daily rates -");
            DisplayHeader(" ½ DAY");
            Console.WriteLine("\t• ½ Day: $20");
            Console.WriteLine("\t• ½ Day [students, youth, military, seniors]: $15");
            Console.WriteLine();
            DisplayHeader(" FULL DAY");
            Console.WriteLine("\t• Daily: $35");
            Console.WriteLine("\t• Daily [couples]: $60");
            Console.WriteLine("\t• Daily [students, youth, military, seniors]: $25");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t- -   10 Pass special: $220   - -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToServicesMenu();
            ServicesMenu();

        }
        #endregion

        #region MEMBERSHIP MENU
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                               MEMBERSHIP MENU
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void MembershipMenu()
        {
            bool quitApplication = false;
            string menuChoice;

            Console.WriteLine();
            do
            {
                DisplayHeader("- memberships -");

                Console.WriteLine("\t[A] monthly");
                Console.WriteLine("\t[B] annual");
                Console.WriteLine("\t[C] return to services");
                Console.WriteLine("\t[D] return to main menu");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t\tselect an option: ");
                menuChoice = Console.ReadLine().ToLower();



                switch (menuChoice)
                {
                    case "a":
                        Console.Clear();
                        MonthlyMemberships();
                        break;

                    case "b":
                        Console.Clear();
                        YearlyMemberships();
                        break;

                    case "c":
                        Console.Clear();
                        ServicesMenu();
                        break;

                    case "d":
                        Console.Clear();
                        MainMenu();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("\t\t be sure to select from one of the menu options below: ");
                        Console.WriteLine();
                        break;
                }

            } while (!quitApplication);
        }

        #endregion

        #region MONTHLY MEMBERSHIPS
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                           MONTHLY MEMBERSHIPS
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void MonthlyMemberships()
        {
            DisplayHeader("[[monthly memberships]]");
            DisplayHeader("- individuals -");
            Console.WriteLine("\t\t$75 [adults]");
            Console.WriteLine("\t\t$60 [students, youth, military, or seniors]");
            Console.WriteLine();
            DisplayHeader("- couples -");
            Console.WriteLine("\t\t$125");
            Console.WriteLine();
            DisplayHeader("- family memberships -");
            Console.WriteLine("\t\t$170 [3 members]");
            Console.WriteLine("\t\t$200 [4 members]");
            Console.WriteLine("\t\t$220 [5 members]");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t+ perks of monthly memberships include +");
            Console.WriteLine("\t\taccess to fitness lab");
            Console.WriteLine("\t\tmassage chairs"); 
            Console.WriteLine();
            ReturnToMembershipsMenu();
            MembershipMenu();
        }

        #endregion

        #region ANNUAL MEMBERSHIPS
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                  ANNUAL MEMBERSHIPS
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        static void YearlyMemberships()
        {
            DisplayHeader("[[annual memberships]]");
            DisplayHeader("- individuals -");
            Console.WriteLine("\t\t $750");
            Console.WriteLine("\t\t $650 [students, youth, military, or seniors]");
            Console.WriteLine();
            DisplayHeader("- couples -");
            Console.WriteLine("\t\t$1200");
            Console.WriteLine();
            DisplayHeader("- family memberships -");
            Console.WriteLine("\t\t$1600 [3 members]");
            Console.WriteLine("\t\t$1900 [4 members]");
            Console.WriteLine("\t\t$2100 [5 members]");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t+ perks of annual memberships include +");
            Console.WriteLine("\t\taccess to fitness lab");
            Console.WriteLine("\t\tmassage chairs");
            Console.WriteLine("\t\t1 private lesson for each member");
            Console.WriteLine();
            ReturnToMembershipsMenu();
            MembershipMenu();
        }

        #endregion

        #region GROUP RATES
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                               GROUP RATES MENU
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void GroupRates()
        {
            DisplayHeader("- group rates -");
            Console.WriteLine();
            Console.WriteLine("\tGroups up to 10 people");
            Console.WriteLine("\t$25 per person per day");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tGroups of more than 10 people");
            Console.WriteLine("\t$20 per person per day");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToServicesMenu();
            ServicesMenu();
        }
        #endregion

        #region CLASSES

        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                      CLASSES
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void ClassesMenu()
        {

            DisplayHeader("- classes -");
            Console.WriteLine();
            Console.WriteLine("\t\tBOULDER 101");
            Console.WriteLine("\t-------------------------------------");
            Console.WriteLine("\t     [lasts approx. 2 hours]");
            Console.WriteLine();
            Console.WriteLine("\t - includes day pass and equipment ");
            Console.WriteLine("\t - limit 6 per class");
            Console.WriteLine();
            Console.WriteLine("\t\t  $80");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToServicesMenu();
            ServicesMenu();
        }

        #endregion

        #region SPECIALS

        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                      SPECIALS
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void Specials()
        {
            DisplayHeader("   - specials -");
            Console.WriteLine();
            Console.WriteLine("\t\t MONDAYS & TUESDAYS");
            Console.WriteLine("\t\t----------------------");
            Console.WriteLine("\t\t   $10: half day");
            Console.WriteLine("\t\t   $15; full day");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToServicesMenu();
        }

        #endregion

        #region EQUIPMENT RENTAL
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                   EQUIPMENT RENTAL
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void EquipmentRentalMenu()
        {
            DisplayHeader("\t   - equipment rental -");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tSHOE RENTAL");
            Console.WriteLine("\t\t---------------------------------------");
            Console.WriteLine("\t\t\t\t$10 [adults]");
            Console.WriteLine("\t\t $5 [students, youth, military, seniors]");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\tBAG OF CHALK");
            Console.WriteLine("\t\t\t--------------------------");
            Console.WriteLine("\t\t\t\t$2");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToServicesMenu();
        }

        #endregion

        #region FITNESS LAB
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                   FITNESS LAB RATES
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void FitnessLab()
        {
            DisplayHeader("- fitness lab -");
            DisplayHeader(" DAILY");
            Console.WriteLine("\t$10");
            Console.WriteLine();
            DisplayHeader("MONTHLY");
            Console.WriteLine("\t$30");
            Console.WriteLine();
            DisplayHeader("ANNUALLY");
            Console.WriteLine("\t$250");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToServicesMenu();
        }
        #endregion

        #region BOOKING
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                       BOOKING MENU
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void Booking()
        {
            DisplayHeader("- booking -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tcurrently under construction...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToMainMenu();
            
        }
        #endregion

        #region INDIVIDUAL BOOKING
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                       INDIVUDAL BOOKING
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        #endregion

        #region COUPLE BOOKING
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                      COUPLES BOOKING
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        #endregion

        #region FAMILY BOOKING
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                      FAMILY BOOKING
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        #endregion

        #region GROUP BOOKING
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                      GROUP BOOKING
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        #endregion

        #region CLASS BOOKING
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                      CLASS BOOKING
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        #endregion

        #region FITNESS LAB BOOKING
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                   FITNESS LAB BOOKING
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        #endregion

        #region CONTACT US
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                        CONTACT US
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void Contact()
        {
            DisplayHeader("- contact us -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tcurrently under construction...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToMainMenu();
        }
        #endregion

        #region ABOUT US
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                        ABOUT US
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void AboutUs()
        {
            DisplayHeader("- about -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tcurrently under construction...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToMainMenu();
        }



        #endregion

        #region WAIVER
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                           WAIVER
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void SignWaiver()
        {
            DisplayHeader("- waiver -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tcurrently under construction...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToMainMenu();
        }
        #endregion

        #region FAQ
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                           FAQ
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //

        static void FAQ()
        {
            DisplayHeader("- FAQ -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tcurrently under construction...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToMainMenu();
        }
        #endregion

        #region LOGIN

        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                                        LOGIN
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void Login()
        {
            DisplayHeader("- booking -");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tcurrently under construction...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ReturnToMainMenu();
        }
        #endregion

        #region LEAVE APPLICATION (CLOSING SCREEN)
        //
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //                            LEAVE APPLICATION (CLOSING SCREEN)
        //________________________________________________________________________________________
        //________________________________________________________________________________________
        //
        //
        static void LeaveApplication()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(); 
            DisplayHeader("looking forward to seeing you soon!");
            Console.ReadKey();
            Console.Clear();
        }
        #endregion


    }
}
*/