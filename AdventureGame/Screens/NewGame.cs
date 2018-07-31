using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public class NewGame:Screen
    {
        Input enterName;
        Input enterGender;
        Decision confirmName;
        Decision confirmGender;
        Decision intro;
        Decision travel;
        Decision breakfast;

        public NewGame()
        {
            ScreenController.Clear();
            AddQuestions();
            AddDecisions();
            Run();
        }
        private void Run()
        {
            Intro();
        }
        private void AddQuestions()
        {
            enterName = new Input("Please Enter Your Name:");
            enterGender = new Input($"Please Enter Your Gender, @Name:");
        }
        private void AddDecisions()
        {
            intro = new Decision("Do you want to go to the bathroom, or downstairs for breakfast?", new List<string>() { "1. Bathroom", "2. Downstairs" });
            travel = new Decision("How do you want to travel to work?", new List<string>() { "1. Walk", "2. Cycle" });
            breakfast = new Decision("What do you make for breakfast?", new List<string>(){"1. Cereal", "2. Full Cooked Breakfast"});
            confirmName = new Decision("Are You Happy With This Name?", new List<string>() { "1. Yes", "2. No" });
            confirmGender = new Decision("Are You Happy With This Gender?", new List<string>() { "1. Yes", "2. No" });
        }
        private void Intro()
        {
            ScreenController.Clear();
            ScreenController.Write("You wake up in your house.");
            int input = intro.Run();
            if(input==1)
            {
                Bathroom();
            }
            else
            {
                Kitchen();
            }
        }
        private void Bathroom()
        {
            ScreenController.Clear();
            ScreenController.Write("You clean your teeth and go for a shower, but in doing so you are now running late for work!");
            int input = travel.Run();
            if(input==1)
            {
                Walk();
            }
            else
            {
                Cycle();
            }
        }
        private void Kitchen()
        {
            ScreenController.Clear();
            ScreenController.Write("You make your way down to the kitchen to get some food.");
            int input = breakfast.Run();
            ScreenController.Clear();
            if (input==1)
            {
                ScreenController.Write("You make a healthy breakfast and find yourself with plenty of time to travel to work.");
            }
            else
            {
                ScreenController.Write("You have a massive greasy breakfast that you spend loads of time enjoying, but are now late for work!");
            }
            input = travel.Run();
            if (input == 1)
            {
                Walk();
            }
            else
            {
                Cycle();
            }
        }
        private void Walk()
        {
            ScreenController.Clear();
            ScreenController.Write("You travel to work by foot.");
            Console.ReadLine();
        }
        private void Cycle()
        {
            ScreenController.Clear();
            ScreenController.Write("You travel to work by bike.");
            Console.ReadLine();
        }
        private void EnterName()
        {
            ScreenController.Clear();
            var charName = enterName.Run();
            int input = confirmName.Run();
            if (input == 1)
            {
                GameController.character.Name = charName;
                EnterGender();
            }
            else
            {
                EnterName();
            }
        }
        private void EnterGender()
        {
            ScreenController.Clear();
            string charGender = enterGender.Run();
            int input = confirmGender.Run();
            if (input == 1)
            {
                GameController.character.Gender = charGender;
                ScreenController.Clear();
                ScreenController.Write("Saved");
                ScreenController.Write($"Name: {GameController.character.Name}");
                ScreenController.Write($"Gender: {GameController.character.Gender}");
                GameController.CreateSaveFile();
                Console.Read();
            }
            else
            {
                EnterGender();
            }
        }
    }
}
