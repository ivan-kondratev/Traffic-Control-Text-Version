using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class Player
    {
        public event Action OnHealthChange;
        public event Action OnPointsChange;

        public int Health { get; set; }
        public int Points { get; set; }
        public PlayerDecisionEnum Decision { get; private set; }

        public Player()
        {
            Health = 3;
            Points = 0;
        }

        public void WhetherToStopTheCar(int carSpeed)
        {
            GUI.Output(false, "Остановить? ");
            Decision = GUI.WriteChoice(PlayerDecisionEnum.Yes.ToString(), PlayerDecisionEnum.No.ToString());
        }

        public void TakeDamage()
        {
            OnHealthChange?.Invoke();
        }

        public void GetPoint()
        {
            OnPointsChange?.Invoke();
        }
    }
}
