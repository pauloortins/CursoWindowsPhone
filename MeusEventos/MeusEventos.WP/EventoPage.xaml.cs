using MeusEventos.WP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MeusEventos.WP
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
            var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Text01);            

            var tileText = tileXml.GetElementsByTagName("text");
            (tileText[0] as XmlElement).InnerText = _evento.Periodo;
            (tileText[1] as XmlElement).InnerText = _evento.Nome;
            (tileText[2] as XmlElement).InnerText = _evento.Local;

            var tileNotification = new TileNotification(tileXml);
            TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
        }
    }
}
