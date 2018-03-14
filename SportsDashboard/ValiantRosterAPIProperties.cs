using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDashboard
{
    public class ValiantRosterAPIProperties
    {
        public int id { get; set; }
        public string handle { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string homeLocation { get; set; }
        public string primaryColor { get; set; }
        public string secondaryColor { get; set; }
        public string abbreviatedName { get; set; }
        public string addressCountry { get; set; }
        public string logo { get; set; }
        public string icon { get; set; }
        public List<Player> players { get; set; }
        public string secondaryPhoto { get; set; }
        public string aboutUrl { get; set; }
    }

    public class Player
    {
        public int id { get; set; }
        public List<string> availableLanguages { get; set; }
        public string handle { get; set; }
        public string name { get; set; }
        public string homeLocation { get; set; }
        public List<Account> accounts { get; set; }
        public string game { get; set; }
        public Attributes attributes { get; set; }
        public string attributesVersion { get; set; }
        public string familyName { get; set; }
        public string givenName { get; set; }
        public string nationality { get; set; }
        public string headshot { get; set; }
        public string aboutUrl { get; set; }
    }

    public class Account
    {
        public int id { get; set; }
        public int competitorId { get; set; }
        public string value { get; set; }
        public string accountType { get; set; }
        public bool isPublic { get; set; }
    }

    public class Hero
    {
        public string name { get; set; }
    }

    public class Attributes
    {
        public object hero_image { get; set; }
        public List<Hero> heroes { get; set; }
        public string hometown { get; set; }
        public int player_number { get; set; }
        public string preferred_slot { get; set; }
        public string role { get; set; }
    }
}
