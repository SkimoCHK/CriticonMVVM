using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CriticonMVVM.ViewModel
{
    public class VMpage1 : BaseViewModel
    {
        #region VARIABLES
        private string _Nombre;
        private bool _Hombre;
        private bool _Mujer;
        private bool _Alto;
        private bool _Feo;
        private bool _Listo;
        private bool _Extra;
        private bool _Raro;
        private bool _Grande;
        private string _Mensaje;
        #endregion

        #region CONSTRUCTOR
        public VMpage1(INavigation navegation)
        {
            Navigation = navegation;
        }
        #endregion

        #region OBJETOS 
        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }
        public bool Hombre
        {
            get { return _Hombre; }
            set { SetValue(ref _Hombre, value); }
        }
        public bool Mujer
        {
            get { return _Mujer; }
            set { SetValue(ref _Mujer, value); }
        }
        public bool Alto
        {
            get { return _Alto; }
            set { SetValue(ref _Alto, value); }
        }
        public bool Feo
        {
            get { return _Feo; }
            set { SetValue(ref _Feo, value); }
        }
        public bool Listo
        {
            get { return _Listo; }
            set { SetValue(ref _Listo, value); }
        }
        public bool Extra
        {
            get { return _Extra; }
            set { SetValue(ref _Extra, value); }
        }
        public bool Raro
        {
            get { return _Raro; }
            set { SetValue(ref _Raro, value); }
        }
        public bool Grande
        {
            get { return _Grande; }
            set { SetValue(ref _Grande, value); }
        }
        public string Mensaje
        {
            get { return _Mensaje; }
            set { SetValue(ref _Mensaje, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Criticar()
        {
            Mensaje = "";
            if (Alto || Feo || Listo || Extra || Raro || Grande)
            {
                if (!string.IsNullOrEmpty(Nombre))
                {
                    if (Hombre)
                    {


                        Mensaje += Nombre;
                        Mensaje += " es hombre";
                        Mensaje += Alto ? ", alto" : "";
                        Mensaje += Feo ? ", feo" : "";
                        Mensaje += Listo ? ", listo" : "";
                        Mensaje += Extra ? ", extravagante" : "";
                        Mensaje += Raro ? ", raro" : "";
                        Mensaje += Grande ? ", grande" : "";
                        int Indice = Mensaje.LastIndexOf(", ");
                        string puntoBuscado = ", ";
                        Mensaje = Mensaje.Remove(Indice, puntoBuscado.Length).Insert(Indice, " y ");


                    }
                    else if (Mujer)
                    {

                        Mensaje += Nombre;
                        Mensaje += " es mujer";
                        Mensaje += Alto ? ", alta" : "";
                        Mensaje += Feo ? ", fea" : "";
                        Mensaje += Listo ? ", lista" : "";
                        Mensaje += Extra ? ", extravagante" : "";
                        Mensaje += Raro ? ", rara" : "";
                        Mensaje += Grande ? ", grande" : "";
                        int Indice = Mensaje.LastIndexOf(", ");
                        string puntoBuscado = ", ";
                        Mensaje = Mensaje.Remove(Indice, puntoBuscado.Length).Insert(Indice, " y ");
                    }
                    else
                    {
                        await DisplayAlert("Mensaje", "Por favor seleccione un genero", "salir");
                    }

                }
                else
                {
                    await DisplayAlert("Mensaje", "Por favor escriba un nombre", "salir");
                }
            }
            else
            {
                await DisplayAlert("Mensaje", "Tiene que seleccionar al menos una casilla", "Salir");
            }


        }

        #endregion

        #region COMANDOS
        public ICommand CriticarCommand => new Command (async() => await Criticar());
        
        #endregion


    }
}
