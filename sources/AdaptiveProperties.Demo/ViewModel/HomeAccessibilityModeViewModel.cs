using AdaptiveProperties.MAUI.M;

namespace AdaptiveProperties.Demo.ViewModel
{
    public class HomeAccessibilityModeViewModel : HomeViewModel
    {
        internal static bool IsAccessibilityModeActivatedInternal;

        public bool IsAccessibilityModeActivated
        {
            get => IsAccessibilityModeActivatedInternal;
            set
            {
                IsAccessibilityModeActivatedInternal = value;

                //Triggers the checking => apply/revert properties defined on the View side
                X.TriggerModeActivationChecking();
            }
        }

        public HomeAccessibilityModeViewModel()
        {
            //Define the Func that defines if the custom mode is activated
            X.SetModeActivationChecking(() => IsAccessibilityModeActivated);

            //Other custom modes can be defined
            //X2.SetModeActivationChecking(...)
            //X3.SetModeActivationChecking(...)
        }
    }
}
