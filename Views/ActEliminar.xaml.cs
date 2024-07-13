using BPUNGUILS6.Models;
using System.Net;
using System.Xml;

namespace BPUNGUILS6.Views;

public partial class ActEliminar : ContentPage
{
    public ActEliminar(estudiantes datos)
    {
        InitializeComponent();
        txtCodigo.Text = datos.codigo.ToString();
        txtNombre.Text = datos.nombre;
        txtApellido.Text = datos.apellido;
        txtEdad.Text = datos.edad.ToString();
    }

    private void btnActualiza_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            string sql = "codigo=" + txtCodigo.Text + "&nombre=" + txtNombre.Text + "&apellido=" + txtApellido.Text +"&edad=" + txtEdad.Text;
            cliente.UploadString("http://192.168.1.12/Semana6/estudiantes.php" + "?" + sql, "PUT", string.Empty);
            Navigation.PushAsync(new VEstudiante());
        }
        catch (Exception ex)
        {
            DisplayAlert("Alerta", ex.Message,"OK");
        }
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            string sql = "codigo=" + txtCodigo.Text;
            cliente.UploadString("http://192.168.1.12/Semana6/estudiantes.php" + "?" + sql, "DELETE",  string.Empty);
            Navigation.PushAsync(new VEstudiante());

        }
        catch (Exception ex)
        {
            DisplayAlert("Alerta", ex.Message, "OK");   
        }
    }
}