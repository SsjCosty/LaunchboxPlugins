﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unbroken.LaunchBox.Plugins;
using Unbroken.LaunchBox.Plugins.Data;

namespace ExtraGameVideos
{
    public class VideoManager : IGameMenuItemPlugin
    {
        public bool SupportsMultipleGames => false;

        public string Caption => "Manage game videos...";

        public System.Drawing.Image IconImage => null;

        public bool ShowInLaunchBox => true;

        public bool ShowInBigBox => false;

        public bool GetIsValidForGame(IGame selectedGame)
        {
            return true;
        }

        public bool GetIsValidForGames(IGame[] selectedGames)
        {
            return false;
        }

        public void OnSelected(IGame selectedGame)
        {
            var form = new VideoManagerForm(selectedGame);
            form.ShowDialog();
            form.Dispose();
        }

        public void OnSelected(IGame[] selectedGames)
        {
            return;
        }
    }
}
