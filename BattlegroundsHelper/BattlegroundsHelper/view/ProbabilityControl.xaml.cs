using Hearthstone_Deck_Tracker.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// ProbabilityControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProbabilityControl : UserControl
    {
        private Probability _probability;
        public Probability Probability
        {
            get
            {
                return _probability;
            }

            set
            {
                _probability = value;
                tierBox.Text = _probability.tier;
                percentageBox.Text = _probability.percentage;
            }
        }

        public ProbabilityControl()
        {
            InitializeComponent();
        }
    }

    public class Probability
    {
        public string tier { get; set; }
        public string percentage { get; set; }
    }



}
