using MeusEventos.WP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusEventos.WP
{
    public class HomeViewModel
    {
        public ObservableCollection<Evento> Eventos { get; set; }
        public ObservableCollection<Evento> EventosEmSalvador { get; set; }
        public ObservableCollection<Evento> EventosOnline { get; set; }
        public HomeViewModel()
        {
            Eventos = new ObservableCollection<Evento>(Evento.Eventos);
            EventosEmSalvador = new ObservableCollection<Evento>(Evento.Eventos.Where(x => x.Local == "Salvador"));
            EventosOnline = new ObservableCollection<Evento>(Evento.Eventos.Where(x => x.Local == "Online"));
        }
    }
}
