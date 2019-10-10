﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    interface IBlackjackPlayer
    {
        string GetName();
        List<Card> GetCards();
        int CountPoints();
        bool IsGameCompleted();
        bool WantCard();
        void GiveCard();
    }
}
