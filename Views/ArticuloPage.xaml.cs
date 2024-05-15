using System.Collections.ObjectModel;
using CollectionViewHorizontal.Models;
namespace CollectionViewHorizontal.Views;

public partial class ArticuloPage : ContentPage
{
    public ObservableCollection<Articulos> Articulo { get; set; }
    public ArticuloPage()
	{
		InitializeComponent();
        Articulo = new ObservableCollection<Articulos>
        {
            new Articulos{Name="212401", Cantidad=0, Lectura=3, Diferencia=3},
            new Articulos { Name = "456767", Cantidad = 0, Lectura = 2, Diferencia = 2 },
            new Articulos { Name = "552234", Cantidad = 40320, Lectura = 3, Diferencia = -40320 }
        };
        BindingContext = this;
    }
}