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
        ConteoLabel.Text = _contador.Conteo.ToString();
    }

	// Codigo del manejador de eventos
    private void OnContarButtonClicked(object sender, EventArgs e)
	{
		_contador.Contar();
		ConteoLabel.Text = _contador.Conteo.ToString();
	}

	private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
		_contador.Reiniciar();
        ConteoLabel.Text = _contador.Conteo.ToString();
    }
}
