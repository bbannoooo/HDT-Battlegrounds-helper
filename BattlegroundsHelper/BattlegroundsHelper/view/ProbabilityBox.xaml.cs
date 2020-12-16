using Hearthstone_Deck_Tracker;
using Hearthstone_Deck_Tracker.Hearthstone;
using Hearthstone_Deck_Tracker.Windows;
using System;
using Hearthstone_Deck_Tracker.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hearthstone_Deck_Tracker.API;

namespace BattlegroundsHelper.view
{
    /// <summary>
    /// probabilityBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProbabilityBox : UserControl
    {


        public ProbabilityBox()
        {
            InitializeComponent();

            tier1.Probability = new Probability()
            {
                tier = "Tier1"
            };
            tier2.Probability = new Probability()
            {
                tier = "Tier2"
            };
            tier3.Probability = new Probability()
            {
                tier = "Tier3"
            };
            tier4.Probability = new Probability()
            {
                tier = "Tier4"
            };
            tier5.Probability = new Probability()
            {
                tier = "Tier5"
            };
            tier6.Probability = new Probability()
            {
                tier = "Tier6"
            };
            Calculate(1);
        }

        internal void SetProbability()
        {
            //calculate probability
            //percentage.Content = Tostring(calculatedPercentage) + "%";
        }
        public void GameStart()
        {
            Show();
        }

        public void GameEnd()
        {
            Hide();
        }

        public void Show()
        {
            this.Visibility = Visibility.Visible;
        }

        public void Hide()
        {
            this.Visibility = Visibility.Hidden;
        }

        private void probabilityBox_MouseEnter(object sender, MouseEventArgs e)
        {
            tierbox.Visibility = Visibility.Visible;
        }

        private void probabilityBox_MouseLeave(object sender, MouseEventArgs e)
        {
            tierbox.Visibility = Visibility.Hidden;
        }

        internal void Calculate(int heropower)         // 아직 계산 미구현 임시로 확률 나타냄
        {
            switch(heropower) 
            {
                case 1:
                    tier1.percentageBox.Text = "100%";
                    tier2.percentageBox.Text = "0%";
                    tier3.percentageBox.Text = "0%";
                    tier4.percentageBox.Text = "0%";
                    tier5.percentageBox.Text = "0%";
                    tier6.percentageBox.Text = "0%";
                    break;

                case 2:
                    tier1.percentageBox.Text = "80%";
                    tier2.percentageBox.Text = "20%";
                    tier3.percentageBox.Text = "0%";
                    tier4.percentageBox.Text = "0%";
                    tier5.percentageBox.Text = "0%";
                    tier6.percentageBox.Text = "0%";
                    break;
                case 3:
                    tier1.percentageBox.Text = "60%";
                    tier2.percentageBox.Text = "30%";
                    tier3.percentageBox.Text = "10%";
                    tier4.percentageBox.Text = "0%";
                    tier5.percentageBox.Text = "0%";
                    tier6.percentageBox.Text = "0%";
                    break;
                case 4:
                    tier1.percentageBox.Text = "20%";
                    tier2.percentageBox.Text = "30%";
                    tier3.percentageBox.Text = "30%";
                    tier4.percentageBox.Text = "20%";
                    tier5.percentageBox.Text = "0%";
                    tier6.percentageBox.Text = "0%";
                    break;
                case 5:
                    tier1.percentageBox.Text = "10%";
                    tier2.percentageBox.Text = "20%";
                    tier3.percentageBox.Text = "30%";
                    tier4.percentageBox.Text = "30%";
                    tier5.percentageBox.Text = "10%";
                    tier6.percentageBox.Text = "0%";
                    break;
                case 6:
                    tier1.percentageBox.Text = "10%";
                    tier2.percentageBox.Text = "10%";
                    tier3.percentageBox.Text = "30%";
                    tier4.percentageBox.Text = "30%";
                    tier5.percentageBox.Text = "20%";
                    tier6.percentageBox.Text = "10%";
                    break;
                default:
                    tier1.percentageBox.Text = "0%";
                    tier2.percentageBox.Text = "0%";
                    tier3.percentageBox.Text = "0%";
                    tier4.percentageBox.Text = "0%";
                    tier5.percentageBox.Text = "0%";
                    tier6.percentageBox.Text = "0%";
                    break;
            }

        }


    }
}
