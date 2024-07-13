using BPUNGUILS6.Models;
using System.Net;
namespace BPUNGUILS6.Views;

public partial class VAgregar : ContentPage
{
	public VAgregar()
	{
		InitializeComponent();
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtEdad.Text);

            cliente.UploadValues("http://192.168.1.12/semana6/estudiantes.php", "POST", parametros);
            Navigation.PushAsync(new VEstudiante());
        }
        catch (Exception ex)
        {
            DisplayAlert("Alerta", ex.Message, "OK");

        }
    }
}