using System;

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
                                        { "1", "Joe Burrow", "LSU", "26400100", "QB", "1"},
                                        { "2", "Tua Tagovailoa", "Alabama", "20300100", "QB", "2"},
                                        { "3", "Justin Herbet", "Oregon", "17420300", "QB", "3"},
                                        { "4", "Jordan Love", "Utah St", "13100145", "QB", "4"},
                                        { "5", "Jake Fromm", "Georgia", "10300000", "QB", "5"},
                                        { "6", "D,Andre Swift", "Georgia", "24500100", "RB", "1"}
                                    };



                //print roster list
                for (int i = 0; i < Roster.GetLength(0); i++) // loop
                {
                    Player aPlayer = new Player(Convert.ToInt32(Roster[i, 0]), Roster[i, 1], Roster[i, 2], Convert.ToDouble(Roster[i, 3]), Roster[i, 4], Roster[i, 5]);
                    Players.Add(aPlayer);
                    Console.WriteLine("Player ID:  " + Roster[i, 0] + " Player Name: " + Roster[i, 1] + " School: " + Roster[i, 2]);
                    Console.WriteLine(" Salary: " + Convert.ToDouble(Roster[i, 2]).ToString("c") + "Position: " + Roster[i, 4] + "Rank: " + Roster[i, 5] + "\n");
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

                        //Console.WriteLine("You picked" + selection + " who matches a player available on the roster: " + Roster[i, 0]);
                        //Console.WriteLine(value: "Good Choice! " + bPlayer.playerId + " " + bPlayer.playerName + "has been added to your draft picks list.");
                    }
                    else
                    { }
                }


                foreach (Player dDraftPick in PlayersChosen)
                {

                    Console.WriteLine(dDraftPick.playerId + " " + dDraftPick.playerName + " has been added to your draft picks list.");

                }

                Console.WriteLine("\nPress any key to draft another player, or Enter 'Q' to quit.\n");
                //	Console.WriteLine("\nSelect a player to remove from your draft picks: ");
                //remove player from pick list
                //	int r = Convert.ToInt32(Console.ReadLine());
                //	Console.WriteLine(r);
                //	PlayersChosen.RemoveAt(r);
                //}



                primer = Convert.ToString(Console.ReadLine().ToUpper());//primer to ask user to go again or exit program

            }

        }
    }
}
