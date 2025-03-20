using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportsStatTracker.ClassesEnums
{
    public class Game
    {
        public enum Types
        {
            NA,
            LeagueOfLegends,
            Overwatch2,
            Rainbow6Siege,
            RocketLeague,
            SuperSmashBrosUltimate,
            Valorant
        }

        private Types Type;

        public Game()
        {
            Type = Types.NA;
        }

        public Game(Types type)
        {
            Type = type;
        }

        public Game(int type)
        {
            Type = (Types)type;
        }

        public Types GetTType()
        {
            return Type;
        }

        public string GetStringType()
        {
            switch (Type)
            {
                case Types.LeagueOfLegends:
                    return "League of Legends";
                case Types.Overwatch2:
                    return "Overwatch 2";
                case Types.Rainbow6Siege:
                    return "Rainbow 6: Siege";
                case Types.RocketLeague:
                    return "Rocket League";
                case Types.SuperSmashBrosUltimate:
                    return "SSBU";
                case Types.Valorant:
                    return "Valorant";
                default:
                    return string.Empty;
            }
        }

        public void SetTType(Types type)
        {
            Type = type;
        }

        public void SetIntType(int type)
        {
            Type = (Types)type;
        }
    }
}
