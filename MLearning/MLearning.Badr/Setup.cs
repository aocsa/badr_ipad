using UIKit;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.CrossCore;
using MLearning.Core.File;
using MLearning.UnifiedTouch.File;
using MLearning.Core;

namespace MLearning.Badr
{
	public class Setup : MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
		{
		}


		protected override void InitializeLastChance()
		{

			base.PerformBootstrapActions();     
			Mvx.RegisterSingleton<IAsyncStorageService>(new AsyncStorageTouchService());
			base.InitializeLastChance();
		}


		protected override IMvxApplication CreateApp ()
		{
			return new MLearning.Core.App();
		}
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
	}
}