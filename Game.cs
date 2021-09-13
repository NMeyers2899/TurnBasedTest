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
        Unit Commander;
        Unit Soldier;
        Unit Ruffian;
        Unit Archer;
        Unit Cleric;
        Unit Shadowstepper;
        Unit Abomination;
        Unit Shapeshifter;
        Unit VoidMage;
        Unit Reaver;

        bool gameOver = false;

        // Initializes the player's army.
        Unit playerFrontLineUnit1;
        Unit playerFrontLineUnit2;
        Unit playerFrontLineUnit3;
        Unit playerFrontLineUnit4;
        Unit playerFrontLineUnit5;
        Unit playerMidLineUnit1;
        Unit playerMidLineUnit2;
        Unit playerMidLineUnit3;
        Unit playerMidLineUnit4;
        Unit playerMidLineUnit5;
        Unit playerBackLineUnit1;
        Unit playerBackLineUnit2;
        Unit playerBackLineUnit3;
        Unit playerBackLineUnit4;
        Unit playerBackLineUnit5;
        
        // Initalizes the enemy's army.
        Unit enemyFrontLineUnit1;
        Unit enemyFrontLineUnit2;
        Unit enemyFrontLineUnit3;
        Unit enemyFrontLineUnit4;
        Unit enemyFrontLineUnit5;

        Unit[] unitList;

        int currentScene = 0;

        /// <summary>
        /// Displays the current list of unlocked units.
        /// </summary>
        void DisplayUnitList()
        {
            foreach(Unit unitName in unitList)
            {
                Console.WriteLine(unitName.name);
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
        /// This method will allow the user to choose a unit to swap and what to swap that unit into.
        /// </summary>
        void GetUnitChange()
        {
            Unit unitSwap;
            unitSwap.name = "None";
            unitSwap.maxHealth = 0;
            unitSwap.health = 0;
            unitSwap.attack = 0;
            unitSwap.defense = 0;

            string input = "None";
            int choice = GetInput("Which row would you like to change?", "Front Line", "Middle Line", 
                "Back Line");
            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.Write("Which position would you like to change? \n1. " + playerFrontLineUnit1.name +
                "\n2. " + playerFrontLineUnit2.name + "\n3. " + playerFrontLineUnit3.name + "\n4. " +
                playerFrontLineUnit4.name + "\n5. " + playerFrontLineUnit5.name + "\n6. Go Back" + "\n> ");
                    // Gets player input.

                    input = Console.ReadLine().ToLower();

                    switch (input)
                    {
                        case "1":
                            ChangeUnit(ref unitSwap);
                            playerFrontLineUnit1 = unitSwap;
                            break;
                        case "2":
                            ChangeUnit(ref unitSwap);
                            playerFrontLineUnit2 = unitSwap;
                            break;
                        case "3":
                            ChangeUnit(ref unitSwap);
                            playerFrontLineUnit3 = unitSwap;
                            break;
                        case "4":
                            ChangeUnit(ref unitSwap);
                            playerFrontLineUnit4 = unitSwap;
                            break;
                        case "5":
                            ChangeUnit(ref unitSwap);
                            playerFrontLineUnit5 = unitSwap;
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadKey(true);
                            Console.Clear();
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Which position would you like to change? \n1. " + playerMidLineUnit1.name +
                "\n2. " + playerMidLineUnit2.name + "\n3. " + playerMidLineUnit3.name + "\n4. " +
                playerMidLineUnit4.name + "\n5. " + playerMidLineUnit5.name + "\n6. Go Back" + "\n> ");
                    // Gets player input.

                    input = Console.ReadLine().ToLower();

                    switch (input)
                    {
                        case "1":
                            ChangeUnit(ref unitSwap);
                            playerMidLineUnit1 = unitSwap;
                            break;
                        case "2":
                            ChangeUnit(ref unitSwap);
                            playerMidLineUnit2 = unitSwap;
                            break;
                        case "3":
                            ChangeUnit(ref unitSwap);
                            playerMidLineUnit3 = unitSwap;
                            break;
                        case "4":
                            ChangeUnit(ref unitSwap);
                            playerMidLineUnit4 = unitSwap;
                            break;
                        case "5":
                            ChangeUnit(ref unitSwap);
                            playerMidLineUnit5 = unitSwap;
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadKey(true);
                            Console.Clear();
                            break;
                    }
                    break;
                case 3:
                    Console.Write("Which position would you like to change? \n1. " + playerBackLineUnit1.name +
                "\n2. " + playerBackLineUnit2.name + "\n3. " + playerBackLineUnit3.name + "\n4. " +
                playerBackLineUnit4.name + "\n5. " + playerBackLineUnit5.name + "\n6. Go Back" + "\n> ");
                    // Gets player input.

                    input = Console.ReadLine().ToLower();

                    switch (input)
                    {
                        case "1":
                            ChangeUnit(ref unitSwap);
                            playerBackLineUnit1 = unitSwap;
                            break;
                        case "2":
                            ChangeUnit(ref unitSwap);
                            playerBackLineUnit2 = unitSwap;
                            break;
                        case "3":
                            ChangeUnit(ref unitSwap);
                            playerBackLineUnit3 = unitSwap;
                            break;
                        case "4":
                            ChangeUnit(ref unitSwap);
                            playerBackLineUnit4 = unitSwap;
                            break;
                        case "5":
                            ChangeUnit(ref unitSwap);
                            playerBackLineUnit5 = unitSwap;
                            break;
                        case "6":
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadKey(true);
                            Console.Clear();
                            break;
                    }
                    break;
            }
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
        /// <param name="unit2"> The target, who will take the damage being dealt. </param>
        void DoCombat(ref Unit unit1, ref Unit unit2)
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
        /// Displays the stats of the player's squad when called upon.
        /// </summary>
        void DisplayPlayerSquad()
        {
            Console.WriteLine("Front Line:");
            DisplayUnitStats(playerFrontLineUnit1);
            DisplayUnitStats(playerFrontLineUnit2);
            DisplayUnitStats(playerFrontLineUnit3);
            DisplayUnitStats(playerFrontLineUnit4);
            DisplayUnitStats(playerFrontLineUnit5);
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Middle Line");
            DisplayUnitStats(playerMidLineUnit1);
            DisplayUnitStats(playerMidLineUnit2);
            DisplayUnitStats(playerMidLineUnit3);
            DisplayUnitStats(playerMidLineUnit4);
            DisplayUnitStats(playerMidLineUnit5);
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Back Line");
            DisplayUnitStats(playerBackLineUnit1);
            DisplayUnitStats(playerBackLineUnit2);
            DisplayUnitStats(playerBackLineUnit3);
            DisplayUnitStats(playerBackLineUnit4);
            DisplayUnitStats(playerBackLineUnit5);
        }

        /// <summary>
        /// Uses an identifier to get a given unit, and sets it equal to that unit's stats.
        /// </summary>
        /// <param name="unitIdentifier"> The indentifier number for a unit. </param>
        Unit GetUnit(string unitIdentifier)
        {
            Unit unit;
            unit.name = "";
            unit.maxHealth = 0;
            unit.health = 0;
            unit.attack = 0;
            unit.defense = 0;

            for (int i = 0; i < unitList.Length; i++)
            {
                if (unitIdentifier == unitList[i].name.ToLower())
                {
                    unit = unitList[i];
                }
            }

            return unit;
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
        void ChangePlayerSquad()
        {
            int choice = GetInput("What would you like to do?", "Switch Unit", "Check Squad Stats", "Back");

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    GetUnitChange();
                    break;
                case 2:
                    Console.Clear();
                    DisplayPlayerSquad();
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
                case 3:
                    currentScene = 0;
                    break;
            }

        }

        /// <summary>
        /// Allows the player to change a single unit in their army.
        /// </summary>
        /// <param name="unit"> The unit that will be changed. </param>
        void ChangeUnit(ref Unit unit)
        {
            string input = "None";

            Console.Clear();

            DisplayUnitList();
            Console.WriteLine();
            Console.Write("Which unit do you want to swap into this position? \n>");
            input = Console.ReadLine().ToLower();
            unit = GetUnit(input);
        }

        /// <summary>
        /// Initializes everything that should be initalized before the start of the game.
        /// </summary>
        void Start()
        {
            // Initializes the player's army.   
            int[] playerFrontLine = new int[5];
            int[] enemyFrontLine = new int[5];

            // Initializes the stats for the Commander.
            Commander.name = "Ivan";
            Commander.maxHealth = 25;
            Commander.health = 25;
            Commander.attack = 10;
            Commander.defense = 6;

            // Initalizes the stats for a soldier.
            Soldier.name = "Soldier";
            Soldier.maxHealth = 10;
            Soldier.health = 10;
            Soldier.attack = 8;
            Soldier.defense = 4;

            // Initializes the stats for a ruffian.
            Ruffian.name = "Ruffian";
            Ruffian.maxHealth = 12;
            Ruffian.health = 12;
            Ruffian.attack = 10;
            Ruffian.defense = 3;

            // Initalizes the stats for an archer.
            Archer.name = "Archer";
            Archer.maxHealth = 8;
            Archer.health = 8;
            Archer.attack = 10;
            Archer.defense = 2;

            // Initalizes the stats for a cleric.
            Cleric.name = "Cleric";
            Cleric.maxHealth = 8;
            Cleric.health = 8;
            Cleric.attack = 5;
            Cleric.defense = 2;

            // Initalizes the stats for an assassin.
            Shadowstepper.name = "Shadowstepper";
            Shadowstepper.maxHealth = 8;
            Shadowstepper.health = 8;
            Shadowstepper.attack = 10;
            Shadowstepper.defense = 2;

            unitList = new Unit[] { Soldier, Ruffian, Archer, Cleric, Shadowstepper };
        }


        /// <summary>
        /// Changes the information of the game.
        /// </summary>
        void Update()
        {
            Console.Clear();
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
                    ChangePlayerSquad();
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
