using System.Collections.ObjectModel;
using CollectionViewHorizontal.Models;
namespace CollectionViewHorizontal.Views;

public partial class UbicacionPage : ContentPage
{
    public ObservableCollection<Ubicacion> Ubicaciones { get; set; }
    public UbicacionPage()
	{
		InitializeComponent();
        Ubicaciones = new ObservableCollection<Ubicacion>
        {
            new Ubicacion{Location="IR-01", Articulo="212401",  Pendiente=9} ,
            new Ubicacion{Location= "NA-E-005-20", Articulo="009852",  Pendiente= 8 },
            new Ubicacion {Location= "NA-K-200-00", Articulo="001088",  Pendiente= 1 } 
        };
        BindingContext = this;
    }
}