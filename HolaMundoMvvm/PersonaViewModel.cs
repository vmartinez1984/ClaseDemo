using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace HolaMundoMvvm
{
    /// <summary>
    /// Clase que se encarga de enlazar (Binding) el modelo (PersonaModel) con la vista (MainPage.xml)
    /// </summary>
    internal class PersonaViewModel: INotifyPropertyChanged
    {
        /// <summary>
        /// Modelo
        /// </summary>
        public PersonaModel Persona { get; set; }

        /// <summary>
        /// Con este elemento indicaremo el resultado del la operación guardar
        /// </summary>
        public string Mensaje { get; set; }

        /// <summary>
        /// Es el equivalente del evento clicked
        /// </summary>
        public ICommand GuardarCommand { get; }

        /// <summary>
        /// Constructor, aqui inicializaremos algunas propiedades
        /// </summary>
        public PersonaViewModel()
        {
            //Instanciamos el objeto
            Persona = new PersonaModel();

            //Enlazamos con el command el método o función
            GuardarCommand = new Command(Guardar);
        }

        /// <summary>
        /// Para fines del ejemplo solo se formateara una cadena, 
        /// pero aqui se puede enviar al servicio para guardar u otro para procesar los datos.
        /// </summary>    
        private void Guardar()
        {
            Mensaje = $"Ha sido registrado: {Persona.Nombre}";

            //Notificamos el cambio de la variable
            OnPropertyChanged(nameof(Mensaje));
        }

        /// <summary>
        /// Elemento de la interfaz para hacer la actualización de los datos y el modelo
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Elemento de para hacer la actualización de los datos y el modelo
        /// </summary>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
