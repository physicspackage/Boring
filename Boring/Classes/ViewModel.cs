using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Store;
using Windows.UI.Xaml;
using WindowsStore.FalafelUtility;

namespace Boring
{
    public class ViewModel : BindableBase
    {
        public ViewModel()
        {
            BugCount = 1000;
            BugCountMax = 12000;
            BugSpeedMax = 4;
            BugFadeAway = 10;
            BugMode = Boring.BugMode.Active;
            ShowFPS = true;
        }

        int bugCount;
        public int BugCount
        {
            get { return this.bugCount; }
            set { this.SetProperty(ref this.bugCount, value); }
        }

        int bugCountMax;
        public int BugCountMax
        {
            get { return this.bugCountMax; }
            set { this.SetProperty(ref this.bugCountMax, value); }
        }

        int bugSpeedMax;
        public int BugSpeedMax
        {
            get { return this.bugSpeedMax; }
            set { this.SetProperty(ref this.bugSpeedMax, value); }
        }

        int bugFadeAway;
        public int BugFadeAway
        {
            get { return this.bugFadeAway; }
            set { this.SetProperty(ref this.bugFadeAway, value); }
        }

        bool showFPS;
        public bool ShowFPS
        {
            get { return this.showFPS; }
            set { this.SetProperty(ref this.showFPS, value); }
        }

        BugMode bugMode;
        public BugMode BugMode
        {
            get { return this.bugMode; }
            set { this.SetProperty(ref this.bugMode, value); }
        }

        FrameworkElement selectedTile;
        public FrameworkElement SelectedTile
        {
            get { return this.selectedTile; }
            set { this.SetProperty(ref this.selectedTile, value); }
        }

    }
}
