using BattlegroundsHelper.view;
using HearthDb.Enums;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BattlegroundsHelper
{
    public class RerollProbabilityData
    {
        public static ProbabilityBox overlay;

        internal static bool InBgMode()
        {
            if (Core.Game.CurrentGameMode != GameMode.Battlegrounds) return false;
            else return true;
        }
        
        internal static void InMenu()
        {
            if (Core.OverlayCanvas.Children.Contains(overlay))
            {
                Core.OverlayCanvas.Children.Remove(overlay);
            }
        }

        internal static void GameStart()
        {
            AddOrRemoveOverlay();
        }

        internal static void GameEnd()
        {
            if (Core.OverlayCanvas.Children.Contains(overlay))
            {
                Core.OverlayCanvas.Children.Remove(overlay);
            }
        }

        internal static void UpdatePercentage(ActivePlayer player)
        {
            if (player == 0)
            {
                var playerHero = Core.Game.PlayerEntity;
                var playerTechLevel = playerHero.GetTag(GameTag.PLAYER_TECH_LEVEL);
                overlay.Calculate(playerTechLevel);
            }
        }

        internal static void AddOrRemoveOverlay()
        {
            if (InBgMode())
            {
                if (!Core.OverlayCanvas.Children.Contains(overlay))
                {
                    var overlayType = Core.OverlayWindow.GetType();
                    var clickableElementsField = overlayType.GetField("_clickableElements", BindingFlags.NonPublic | BindingFlags.Instance);
                    var clickableElements = clickableElementsField.GetValue(Core.OverlayWindow) as IList<FrameworkElement>;

                    Core.OverlayCanvas.Children.Add(overlay);
                    clickableElements.Add(overlay);
                }
            }
            else
            {   
                if(Core.OverlayCanvas.Children.Contains(overlay))
                {
                    Core.OverlayCanvas.Children.Remove(overlay);
                }
            }
        }
    }
}
