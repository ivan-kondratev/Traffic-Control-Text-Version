using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class Game
    {
        Restrictions restrictions;
        Car currCar;
        Player player;
        RuleChecker ruleChecker;

        public Game()
        {
            restrictions = new Restrictions();
            player = new Player();
            ruleChecker = new RuleChecker(player, restrictions);

            GUI.Output(true, "Добро пожаловать в игру Traffic Control!");

            Loop();
        }

        public void Loop()
        {
            while (true)
            {
                GUI.Output(true, "Очки: " + player.Points + "\nЖизни: " + player.Health + "\nОграничение скорости: " +
                    restrictions.speedLimit.Value + "\nСкорость можно превысить на " + restrictions.speeding.Value);

                currCar = new Car();
                int currCarSpeed = currCar.Speed;
                GUI.Output(true, "Скорость проезжающей машины: " + currCarSpeed);

                player.WhetherToStopTheCar(currCarSpeed);

                ruleChecker.Check(currCarSpeed);

                Console.Clear();
            }
        }

        
    }
}
