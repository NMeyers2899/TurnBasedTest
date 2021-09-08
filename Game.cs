using System;
using System.Collections.Generic;
using System.Text;

namespace TurnBasedTest
{ 
    /// <summary>
    /// The constuctor of a unit template.
    /// </summary>
    struct Unit
    {
        public string name;
        public int maxHealth;
        public int health;
        public int attack;
        public int defense;
    }

    class Game
    {
        // Initalizes the stats of different units.
        Unit Soldier;
        Unit Ruffian;

        bool gameOver = false;

        Unit playerFrontlineUnit1;
        Unit playerFrontlineUnit2;
        Unit playerFrontlineUnit3;
        Unit playerFrontlineUnit4;
        Unit playerFrontlineUnit5;

        int currentScene = 0;

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

        string GetUnitChange(bool pauseInvalid = false)
        {
            string choice = "None";

            Console.Write("Which position would you like to change? \n1. " + playerFrontlineUnit1.name +
                "\n2. " + playerFrontlineUnit2.name + "\n3. " + playerFrontlineUnit3.name + "\n4. " +
                playerFrontlineUnit4.name + "\n5. " + playerFrontlineUnit5.name + "\n> ");
            Console.ReadKey(true);
            Console.Clear();
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
        /// Sends two units against each other to fight, dealing damage to the second.
        /// </summary>
        /// <param name="unit1"> The attacker, who will deal damage. </param>
        /// <param name="unit2"> The target, who will take the damage being dealt.. </param>
        void Combat(ref Unit unit1, ref Unit unit2)
        {
            // Calculates the damage that will be dealt.
            int damageTaken = DealDamage(unit1.attack, unit2.defense);

            // Subtracts the damage from the target's health.
            unit2.health -= damageTaken;

            Console.WriteLine(unit2.name + " takes " + damageTaken + " damage!");
        }

        /// <summary>
        /// Displays a unit's stats to the console.
        /// </summary>
        /// <param name="unit"> The unit whose stats will be displayed. </param>
        void DisplayUnitStats(Unit unit)
        {
            Console.WriteLine("Name: " + unit.name + "\nHealth: " + unit.health + "\nAttack: " + unit.attack +
                "\nDefense: " + unit.defense + "\n");
        }

        /// <summary>
        /// Uses an identifier to get a given unit, and sets it equal to that unit's stats.
        /// </summary>
        /// <param name="unitIdentifier"> The indentifier number for a unit. </param>
        Unit GetUnit(string unitIdentifier)
        {
            Unit unit;
            unit.name = "None";
            unit.maxHealth = 0;
            unit.health = 0;
            unit.attack = 0;
            unit.defense = 0;

            switch (unitIdentifier)
            {
                case "soldier":
                    unit = Soldier;
                    break;
                case "ruffian":
                    unit = Ruffian;
                    break;
            }

            return unit;
        }

        /// <summary>
        /// Displays the start menu from which the player can start a battle, change their army, or quit 
        /// the game.
        /// </summary>
        void DisplayStartMenu()
        {
            int choice = GetInput("Welcome to the Turn Based Test!", "Start Battle", "Change Army", "Quit");

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
        /// This will display the menu that allows the player to check on their army, and change the 
        /// units in it.
        /// </summary>
        void ChangePlayerArmy()
        {
            int choice = GetInput("What would you like to do?", "Switch Unit", "Check Army Stats", "Back");

            switch (choice)
            {
                case 1:
                    GetUnitChange();
                    break;
                case 2:
                    Console.Clear();
                    DisplayUnitStats(playerFrontlineUnit1);
                    DisplayUnitStats(playerFrontlineUnit2);
                    DisplayUnitStats(playerFrontlineUnit3);
                    DisplayUnitStats(playerFrontlineUnit4);
                    DisplayUnitStats(playerFrontlineUnit5);
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
                case 3:
                    currentScene = 0;
                    Console.Clear();
                    break;
            }

        }

        /// <summary>
        /// Allows the player to change a single unit in their army.
        /// </summary>
        /// <param name="unit"> The unit that will be changed. </param>
        void ChangeUnit(Unit unit)
        {
           
        }

        /// <summary>
        /// Initializes everything that should be initalized before the start of the game.
        /// </summary>
        void Start()
        {
            // Initializes the player's army.   
            int[] playerFrontLine = new int[5];
            int[] enemyFrontLine = new int[5];

            // Initializes the unit list for future use.
            Unit[] unitList = new Unit[] { Soldier, Ruffian };

            // Initalizes the stats for a soldier.
            Soldier.name = "Soldier";
            Soldier.maxHealth = 10;
            Soldier.health = 10;
            Soldier.attack = 8;
            Soldier.defense = 3;

            // Initializes the stats for a ruffian.
            Ruffian.name = "Ruffian";
            Ruffian.maxHealth = 12;
            Ruffian.health = 12;
            Ruffian.attack = 10;
            Ruffian.defense = 2;
        }


        /// <summary>
        /// Changes the information of the game.
        /// </summary>
        void Update()
        {
            UpdateScene();
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
                    ChangePlayerArmy();
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
        }
    }
}
