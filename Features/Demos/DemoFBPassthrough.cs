﻿using CicoLaboratory;

using StereoKit;
using StereoKit.Framework;

class DemoFBPassthrough : IStepper
{
    Pose windowPose = new Pose(0.5f, 0, -0.5f, Quat.LookDir(-1, 0, 1));

    Matrix descPose = Matrix.TR(-0.5f, 0, -0.5f, Quat.LookDir(1, 0, 1));
    string description = "Passthrough AR!";
    Matrix titlePose = Matrix.TRS(V.XYZ(-0.5f, 0.05f, -0.5f), Quat.LookDir(1, 0, 1), 2);
    string title = "FB Passthrough Extension";

    public bool Enabled => throw new System.NotImplementedException();

    public bool Initialize() { return true; }

    public void Shutdown() { }

    public void Step()
    {
        UI.WindowBegin("Passthrough Settings", ref windowPose);
        bool toggle = App.passthrough.EnabledPassthrough;
        UI.Label(App.passthrough.Available
            ? "Passthrough EXT available!"
            : "No passthrough EXT available :(");
        if (UI.Toggle("Passthrough", ref toggle))
            App.passthrough.EnabledPassthrough = toggle;
        UI.WindowEnd();

        Text.Add(title, titlePose);
        Text.Add(description, descPose, V.XY(0.4f, 0), TextFit.Wrap, TextAlign.TopCenter, TextAlign.TopLeft);
    }
}