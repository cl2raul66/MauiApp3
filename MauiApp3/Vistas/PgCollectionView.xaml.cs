using MauiApp3.VistaModelos;

namespace MauiApp3.Vistas;

public partial class PgCollectionView : ContentPage
{
    public PgCollectionView(ListviewVistaModelo vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}