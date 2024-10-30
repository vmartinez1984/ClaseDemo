namespace HolaMundo
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre;

            nombre = EntryNombre.Text;

            Guardar(nombre);
        }

        /// <summary>
        /// Aqui es dondede se registran los datos a traves servicio
        /// </summary>
        /// <param name="nombre"></param>
        private void Guardar(string nombre)
        {
            DisplayAlert("Datos registrados", $"Se registro {nombre}", "Ok");
        }
    }

}
