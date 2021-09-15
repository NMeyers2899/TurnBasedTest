using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{ 
    public class Game
    {
        // Initalizes the player.
        Player player = new Player();

        private bool gameOver = false;

        Unit[] unitList;

        private int currentScene = 0;


        public void Run()
        {
            Start();

            while (!gameOver)
            {
                Update();
            }

            End();
        }

        /// <summary>
        /// Initializes everything that should be initalized before the start of the game.
        /// </summary>
        private void Start()
        {
            // Initializes the stats for Ivan.
            Unit ivan = new Unit("Ivan", 25, 10, 5, 0);

            // Initalizes the stats for a soldier.
            Unit soldier = new Unit("Soldier", 10, 8, 3, 2);

            // Initializes the stats for a ruffian.
            Unit ruffian = new Unit("Ruffian", 15, 12, 2, 2);

            // Initalizes the stats for an archer.
            Unit archer = new Unit("Archer", 8, 10, 3, 2);

            // Initalizes the stats for a cleric.
            Unit cleric = new Unit("Cleric", 6, 0, 2, 3);

            // Initalizes the stats for an assassin.
            Unit shadowstepper = new Unit("Shadowstepper", 8, 10, 2, 3);

            unitList = new Unit[] { ivan, soldier, ruffian, archer, cleric, shadowstepper };
        }


        /// <summary>
        /// Changes the information of the game.
        /// </summary>
        private void Update()
        {
            Console.Clear();
            UpdateScene();
        }

        private void End()
        {
            Console.WriteLine("Goodbye!");
        }

        /// <summary>
        /// Changes the scenes in the game.
        /// </summary>
        private void UpdateScene()
        {
            switch (currentScene)
            {
                case 0:
                    DisplayStartMenu();
                    break;
                case 1:
                    break;
                case 2:
                    DisplayUnitMenu();
                    break;
            }
        }

        /// <summary>
        /// Gets the user's input on a given topic, giving them two options to choose from.
        /// </summary>
        /// <param name="description"> The description of the choice. </param>
        /// <param name="option1"> The first option. </param>
        /// <param name="option2"> The second option. </param>
        /// <param name="option3"> The third option. </param>
        /// <param name="pauseInvalid"> Pauses the game if the choice was invalid. </param>
        /// <returns> The number assigned to the made choice if it was valid. </returns>
        private int GetInput(string description, string option1, string option2, string option3, 
            bool pauseInvalid = false)
        {
            // The choice given to the user.
            Console.Write(description + "\n1. " + option1 + "\n2. " + option2 + "\n3. " + option3 + "\n> ");

            // Gets player input.
            string input = Console.ReadLine().ToLower();
            int choice = 0;

            if (input == "1")
            {
                choice = 1;
            }
            else if (input == "2")
            {
                choice = 2;
            }
            else if(input == "3")
            {
                choice = 3;
            }
            else
            {
                Console.WriteLine("Invalid Input");

                if (pauseInvalid)
                {
                    Console.ReadKey(true);
                }
            }

            // Returns the player's choice.
            return choice;
        }

        /// <summary>
        /// Displays the start menu from which the player can start a battle, change their army, or quit 
        /// the game.
        /// </summary>
        private void DisplayStartMenu()
        {
            int choice = GetInput("Welcome to the Turn Based Test!", "Start Battle", "Change Squad", "Quit");

            switch (choice)
            {
                case 1:
                    currentScene = 1;
                    break;
                case 2:
                    currentScene = 2;
                    break;
                case 3:
                    gameOver = true;
                    break;
            }
        }

        /// <summary>
        /// Displays the menu that allows the player to check their squad's stats and change the units in
        /// their squad.
        /// </summary>
        private void DisplayUnitMenu()
        {
            int choice = GetInput("What would you like to do?", "Change Unit", "Check Squad Stats", "Go Back");

            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    DisplayUnitStats();
                    break;
                case 3:
                    currentScene = 0;
                    break;
            }
        }

        /// <summary>
        /// Gets the position the player wishes to change, and what change they'd like to make to it.
        /// </summary>
        private void ChangeUnit()
        {

        }

        /// <summary>
        /// Displays the units stats in a squad.
        /// </summary>
        private void DisplayUnitStats()
        {
            Console.Clear();

            for(int i = 0; i < player.PlayerArmy.Length ; i++)
            {
                Console.WriteLine("Name: " + player.PlayerArmy[i].Name);
                Console.WriteLine("Health: " + player.PlayerArmy[i].Health);
                Console.WriteLine("Attack: " + player.PlayerArmy[i].AttackPower);
                Console.WriteLine("Defense: " + player.PlayerArmy[i].DefensePower);
                Console.WriteLine();

                if(i == 4 || i == 9 || i == 14)
                {
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
        }

        /// <summary>
        /// Displays the current list of unlocked units.
        /// </summary>
        private void DisplayUnitList()
        {
            foreach (Unit unitName in unitList)
            {
                Console.WriteLine(unitName.Name);
            }
        }
    }
}
