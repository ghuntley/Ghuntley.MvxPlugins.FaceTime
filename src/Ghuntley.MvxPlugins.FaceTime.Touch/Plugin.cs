
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;

namespace Ghuntley.MvxPlugins.FaceTime.Touch
{
    public class Plugin : IMvxPlugin          
    {
        public void Load()
        {
            Mvx.RegisterType<IFaceTimeTask, FaceTimeTask>();
        }
    }
}