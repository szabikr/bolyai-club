using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class ChooseDataPanel : MetroPanel
    {

        public event EventHandler ChooseClientFinished;
        public event EventHandler ChooseRoomFinished;
        public event EventHandler ChooseTimeFinished;
        public event EventHandler ChooseRoomBacked;
        public event EventHandler ChooseTimeBacked;

        public ChooseDataPanel() : base()
        {
            InitializeComponent();
        }

        protected virtual void VisualizeStage()
        {

        }

        protected void ShowChooseClientLabel()
        {
            this.Controls.Add(this.chooseClientLabel);
        }

        protected void ShowChooseRoomLabel()
        {
            this.Controls.Add(this.chooseRoomLabel);
        }

        protected void ShowChooseTimeLabel()
        {
            this.Controls.Add(this.chooseTimeLabel);
        }

        protected void showBackButton()
        {
            if (this.backButton == null)
            {
                this.backButton = new MetroButton();
                this.InitializeBackButton();
            }
            this.Controls.Add(this.backButton);
        }

        protected void hideBackButton()
        {
            this.Controls.Remove(this.backButton);
        }

        protected void showNextButton()
        {
            if (this.nextButton == null)
            {
                this.nextButton = new MetroFramework.Controls.MetroButton();
                this.InitializeNextButton();
            }
            this.Controls.Add(this.nextButton);
        }

        protected void hideNextButton()
        {
            this.Controls.Remove(this.nextButton);
        }

        protected virtual void backButton_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void nextButton_Click(object sender, EventArgs e)
        {
            
        }

        protected void OnChooseClientFinished()
        {
            if (ChooseClientFinished != null)
            {
                ChooseClientFinished(this, EventArgs.Empty);
            }
        }

        protected void OnChooseRoomFinished()
        {
            if (ChooseRoomFinished != null)
            {
                ChooseRoomFinished(this, EventArgs.Empty);
            }
        }

        protected void OnChooseTimeFinished()
        {
            if (ChooseTimeFinished != null)
            {
                ChooseTimeFinished(this, EventArgs.Empty);
            }
        }

        protected void OnChooseRoomBacked()
        {
            if (ChooseRoomBacked != null)
            {
                ChooseRoomBacked(this, EventArgs.Empty);
            }
        }

        protected void OnChooseTimeBacked()
        {
            if (ChooseTimeBacked != null)
            {
                ChooseTimeBacked(this, EventArgs.Empty);
            }
        }

    }
}
