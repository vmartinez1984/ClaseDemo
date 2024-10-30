namespace HolaMundoMvvm
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new PersonaViewModel();
        }

       
    }

}
