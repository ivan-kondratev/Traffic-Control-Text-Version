using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class RuleChecker
    {
        private int speedLimit, speeding;
        private Player Player;

        private Action playerChangeHealth, playerChangePoints;

        public RuleChecker(Player player, Restrictions restrictions)
        {
            speedLimit = restrictions.speedLimit.Value;
            speeding = restrictions.speeding.Value;

            Player = player;

            playerChangeHealth = new Action(PlayerDamage);
            playerChangePoints = new Action(PlayerReward);

            Player.OnHealthChange += playerChangeHealth;
            Player.OnPointsChange += playerChangePoints;
        }

        public void Check(int carSpeed)
        {
            if (carSpeed > speedLimit)
            {
                if (carSpeed <= speedLimit + speeding)
                {
                    Player.GetPoint();
                }
                else
                {
                    if (Player.Decision == PlayerDecisionEnum.Yes)
                    {
                        Player.GetPoint();
                    }
                    else
                    {
                        Player.TakeDamage();
                    }
                }
            }
            else
            {
                Player.GetPoint();
            }
        }

        private void PlayerDamage()
        {
            Player.Health--;
        }

        private void PlayerReward()
        {
            Player.Points++;
        }
    }
}
