﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remotely_ScreenCast.Core.Capture
{
    public interface ICapturer : IDisposable
    {
        bool CaptureFullscreen { get; set; }
        Bitmap CurrentFrame { get; set; }
        Rectangle CurrentScreenBounds { get; }
        Bitmap PreviousFrame { get; set; }
        event EventHandler<Rectangle> ScreenChanged;
        int SelectedScreen { get; }
        void SetSelectedScreen(int screenNumber);
        int GetScreenCount();
        double GetVirtualScreenHeight();
        double GetVirtualScreenWidth();

        void Capture();
        void Init();
    }
}
