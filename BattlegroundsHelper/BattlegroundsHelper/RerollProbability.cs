using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.Hearthstone;
using Hearthstone_Deck_Tracker.Hearthstone.Entities;
using Hearthstone_Deck_Tracker.Enums.Hearthstone;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.LogReader;
using Hearthstone_Deck_Tracker.Plugins;
using HearthDb.Enums;
using System.Windows.Controls;
using BattlegroundsHelper.view;
using Hearthstone_Deck_Tracker.Enums;
using Hearthstone_Deck_Tracker.Controls.Overlay;
using BattlegroundsHelper;

namespace HDT.Plugins.RerollProbability
{
    public class RerollProbability : IPlugin
    {
        private ProbabilityBox _probabilityBox;
        #region Manifest
        public string Author
        {
            get { return "b4no"; }
        }

        public string ButtonText
        {
            get { return "Settings"; }
        }

        public string Description
        {
            get { return "A panel that shows reroll probability."; }
        }

        public string Name
        {
            get { return "RerollProbability"; }
        }

        public Version Version
        {
            get { return new Version(1,0,0,0); }
        }
        #endregion

        public MenuItem MenuItem
        {
            get { return null; }
        }

        public void OnButtonPress()
        {
        }

        public void OnLoad()
        {
            _probabilityBox = new ProbabilityBox();
            RerollProbabilityData.overlay = _probabilityBox;

            GameEvents.OnGameStart.Add(RerollProbabilityData.GameStart);
            GameEvents.OnTurnStart.Add(RerollProbabilityData.UpdatePercentage);
            GameEvents.OnInMenu.Add(RerollProbabilityData.InMenu);
            GameEvents.OnGameEnd.Add(RerollProbabilityData.GameEnd);
        }

        public void OnUnload()
        {
            Core.OverlayCanvas.Children.Remove(_probabilityBox);
        }
        
        public void OnUpdate()
        {
        }
    }
}
