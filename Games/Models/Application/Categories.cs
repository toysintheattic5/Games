using System;
using System.Numerics;

namespace Games.API.Models.Application
{
    public static class Categories
    {
        public static Dictionary<int, string> Priority = new Dictionary<int, string>()
        {
            {0, "Undecided" },
            {1, "No, just no" },
            {2, "Prolly Not" },
            {3, "Could be fun though" },
            {4, "Sounds good" },
            {5, "Must play" },
            {6, "Forreals" },
            {7, "Seriously" },
            {8, "Before I die" }
        };

        public static Dictionary<int, string> Status = new Dictionary<int, string>()
        {
            { 0, "Not played" },
            { 1, "Won't play" },
            { 2, "Abandoned" },
            { 3, "Plan to play" },
            { 4, "Playing" },
            { 5, "On Hold" },
            { 6, "Completed"}
        };

        public static Dictionary<int, string> Perspective = new Dictionary<int, string>()
        {
            { 0, "Unknown" },
            { 1, "First Person" },
            { 2, "Third Person" },
            { 3, "Isometric" },
            { 4, "Top Down" },
            { 5, "Side Scroll" },
            { 6, "2D Platform" },
            { 7, "3D Platform" },
            { 8, "Strategic" },
            { 9, "2D" },
            { 10, "2.5D" }
        };

        public static Dictionary<int, string> TimePeriod = new Dictionary<int, string>()
        {
            { 0, "Unknown" },
            { 1, "Ancient" },
            { 2, "Medieval" },
            { 3, "Modern" },
            { 4, "Future" }
        };

        public static Dictionary<int, string> GeneralGenre = new Dictionary<int, string>()
        {
            { 0, "Unknown" },
            { 1, "RPG" },
            { 2, "Shooter" },
            { 3, "Tactics" },
            { 4, "Strategy" },
            { 5, "Survival" },
            { 6, "Adventure" },
            { 7, "Puzzle" },
            { 8, "Visual Novel" },
            { 9, "Walking Simulator" }
        };

        public static Dictionary<int, string> SpecificGenre = new Dictionary<int, string>()
        {
            { 0, "Unknown" },
            { 1, "ARPG" },
            { 2, "TRPG" },
            { 3, "SRPG" },
            { 4, "Party-Based RPG" },
            { 5, "Dungeon Crawler" },
            { 6, "Base Building" },
            { 7, "Tower Defense" },
            { 8, "Lane Defense" },
            { 9, "4X" },
            { 10, "Grand Strategy" }
        };

        public static Dictionary<int, string> GeneralTags = new Dictionary<int, string>()
        {
            { 0, "Unknown" },
            { 1, "Family Friendly" },
            { 2, "Action" },
            { 3, "Casual" },
            { 4, "Retro" },
            { 5, "Post-Apocalyptic" },
            { 6, "Mystery" },
            { 7, "Turn-Based" },
            { 8, "Real Time with Pause" },
            { 9, "Real Time" },
            { 10, "4X" },
            //{ 11, "Space" },
            { 12, "Mixed Genre" },
            { 13, "Mixed Setting" },
            { 14, "Mixed Perspective" },
            { 15, "Mixed Time Period" },
            { 17, "Wargame" },
            { 18, "World War I" },
            { 19, "World War II" }
        };

        public static Dictionary<int, string> Setting = new Dictionary<int, string>()
        {
            { 0, "Unknown" },
            { 1, "Mixed" },
            { 2, "Western Europe" },
            { 3, "Eastern Europe" },
            { 4, "Mediterranean" },
            { 5, "Africa" },
            { 6, "North Africa" },
            { 7, "Middle East" },
            { 8, "Asia" },
            { 9, "Southeast Asia" },
            { 10, "Russia" },
            { 11, "India" },
            { 12, "China" },
            { 13, "Japan" },
            { 14, "Pacific" },
            { 15, "South America" },
            { 16, "Australia" },
            { 17, "Antarctica" },
            { 18, "Central America" },
            { 19, "United States" },
            { 20, "Canada"},
            { 21, "Space" },
            { 22, "Mars" },
            { 23, "Moon" },
            { 24, "Hell" },
            { 25, "Fantasy World" },
            { 26, "Sci-Fi World" },
            { 27, "Alternate Dimension" },
            { 28, "Room" }
        };
    }
}
