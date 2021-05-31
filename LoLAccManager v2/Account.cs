using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;

namespace LoLAccManager_v2
{
    public class Account
    {
        public string accountRegion
        {
            get;
            set;
        }

        public string accountUsername
        {
            get;
            set;
        }

        public string accountPassword
        {
            get;
            set;
        }

        public string accountIGN
        {
            get;
            set;
        }

        public string accountRank
        {
            get;
            set;
        }

        public string accountWinrate
        {
            get;
            set;
        }

        public static async Task<string> GetAsync(string uri)
        {
            HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(uri);
            obj.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using HttpWebResponse response = (HttpWebResponse)(await obj.GetResponseAsync());
            using Stream stream = response.GetResponseStream();
            using StreamReader reader = new StreamReader(stream);
            return await reader.ReadToEndAsync();
        }

        public static List<Account> LoadAccounts()
        {
            var riotApi = RiotApi.NewInstance("RGAPI-YOURKEYHERE");
            List<Account> list = new List<Account>();
            
            using (StreamReader reader = File.OpenText("accountData.json"))
            {
                using JsonTextReader reader2 = new JsonTextReader(reader);
                Add.Global.jArray = (JArray)JToken.ReadFrom(reader2);
            }
            foreach (JToken item in Add.Global.jArray)
            {
                Account account = new Account(item.ToString());
                string ingame = account.accountIGN;
                string rank = string.Empty;
                string winrate = string.Empty;
                string region = account.accountRegion.ToString();
                // This is terrible. I mean it works, sure... But it's ugly and bad practice.
                if (region == "EUW")
                {
                    
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.EUW, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.EUW, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            int W = rankedStats[0].Wins;
                            int L = rankedStats[0].Losses;
                            int WR = (W / (W + L))*100;
                            string WRs = " (" + WR.ToString() + "%)";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "NA")
                {
                    
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.NA, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.NA, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "EUNE")
                {
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.EUNE, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.EUNE, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "BR")
                {
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.LAN, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.LAN, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "LAN")
                {
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.LAN, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.LAN, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "LAS")
                {
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.LAS, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.LAS, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "OCE")
                {
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.OCE, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.OCE, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "RU")
                {
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.RU, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.RU, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }
                else if (region == "TR")
                {
                    try
                    {
                        var summonerInfo = riotApi.SummonerV4.GetBySummonerName(Region.TR, ingame);
                        var rankedStats = riotApi.LeagueV4.GetLeagueEntriesForSummoner(Region.TR, summonerInfo.Id);
                        if (rankedStats[0].QueueType != "RANKED_SOLO_5x5")
                        {
                            // set properties 
                            string Tier = rankedStats[1].Tier;
                            string Rank = rankedStats[1].Rank;
                            string Wins = rankedStats[1].Wins.ToString();
                            string Losses = rankedStats[1].Losses.ToString();
                            string LP = rankedStats[1].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }
                        else
                        {
                            // set properties 
                            string Tier = rankedStats[0].Tier;
                            string Rank = rankedStats[0].Rank;
                            string Wins = rankedStats[0].Wins.ToString();
                            string Losses = rankedStats[0].Losses.ToString();
                            string LP = rankedStats[0].LeaguePoints.ToString();
                            rank = Tier + " " + Rank + " | " + LP + "LP";
                            winrate = Wins + "W" + " | " + Losses + "L";

                            // add user to grid
                            account.accountRank = rank;
                            account.accountWinrate = winrate;
                            list.Add(account);
                        }

                    }
                    catch
                    {
                        string Tier = "Unranked";
                        rank = Tier;
                        winrate = "N/A";

                        // add user to grid
                        account.accountRank = rank;
                        account.accountWinrate = winrate;
                        list.Add(account);
                    }
                }

            /// ABOVE                
            }
            return list;
        }

        public Account()
        {

        }

        public Account(string json)
        {
            JObject jObject = JObject.Parse(json);
            accountRegion = jObject["accountRegion"]!.ToString();
            accountUsername = jObject["accountUsername"]!.ToString();
            accountPassword = jObject["accountPassword"]!.ToString();
            accountIGN = jObject["accountIGN"]!.ToString();
            accountRank = jObject["accountRank"]!.ToString();
            accountWinrate = jObject["accountWinrate"]!.ToString();
        }

    }
}
