using AdaptiveProperties.MAUI.M;

namespace AdaptiveProperties.Demo.ViewModel
{
    public class ProduitListAccessibilityModeViewModel : ProduitListViewModel
    {
        public bool IsAccessibilityModeActivated
        {
            get => HomeAccessibilityModeViewModel.IsAccessibilityModeActivatedInternal;
            set
            {
                HomeAccessibilityModeViewModel.IsAccessibilityModeActivatedInternal = value;

                //Triggers the checking => apply/revert properties defined on the View side
                X.TriggerModeActivationChecking();
            }
        }
    }
}
