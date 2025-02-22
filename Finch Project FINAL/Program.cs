﻿using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // ***************************************************
    //
    // Title: First Finch Program
    // Description: 
    // Application Type: Console
    // Author: Tanner McLean
    // Dated Created: 2/1/2020
    // Last Modified: 2/21/2021
    //
    // **************************************************

    class Program
    {

        ///  
        /// first method run when the app starts up
        ///  
        static void Main(string[] args)
        {

            SetTheme();

            DisplayWelcomeScreen();
            menuScreen();
            DisplayClosingScreen();
        }

        #region METHODS
        ///  
        /// setup the console theme
        ///  
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        ///  
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        ///  
        static void menuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch doofus = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        connectdoofus(doofus);
                        break;

                    case "b":
                        TalentShowmenuScreen(doofus);
                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectdoofus(doofus);
                        break;

                    case "q":
                        DisplayDisconnectdoofus(doofus);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitApplication);
        }

        #region TALENT SHOW

        ///  
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        ///  
        static void TalentShowmenuScreen(Finch doofus)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Movement Talent basic");
                Console.WriteLine("\tc) Play a song");
                Console.WriteLine("\td) Color calculator");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(doofus);
                        break;

                    case "b":
                        talentShowMovement(doofus);
                        break;

                    case "c":
                        talentShowSong(doofus);
                        break;

                    case "d":
                        colorCalc(doofus);
                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        continueScreen();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        static int colorCalc(Finch doofus)
        {


            bool validResponse;
            string user1;
            string user2;
            string user3;
            int RedVal;
            int GreenVal;
            int BlueVal;


            DisplayScreenHeader("Color Maker");
            Console.WriteLine("\t You will now be able to control the finch's light!");
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t Now please enter 3 valid values for Red, Green, and Blue values");
            Console.WriteLine();
            Console.WriteLine("\t Valid values are from 0 to 255");
            //user enters value 1
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 1 (Red), 0-255");
            #region Red
            do
            {
                validResponse = true;

                //
                //insert first number
                //
                Console.WriteLine();
                Console.Write($"\t Value 1: ");
                user1 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user1, out RedVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((RedVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: R value of: {RedVal}");

                    continueScreen();
                }

            } while (!validResponse);
            #endregion
            //
            // Value 2 for green
            //
            #region Green
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 2 (Green), 0-255");
            do
            {
                validResponse = true;

                //
                //insert second number
                //
                Console.WriteLine();
                Console.Write($"\t Value 2: ");
                user2 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user2, out GreenVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((GreenVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: G value of: {GreenVal}");
                    Console.WriteLine();

                    continueScreen();
                }

            } while (!validResponse);
            #endregion
            //
            // Value 3 for blue
            //
            #region Blue/table
            Console.WriteLine();
            Console.WriteLine("\t Please enter value 3 (Blue), 0-255");
            do
            {
                validResponse = true;

                //
                //insert third number
                //
                Console.WriteLine();
                Console.Write($"\t Value 3: ");
                user3 = Console.ReadLine();
                Console.WriteLine();

                if (!int.TryParse(user3, out BlueVal))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else if ((BlueVal >= 256))
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tPlease enter a number using digits from 0-255");
                    validResponse = false;
                }
                else
                {
                    Console.WriteLine($"\tYou entered: B value of: {GreenVal}");
                    Console.WriteLine();

                    continueScreen();
                }



                //
                //display values entered
                //

                //
                //Make the table
                //
                Console.WriteLine();
                Console.WriteLine("\tYour Values Entered:");
                Console.WriteLine(
                    "R".PadLeft(10) +
                    "G".PadLeft(10) +
                    "B".PadLeft(10)
                    );
                Console.WriteLine(
                   "---".PadLeft(10) +
                   "---".PadLeft(10) +
                   "---".PadLeft(10)
               ); ;
                //Line of user values
                Console.WriteLine(
                    RedVal.ToString().PadLeft(10) +
                    GreenVal.ToString().PadLeft(10) +
                    BlueVal.ToString().PadLeft(10)
                    );

            } while (!validResponse);
            continueScreen();
            #endregion

            //
            //Put it on the robot
            //
            Console.WriteLine();
            Console.WriteLine("\t Now I will put the colors to the robot!");
            continueScreen();
            doofus.setLED(RedVal, GreenVal, BlueVal);
            Console.WriteLine();
            Console.WriteLine("\t\t Ta-da!");
            continueScreen();
            calculateColor(RedVal, GreenVal, BlueVal);

            return RedVal + GreenVal + BlueVal;


        }


        static string calculateColor(int RedVal, int GreenVal, int BlueVal)
        {
            string color;
            //
            //Red value
            //
            if ((RedVal > GreenVal) || (RedVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Red");
                continueScreen();
            }

            //
            //Green value 
            //
            else if ((GreenVal > RedVal) || (GreenVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Green");
                continueScreen();
            }

            //
            //Blue Value
            //
            else if ((BlueVal > GreenVal) && (BlueVal > RedVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t From the colors you entered the color is mostly Blue");
                continueScreen();
            }


            //****************
            //Combo Colors
            //****************

            //
            //Red and blue
            //
            if ((RedVal > GreenVal) && (BlueVal > GreenVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your color should be close to a Purple hue or color");
                continueScreen();
            }
            //
            //Red and Green
            //
            if ((RedVal > BlueVal) && (GreenVal > BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be close to a Yellow hue or color");
                continueScreen();
            }
            //
            //Green and Blue
            //
            if ((GreenVal > RedVal) && (BlueVal > RedVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be close to a Cyan hue or color");
                continueScreen();
            }
            //
            //Color is just white
            //
            if (!((RedVal != GreenVal) || GreenVal != BlueVal))
            {
                Console.WriteLine();
                Console.WriteLine("\t Your Color should be a White color");
                continueScreen();
            }

            color = "blank";
            return color;






        }



        #region SONG
        //
        //talent show song
        //
        static void talentShowSong(Finch doofus)
        {
            DisplayScreenHeader("Song");
            Console.WriteLine();
            Console.WriteLine($"\t The Finch will now demonstrate a song!");
            continueScreen();
            Console.WriteLine();
            Console.WriteLine("\t The Song Of Storms from Legend of Zelda");
            doofus.setLED(0, 255, 0);
            //
            //song start
            //m1
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m2
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m3
            doofus.noteOn(1300);
            doofus.wait(750);
            doofus.noteOn(1380);
            doofus.wait(250);
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1380);
            doofus.wait(250);
            //m4
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1047);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            //m5
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //m6
            doofus.noteOn(880);
            doofus.wait(1500);
            doofus.noteOff();
            doofus.wait(100);
            //m7
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //m8
            doofus.noteOn(659);
            doofus.wait(1500);
            doofus.noteOff();
            doofus.wait(100);
            //m9
            doofus.noteOn(587);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m10
            doofus.noteOn(523);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(250);
            doofus.noteOn(1150);
            doofus.wait(1000);
            //m11
            doofus.noteOn(1300);
            doofus.wait(750);
            doofus.noteOn(1380);
            doofus.wait(250);
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1380);
            doofus.wait(250);
            //m12
            doofus.noteOn(1300);
            doofus.wait(250);
            doofus.noteOn(1047);
            doofus.wait(250);
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            //13
            doofus.noteOn(880);
            doofus.wait(500);
            doofus.noteOn(587);
            doofus.wait(500);
            doofus.noteOn(698);
            doofus.wait(250);
            doofus.noteOn(784);
            doofus.wait(250);
            //14
            doofus.noteOn(880);
            doofus.wait(1000);
            doofus.noteOff();
            doofus.wait(100);
            doofus.noteOn(880);
            doofus.wait(500);
            //m15
            doofus.noteOn(587);
            doofus.wait(3000);
            doofus.noteOff();
            doofus.setLED(0, 0, 0);

        }
        #endregion


        //
        // Talent show movement
        //
        static void talentShowMovement(Finch doofus)
        {
            DisplayScreenHeader("Movement");
            Console.WriteLine("\tThe Finch robot will not show its movement talent!");
            continueScreen();

            leftTurn(doofus);
            rightTurn(doofus);
            forwardMove(doofus);
            backwardMove(doofus);
            doofus.setMotors(0, 0);
            doofus.setLED(0, 0, 0);

        }
        #region Moves
        //
        //left turn
        //
        static void leftTurn(Finch doofus)
        {
            doofus.setLED(250, 0, 250);
            doofus.noteOn(880);
            doofus.setMotors(-100, 100);
            doofus.wait(650);
            doofus.setMotors(0, 0);
            doofus.noteOff();

        }

        //
        //right turn
        //
        static void rightTurn(Finch doofus)
        {
            doofus.setLED(0, 0, 255);
            doofus.noteOn(1000);
            doofus.setMotors(100, -100);
            doofus.wait(650);
            doofus.setMotors(0, 0);
            doofus.noteOff();
        }

        //
        //forward
        //
        static void forwardMove(Finch doofus)
        {
            doofus.setLED(0, 250, 0);
            doofus.setMotors(100, 100);
            doofus.wait(650);
            doofus.setLED(0, 0, 0);
        }

        //
        //backward
        //
        static void backwardMove(Finch doofus)
        {
            doofus.setLED(250, 0, 0);
            doofus.setMotors(-100, -100);
            doofus.wait(650);
            doofus.setMotors(0, 0);

        }
        #endregion

        #region TLightAndSound
        ///  
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        ///  
        /// 
        static void TalentShowDisplayLightAndSound(Finch doofus)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will now show its buzzer by playing a scale!!");
            continueScreen();
            for (int i = 0; i < 2; i++)
            {
                doofus.noteOn(523);
                doofus.wait(250);
                doofus.noteOn(587);
                doofus.wait(250);
                doofus.noteOn(659);
                doofus.wait(250);
                doofus.noteOn(698);
                doofus.wait(250);
                doofus.noteOn(784);
                doofus.wait(250);
                doofus.noteOn(880);
                doofus.wait(250);
                doofus.noteOn(988);
                doofus.wait(250);
                doofus.noteOn(1047);
                doofus.wait(500);
                doofus.noteOn(988);
                doofus.wait(250);
                doofus.noteOn(880);
                doofus.wait(250);
                doofus.noteOn(784);
                doofus.wait(250);
                doofus.noteOn(698);
                doofus.wait(250);
                doofus.noteOn(659);
                doofus.wait(250);
                doofus.noteOn(587);
                doofus.wait(250);
                doofus.noteOn(523);
                doofus.wait(250);
                doofus.noteOff();


            }



            DisplayMenuPrompt("Talent Show Menu");
        }
        #endregion

        #endregion

        #region FINCH ROBOT MANAGEMENT

        ///  
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        ///  
        /// 
        static void DisplayDisconnectdoofus(Finch doofus)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            continueScreen();

            doofus.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        ///  
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        ///  
        ///
        static bool connectdoofus(Finch doofus)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            continueScreen();

            robotConnected = doofus.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");
             
            //
            // reset finch robot
            //
            doofus.setLED(0, 0, 0);
            doofus.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        ///  
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        ///  
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            continueScreen();
        }

        ///  
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        ///  
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            continueScreen();
        }

        ///
        /// continue prompt
        ///
        static void continueScreen()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        /// 
        /// menu prompt
        /// 
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// 
        /// display screen header
        ///
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
        #endregion
    }
}
