using System.Collections.ObjectModel;
using CollectionViewHorizontal.Models;

namespace CollectionViewHorizontal.Views;

public partial class SixColumnsPage : ContentPage
{
    public ObservableCollection<Ubicacion> Ubicaciones { get; set; }
    public SixColumnsPage()
	{
		InitializeComponent();
        Ubicaciones = new ObservableCollection<Ubicacion>
        {
            new Ubicacion{Location="IR-01", Articulo="212401",  Pendiente=9} ,
            new Ubicacion{Location= "NA-E-005-20", Articulo="009852",  Pendiente= 8 },
            new Ubicacion{Location= "NA-K-200-00", Articulo="001088",  Pendiente= 1 }
        };
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        DeviceOrientationService deviceOrientationService = new DeviceOrientationService();
        deviceOrientationService.SetOrientation();
    }

    override protected void OnDisappearing()
    {
        base.OnDisappearing();
        DeviceOrientationService deviceOrientationService = new DeviceOrientationService();
        deviceOrientationService.RestSetOrientation();
    }

    public class DeviceOrientationService
    {
        public void SetOrientation()
        {
            #if ANDROID
                        Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Locked;
                        Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
            #endif
        }
        public void RestSetOrientation()
        {
            #if ANDROID
                        Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.RequestedOrientation = Android.Content.PM.ScreenOrientation.User;

            #endif
        }
    }
}