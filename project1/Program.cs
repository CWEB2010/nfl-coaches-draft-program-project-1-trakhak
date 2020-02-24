using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declarations		
            String primer; //priming value


            //player objects delcared in a list
            List<Player> Players = new List<Player>();
            List<Player> PlayersChosen = new List<Player>();
            //welcome screen
            Console.WriteLine("\nWelcome to the draft.");
            Console.WriteLine("\nIf you wish to exit at any time, type 'Q', then enter. \n\nWhat is your name?\n");

            primer = Convert.ToString(Console.ReadLine());//primer

            Console.WriteLine("\n" + primer + "\n\n ENTER PLAYER ID TO DRAFT\n" +
                "\n                             Player List\n");

            while (primer != "Q")
            {

                String[,] Roster =  {
                                        { "1", "Joe Burrow", "LSU", "26400100", "Quaterback", "1"},
                                        { "2", "Tua Tagovailoa", "Alabama",  "20300100", "Quaterback", "2"},
                                        { "3", "Justin Herbet", "Oregon", "17420300", "Quaterback", "3"},
                                        { "4", "Jordan Love", "Utah St", "13100145", "Quaterback", "4"},
                                        { "5", "Jake Fromm", "Georgia", "10300000", "Quaterback", "5"},
                                        { "6", "D,Andre Swift", "Georgia", "24500100", "Running Back", "1"},
                                        { "7", "Jonathan Taylor", "Wiscosnsin", "19890200", "Running Back", "2"},
                                        { "8", "J.K. Dobbins", "Ohio St", "18700800", "Running Back", "3"},
                                        { "9", "Zack Moss", "Utah", "15000000", "Running Back", "4"},
                                        { "10", "Cam Akers", "Florida St", "11600400", "Running Back", "5"},
                                        { "11", "CeeDee Lamb", "Oklahoma", "23400000", "Wide Receiver", "1"},
                                        { "12", "Jerry Jeudy", "Alabama", "21900300", "Wide Receiver", "2"},
                                        { "13", "Tee Higgins", "Clemson", "19300230", "Wide Receiver", "3"},
                                        { "14", "Hunry Rugs III", "Alabama", "13400230", "Wide Receiver", "4"},
                                        { "15", "Tyler Johnson", "Minnesota", "10000000", "Wide Receiver", "5"},
                                        { "16", "Chase Young", "Ohio St", "26200300", "Defensive Lineman", "1"},
                                        { "17", "Derrick Brown", "Auburn", "22000000", "Defensive Lineman", "2"},
                                        { "18", "A.J. Epenesa", "Iowa", "16000000", "Defensive Lineman", "3"},
                                        { "19", "Javon Kinlaw", "So. Carolina", "18000000", "Defensive Lineman", "4"},
                                        { "20", "Yetur Gross-Matos", "Penn St", "13000000", "Defensive Lineman", "5"},
                                        { "21", "Jeff Okudah", "Ohio St", "24000000", "Defensive-Back", "1"},
                                        { "22", "Grant Delpit", "LSU", "22500249", "Defensive-Back", "2"},
                                        { "23", "Kristian Fulton", "LSU", "20000100", "Defensive-Back", "3"},
                                        { "24", "Xavier MCKinney", "Alabama", "16000200", "Defensive-Back", "4"},
                                        { "25", "CJ Henderson", "Florida", "11899999", "Defensive-Back", "5"},
                                        { "26", "Cole Kmet", "Notre Dame", "27800900", "Tight Ends", "1"},
                                        { "27", "Brycen Hopkins", "Purdue", "21000800", "Tight Ends", "2"},
                                        { "28", "Hunter Bryant", "Washington", "17499233", "Tight Ends", "3"},
                                        { "29", "Jared Pinkey", "Vanderbilt", "27900200", "Tight Ends", "4"},
                                        { "30", "Jacaob Breeland", "Oregon", "149000333", "Tight Ends", "5"},
                                        { "31", "Isaiah Simmons", "Clemson", "22900300", "Line Backers", "1"},
                                        { "32", "Kenneth Murray", "Oklahoma", "19000590", "Line Backers", "2"},
                                        { "33", "Zack Baun", "Wisconsin", "180000222", "Line Backers", "3"},
                                        { "34", "Akeem Davis-Gaither", "App. St.", "12999999", "Line Backers", "4"},
                                        { "35", "Troy Dye", "Oregon", "10001100", "Line Backers", "5"},
                                        { "36", "Jedrick Will Jr.", "Alabama", "23000000", "Offensive Tackles", "1"},
                                        { "37", "Andrew Thomas", "Georgia", "20000000", "Offensive Tackles", "2"},
                                        { "39", "Tyler Biadasz", "Wisconsin", "16200700", "Offensive Tackles", "4"},
                                        { "40", "Mekhi Becton", "Louisville", "15900000", "Offensive Tackles", "5"}
                                    };



                //print roster list
                for (int i = 0; i < Roster.GetLength(0); i++) // loop
                {
                    Player aPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Roster[i, 2], Convert.ToDouble(Roster[i, 3]), Roster[i, 4], Roster[i, 5]);
                    Players.Add(aPlayer);
                    Console.WriteLine("Player ID:  " + Roster[i, 0] + " Player Name: " + Roster[i, 1] + " School: " + Roster[i, 2] + " Salary: " + Convert.ToDouble(Roster[i, 3]).ToString("c") + " Position: " + Roster[i, 4] + " Rank: " + Roster[i, 5] + "\n");
                }// end loop

                Console.WriteLine("\nEnter player ID number\n");

                string selection = Console.ReadLine();


                //multi array list
                for (int i = 0; i < Roster.GetLength(0); i++) //]loop control rows
                {

                    if (selection == Roster[i, 0])
                    {
                        Player bPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Roster[i, 2], Convert.ToDouble(Roster[i, 3]), Roster[i, 4], Roster[i, 5]);
                        PlayersChosen.Add(bPlayer);
                    }
                    else
                    { }
                }


                foreach (Player dDraftPick in PlayersChosen)
                {

                    Console.WriteLine(dDraftPick.playerId + " " + dDraftPick.playerName + " has been added to your draft picks list.");

                }

                Console.WriteLine("\nPress any key to draft another player, or Enter 'Q' to quit.\n");




                primer = Convert.ToString(Console.ReadLine().ToUpper());//primer to ask user to go again or exit program

            }

        }
    }
}
