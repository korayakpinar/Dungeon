using System.Drawing;
using System.Windows.Forms;
using Dungeon.Properties;
using Ironide;
using Ironide.Components;
using Ironide.Tools;

namespace Dungeon {
    /// <summary>
    /// Main window of application.
    /// </summary>
    internal sealed partial class AppWindow:IronideForm {
        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public AppWindow() {
            Init();
        }

        #endregion
    }

    // Designer.
    internal sealed partial class AppWindow {
        #region Components

        private IronidePanel
            leftPanel;

        private IronideButton
            connectButton,
            hostButton;

        private IronideToolTip
            tip;

        #endregion

        /// <summary>
        /// Initialize window.
        /// </summary>
        protected override void Init() {
            base.Init();

            #region This

            Title = "Dungeon";
            BorderThickness = 0;
            TitlebarBackColor = IronideColorizer.FromArgb(24,24,24);
            TitlebarForeColor = IronideColorizer.White;
            MinimizeBoxHoverColor = IronideColorizer.Teal;
            MaximizeBoxHoverColor = IronideColorizer.Teal;
            TitlebarHeight = 20;
            Sizable = false;

            #endregion

            #region tip

            tip = new IronideToolTip();
            tip.BorderColor = Color.Transparent;
            tip.BackColor = Color.Teal;
            tip.BackColor2 = tip.BackColor;
            tip.ForeColor = Color.White;

            #endregion

            #region LeftPanel

            leftPanel = new IronidePanel();
            leftPanel.BackColor = TitlebarBackColor;
            leftPanel.BackColor2 = leftPanel.BackColor;
            leftPanel.BorderThickness = 0;
            leftPanel.Location = new Point(0,TitlebarHeight+6);
            leftPanel.Size = new Size(40,Height-leftPanel.Location.Y);
            leftPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top;
            Controls.Add(leftPanel);

            #endregion

            #region connectButton

            connectButton = new IronideButton();
            connectButton.Location = new Point(4,10);
            connectButton.Size = new Size(leftPanel.Width-8,30);
            connectButton.BorderThickness = 0;
            connectButton.BackColor = Color.Transparent;
            connectButton.BackColor2 = connectButton.BackColor;
            connectButton.HoverColor = Color.FromArgb(70,70,70);
            connectButton.EnterColor = Color.FromArgb(100,100,100);
            connectButton.Image = Resources.Connect;
            connectButton.ImageLocation = new Point(2,2);
            connectButton.ImageSize = new Size(connectButton.Width-4,connectButton.Height-4);
            tip.SetToolTip(connectButton,"Connect to host.");
            leftPanel.Controls.Add(connectButton);

            #endregion

            #region hostButton

            hostButton = new IronideButton();
            hostButton.Location = new Point(connectButton.Location.X,
                connectButton.Location.Y+connectButton.Height+5);
            hostButton.Size = new Size(leftPanel.Width-8,30);
            hostButton.BorderThickness = connectButton.BorderThickness;
            hostButton.BackColor = connectButton.BackColor;
            hostButton.BackColor2 = hostButton.BackColor;
            hostButton.HoverColor = connectButton.HoverColor;
            hostButton.EnterColor = connectButton.EnterColor;
            hostButton.ImageLocation = connectButton.ImageLocation;
            hostButton.ImageSize = connectButton.ImageSize;
            hostButton.Image = Resources.Host;
            tip.SetToolTip(hostButton,"Become a host.");
            leftPanel.Controls.Add(hostButton);

            #endregion
        }
    }
}
