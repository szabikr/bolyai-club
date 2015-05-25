using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BolyaiClubWindowsFormsApplication.Controller;
using BolyaiClubWindowsFormsApplication.Model;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class MakeReservationPanel : ContentPanel
    {
        private enum Stages
        {
            None = -1,
            ChooseClient = 0,
            ChooseRoom = 1,
            ChooseTime = 2
        };

        private ChooseDataPanel chooseDataPanel;

        public MakeReservationPanel() : base()
        {
            InitializeComponent();
            chooseDataPanel = new ChooseClientPanel();
            InitializeChooseDataPanel(chooseDataPanel);
            this.Controls.Add(chooseDataPanel);
            SubscribeToEvents();
        }

        public void OnChooseClientFinished(object sender, EventArgs e)
        {
            this.ActivateSelectedPanel(new ChooseRoomPanel());
        }

        public void OnChooseRoomFinished(object sender, EventArgs e)
        {
            this.ActivateSelectedPanel(new ChooseTimePanel());
        }

        public void OnChooseTimeFinished(object sender, EventArgs e)
        {
            // TODO: When it's finished..
        }

        public void OnChooseRoomBacked(object sender, EventArgs e)
        {
            this.ActivateSelectedPanel(new ChooseClientPanel());
        }

        public void OnChooseTimeBacked(object sender, EventArgs e)
        {
            this.ActivateSelectedPanel(new ChooseRoomPanel());
        }

        private void ActivateSelectedPanel(ChooseDataPanel panel)
        {
            this.Controls.Remove(this.chooseDataPanel);
            this.chooseDataPanel = panel;
            InitializeChooseDataPanel(chooseDataPanel);
            SubscribeToEvents();
            this.Controls.Add(this.chooseDataPanel);
        }

        private void SubscribeToEvents()
        {
            if (this.chooseDataPanel == null)
            {
                return;
            }
            this.chooseDataPanel.ChooseClientFinished += OnChooseClientFinished;
            this.chooseDataPanel.ChooseRoomFinished += OnChooseRoomFinished;
            this.chooseDataPanel.ChooseTimeFinished += OnChooseTimeFinished;
            this.chooseDataPanel.ChooseRoomBacked += OnChooseRoomBacked;
            this.chooseDataPanel.ChooseTimeBacked += OnChooseTimeBacked;
        }

    }
}
