namespace Avance2Progreso.Views;
using Avance2Progreso.Models;
public partial class LoginPage : ContentPage
{
    private int _indiceCarrusel = 0;
    public LoginPage()
    {
        InitializeComponent();
        
    }
 
    /*private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        var user = ListaUsuarios.Authenticate(username, password);

        if (user != null)
        {
            // Navegar al AppShell con el rol correspondiente
            Application.Current.MainPage = new AppShell(user.Role);
        }
        else
        {
            ErrorMessage.Text = "Usuario o contraseņa incorrectos";
            ErrorMessage.IsVisible = true;
        }
    }*/
}