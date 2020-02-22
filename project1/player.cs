using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    public class Player
    {

        //Declarations

        public int playerId { get; set; }
        public string playerName { get; set; }
        public string school { get; set; }
        public double salary { get; set; }
        public string position { get; set; }
        public string rank { get; set; }

        internal object PlayerId { get; }

        public Player(int playerId, string playerName, string school, double salary, string position, string rank)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.school = school;
            this.salary = salary;
            this.position = position;
            this.rank = rank;

        }
        public Player(int playerId)
        {
            this.playerId = playerId;
        }
    }
}

