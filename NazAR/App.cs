﻿using NazAR.Core.Manager;
using NazAR.Extension;
using StereoKit;
using StereoKit.Framework;

namespace NazAR
{
    public class App : IStepper
    {
        public App()
        {
            SK.AddStepper<CoreFeatures>();
            SK.AddStepper<ExtensionFeatures>();
        }

        public SKSettings Settings => new()
        {
            appName = "nazar.OS",
            assetsFolder = "Assets",
            displayPreference = DisplayMode.MixedReality
        };

        public bool Enabled => true;

        public bool Initialize()
        {
            return true;
        }

        public void Step()
        {
        }

        public void Shutdown()
        {
        }
    }
}