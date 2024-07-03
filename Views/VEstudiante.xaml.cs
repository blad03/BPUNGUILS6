using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace BPUNGUILS6.Views;

public partial class VEstudiante : ContentPage
{
	private const string Url = "http://192.168.1.12/semana6/estudiantes.php";
	private readonly HttpClient cliente= new HttpClient();
	private ObservableCollection<Models.estudiantes> estud;
	public VEstudiante()
	{
		InitializeComponent();
		mostrar();
	}
    public async void mostrar()
    {
        var content = await cliente.GetStringAsync(Url);
        List<Models.estudiantes> mostrar = JsonConvert.DeserializeObject<List<Models.estudiantes>>(content);
        estud = new ObservableCollection<Models.estudiantes>(mostrar);
        listaEstudiantes.ItemsSource = estud;

    }
}