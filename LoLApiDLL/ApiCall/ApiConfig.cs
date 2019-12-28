using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApiDll.ApiCall
{
    class ApiConfig
    {
        public static string ChallengerApiUrl = "https://euw1.api.riotgames.com/lol/league/v4/challengerleagues/by-queue/RANKED_SOLO_5x5";
        public static string SummonerApiUrl = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners/by-name/";
        public static string LeagueEntryApiUrl = "https://euw1.api.riotgames.com/lol/league/v4/entries/by-summoner/";
        public static string TftApiUrl = "https://euw1.api.riotgames.com/tft/league/v1/entries/by-summoner/";
        public static string MasteryApiUrl = "https://euw1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/";
        public static string ApiKey = System.IO.File.ReadAllText("C:\\Users\\Edd\\Desktop\\RiotApiKey.txt");
        
    }
}
