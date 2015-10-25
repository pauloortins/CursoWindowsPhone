using MeusEventosCurso.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MeusEventosCurso
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EventoPage : Page
    {
        private Evento _evento;

        public EventoPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.DataContext = e.Parameter;
            _evento = e.Parameter as Evento;

            foreach (var trilha in _evento.Trilhas)
            {
                var trilhaControl = new TrilhaControl();
                trilhaControl.DataContext = trilha;

                this.pivot.Items.Add(new PivotItem()
                {
                    Header = trilha.Nome.ToLower(),
                    Content = trilhaControl
                });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
