using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Hearthstone;
using System;
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

namespace BattlegroundsHelper.view
{
    /// <summary>
    /// probabilityBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class probabilityBox : UserControl
    {
        public probabilityBox()
        {
            InitializeComponent();
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
    }
}
