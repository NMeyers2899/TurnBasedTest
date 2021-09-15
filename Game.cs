﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{ 
    class Game
    {

        private bool gameOver = false;

        Unit[] unitList;

        private int currentScene = 0;

        /// <summary>
        /// Displays the current list of unlocked units.
        /// </summary>
        void DisplayUnitList()
        {
            foreach(Unit unitName in unitList)
            {
                Console.WriteLine(unitName.Name);
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
        int GetInput(string description, string option1, string option2, string option3, 
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
        /// Figures out the damage being dealt in a specific attack.
        /// </summary>
        /// <param name="attack"> The unit's attack. </param>
        /// <param name="defense"> The target's defense. </param>
        /// <returns> The damage dealt to the target. </returns>
        int DealDamage(int attack, int defense)
        {
            // Calculates the damage that will be dealt.
            int damage = attack - defense;

            // Checks to see if the damage is less than zero. If it is, it sets damage to zero.
            if(damage < 0)
            {
                return 0;
            }

            return damage;
        }

        /// <summary>
        /// Displays the start menu from which the player can start a battle, change their army, or quit 
        /// the game.
        /// </summary>
        void DisplayStartMenu()
        {
            int choice = GetInput("Welcome to the Turn Based Test!", "Start Battle", "Change Squad", "Quit");

            switch (choice)
            {
                case 1:
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
        /// Initializes everything that should be initalized before the start of the game.
        /// </summary>
        void Start()
        {
            // Initializes the stats for Ivan.
            Unit ivan = new Unit("Ivan", 25, 10, 5, 8, 3, 0);

            // Initalizes the stats for a soldier.
            Unit soldier = new Unit("Soldier", 10, 8, 3, 0, 2, 2);

            // Initializes the stats for a ruffian.
            Unit ruffian = new Unit();

            // Initalizes the stats for an archer.
            Unit archer = new Unit();

            // Initalizes the stats for a cleric.
            Unit cleric = new Unit();

            // Initalizes the stats for an assassin.
            Unit shadowstepper = new Unit();

            unitList = new Unit[] { ivan, soldier, ruffian, archer, cleric, shadowstepper };
        }


        /// <summary>
        /// Changes the information of the game.
        /// </summary>
        void Update()
        {
            Console.Clear();
            UpdateScene();
        }

        void End()
        {
            Console.WriteLine("Goodbye!");
        }

        /// <summary>
        /// Changes the scenes in the game.
        /// </summary>
        void UpdateScene()
        {
            switch (currentScene)
            {
                case 0:
                    DisplayStartMenu();
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        public void Run()
        {
            Start();

            while (!gameOver)
            {
                Update();
            }

            End();
        }
    }
}
