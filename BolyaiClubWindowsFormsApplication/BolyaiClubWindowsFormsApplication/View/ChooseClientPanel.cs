using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class ChooseClientPanel : ChooseFromListPanel
    {

        public ChooseClientPanel() : base()
        {
            InitializeComponent();
            VisualizeStage();
            showNextButton();
        }

        protected override void VisualizeStage()
        {
            base.VisualizeStage();
            base.ShowChooseClientLabel();
            base.HighlightChooseClientLabel();
        }

        protected override void nextButton_Click(object sender, EventArgs e)
        {
            base.nextButton_Click(sender, e);
            OnChooseClientFinished();
        }

    }
}
