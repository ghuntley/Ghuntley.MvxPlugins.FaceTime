using System;
using Cirrious.CrossCore.Touch.Platform;
using MonoTouch.Foundation;

namespace Ghuntley.MvxPlugins.FaceTime.Touch
{
    public class FaceTimeTask : MvxTouchTask, IFaceTimeTask
    {
        public void MakeFaceTimeCall(string name, string number)
        {
            var url = new NSUrl("facetime:" + number.Replace(" ", String.Empty));
            DoUrlOpen(url);
        }
    }
}
