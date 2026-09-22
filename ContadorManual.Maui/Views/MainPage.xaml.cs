using ContadorManual.Maui.Models;

namespace ContadorManual.Maui.Views;

public partial class MainPage : ContentPage
{
	private Contador _contador;

	// Constructor
	public MainPage()
	{
		// Inicializar el contador
		InitializeComponent();
		_contador = new Contador();
		BindingContext = _contador; // Lo que estoy haciendo es que mi destino me esta sirviendo para decir quien es el objeto fuente del enlace
    }

	// Codigo del manejador de eventos
    private void OnContarButtonClicked(object sender, EventArgs e)
	{
		_contador.Contar();
	}

	private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
		_contador.Reiniciar();
    }
}
