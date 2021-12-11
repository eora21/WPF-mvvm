using GalaSoft.MvvmLight.Ioc;

namespace mvvmlight_Net5.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get => SimpleIoc.Default.GetInstance<MainViewModel>();
        }
    }
}
