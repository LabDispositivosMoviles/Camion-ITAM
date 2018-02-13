using ClasesModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Camion_ITAM
{


	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //listaHorariosSantaTeresa.Header = new Titulo { Izquierda = "Hola", Derecha = "Adios" };

            listaHorariosSantaTeresa.ItemsSource = new List<Horario>
            {
                new Horario { Salida = "06:55", Llegada = "07:15" },
                new Horario { Salida = "07:50", Llegada = "08:15" },
                new Horario { Salida = "08:50", Llegada = "09:15" },
                new Horario { Salida = "09:50", Llegada = "10:15" },
                new Horario { Salida = "10:50", Llegada = "11:15" },
                new Horario { Salida = "11:50", Llegada = "12:15" },
                new Horario { Salida = "12:50", Llegada = "13:15" },
                new Horario { Salida = "13:40", Llegada = "14:15" },
                new Horario { Salida = "-", Llegada = "-" },
                new Horario { Salida = "16:00", Llegada = "16:15" },
                new Horario { Salida = "17:00", Llegada = "17:15" },
                new Horario { Salida = "18:00", Llegada = "18:15" },
                new Horario { Salida = "18:45", Llegada = "19:05" }
            };

            listaHorariosMetro.ItemsSource = new List<Horario>
            {
                new Horario { Salida = "06:20", Llegada = "06:40" },
                new Horario { Salida = "07:20", Llegada = "07:40" },
                new Horario { Salida = "08:20", Llegada = "08:40" },
                new Horario { Salida = "09:20", Llegada = "09:40" },
                new Horario { Salida = "10:20", Llegada = "10:40" },
                new Horario { Salida = "11:30", Llegada = "11:40" },
                new Horario { Salida = "12:20", Llegada = "12:40" },
                new Horario { Salida = "13:20", Llegada = "13:40" },
                new Horario { Salida = "14:30", Llegada = "14:40" },
                new Horario { Salida = "15:20", Llegada = "15:40" },
                new Horario { Salida = "16:20", Llegada = "16:40" },
                new Horario { Salida = "17:20", Llegada = "17:40" },
                new Horario { Salida = "18:20", Llegada = "18:40" },
                new Horario { Salida = "19:20", Llegada = "19:40" },
                new Horario { Salida = "20:30", Llegada = "20:40" },
                new Horario { Salida = "21:20", Llegada = "21:40" },
                new Horario { Salida = "*22:10", Llegada = "" },












            };


        }
	}


}
