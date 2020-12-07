using BattlegroundsHelper.view;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlegroundsHelper
{
    public class RerollProbabilityData
    {
        public static probabilityBox _overlay;

        internal static void GameStart()
        {

        }

        internal static void GameEnd()
        {

        }

        internal static bool InBgMode()
        {
            if (Core.Game.CurrentGameMode != GameMode.Battlegrounds) return false;
            else return true;
        }

        internal static void AddOrRemoveOverlay()
        {
            if (InBgMode())
            {
                if (!Core.OverlayCanvas.Children.Contains(_overlay))
                {
                    Core.OverlayCanvas.Children.Add(_overlay);
                }
            }
            else
            {
                if (Core.OverlayCanvas.Children.Contains(_overlay))
                {
                    Core.OverlayCanvas.Children.Remove(_overlay);
                }
            }

        }

        internal static void Update()
        {
            AddOrRemoveOverlay();
        }

    }
}
