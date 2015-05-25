using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class ChooseRoomPanel : ChooseFromListPanel
    {

        public ChooseRoomPanel() : base()
        {
            InitializeComponent();
            VisualizeStage();
            showBackButton();
            showNextButton();
        }

        protected override void VisualizeStage()
        {
            base.VisualizeStage();
            base.ShowChooseClientLabel();
            base.ShowChooseRoomLabel();
            base.HighlightChooseRoomLabel();
        }

        protected override void backButton_Click(object sender, EventArgs e)
        {
            base.backButton_Click(sender, e);
            OnChooseRoomBacked();
        }

        protected override void nextButton_Click(object sender, EventArgs e)
        {
            base.nextButton_Click(sender, e);
            OnChooseRoomFinished();
        }

    }
}
