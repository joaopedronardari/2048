using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.WPF
{
    public delegate void OnGameGestureFired(GameGesture gameGesture);

    public enum GameGesture
    {
        swipe_up,
        swipe_down,
        swipe_left,
        swipe_right
    }
}
