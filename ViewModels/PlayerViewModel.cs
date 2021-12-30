using System.Collections.ObjectModel;
using ReactiveUI;

using Sample.Models;


namespace Sample.ViewModels
{
    public class PlayerViewModel : ReactiveUI.ReactiveObject
    {
        private static int PLAYER_COUNT = 15;

        public List<Player> Players { get; set; }

        public Player SelectedPlayer { get; set; }

        public PlayerViewModel()
        {
            Console.WriteLine("Creating players");
            Players = new List<Player>();
            for (int i = 0; i < PLAYER_COUNT; i++)
            {
                Players.Add(new Player($"Player {i + 1}", 0));
            }
        }
    }
}