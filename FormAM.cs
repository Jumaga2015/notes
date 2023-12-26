using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AM.Logs;
using Humanizer;
using JsonFlatFileDataStore;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AM.UI
{
    public partial class FormAM : Form
    {
        private DataStore store; //Base de datos 
        private IDocumentCollection<BusquedaInfo> collectionBusquedas;

        public FormAM()
        {
            InitializeComponent();
            listBoxHasta.SelectedItem = "Ahora";
            listBoxDesde.SelectedItem = "Semana";

            store = new DataStore($"{Globals.Path}MainDB.json", keyProperty: "Nombre");
            collectionBusquedas = store.GetCollection<BusquedaInfo>();
        }

        private void listBoxOffsetDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxDesde.SelectedItem.ToString())  //TODO: Quitar fines de semana
            {
                case "Ayer": dateTimePickerDesde.Value = DateTime.Now.AddDays(-1); break;
                case "3Días": dateTimePickerDesde.Value = DateTime.Now.AddDays(-3); break;
                case "5Días": dateTimePickerDesde.Value = DateTime.Now.AddDays(-5); break;
                case "Semana": dateTimePickerDesde.Value = DateTime.Now.AddDays(-7); break;
                case "Nada":
                default:
                    return;
            }
        }

        private void listBoxOffsetHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBoxHasta.SelectedItem.ToString())  //TODO: Quitar fines de semana
            {
                case "Ahora": dateTimePickerHasta.Value = DateTime.Now; break;
                case "1Días": dateTimePickerHasta.Value = DateTime.Now.AddDays(-1); break;
                case "2Días": dateTimePickerHasta.Value = DateTime.Now.AddDays(-2); break;
                case "3Días": dateTimePickerHasta.Value = DateTime.Now.AddDays(-3); break;
                case "5Días": dateTimePickerHasta.Value = DateTime.Now.AddDays(-5); break;
                case "Semana": dateTimePickerHasta.Value = DateTime.Now.AddDays(-7); break;
                case "Nada":
                default:
                    return;
            }
        }


        private void buttonDale_Click(object sender, EventArgs e)
        {
            if (this.textBoxFiltroFiles.Text != string.Empty)
            {
                //generar un metodo que pase los valores de los controles a la clase busquedaInfo
                BusquedaInfo busquedaInfo = new BusquedaInfo() { Nombre = this.textBoxNombre.Text,
                                                             Filtro = this.textBoxFiltroFiles.Text,
                                                             Desde = this.dateTimePickerDesde.Value,
                                                             Hasta = this.dateTimePickerHasta.Value,
                                                             IndexCriteria = new CriteriaIndex() { Pattern = this.textBoxRegexPattern.Text },
                                                             SearchCriteria = new CriteriaSearch() { Pattern = this.textBoxBuscarContext.Text}
                                                            };

                //Grabar en la base de datos si no existe
                if (!collectionBusquedas.AsQueryable().Any(b => b.Nombre == busquedaInfo.Nombre))
                {
                    collectionBusquedas.InsertOne(busquedaInfo);
                } else
                {
                    collectionBusquedas.UpdateOne(busquedaInfo.Nombre, busquedaInfo);
                }

                //Generar un metodo que pase los valores de la clase busquedaInfo a la clase busqueda
                Busqueda busqueda = new Busqueda(this.textBoxNombre.Text,
                                                 this.textBoxFiltroFiles.Text,
                                                 this.dateTimePickerDesde.Value,
                                                 this.dateTimePickerHasta.Value,
                                                 new CriteriaIndex() { Pattern = this.textBoxRegexPattern.Text,
                                                     ValuePattern = this.textBoxRegexReplace.Text },
                                                 new CriteriaSearch() { Pattern = this.textBoxBuscarContext.Text}
                                                 );

                busqueda.FileFound += Busqueda_FilesFound;

                busqueda.Do();
            }
        }

        private void Busqueda_FilesFound(object sender, FileLogInfo file)
        {
              UpdateListViewItemEntryAsync(file);
        }
         
        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.listBoxHasta.SelectedItem.ToString() == "Ahora")
                {
                this.dateTimePickerHasta.Value = DateTime.Now;
            }
        }

        private void UpdateListViewItemEntryAsync(FileLogInfo file)
        {
            listViewFicheros.BeginInvoke((MethodInvoker)(() => UpdateListViewItemEntry(file)));
        }

        private void UpdateListViewItemEntry(FileLogInfo file)
        {
            string key = file.Key;

            if (!listViewFicheros.Items.ContainsKey(key))
            {
                ListViewItem listViewItem = new ListViewItem(key)
                {
                    Name = key,
                    UseItemStyleForSubItems = false,
                    Tag = file,
                };

                listViewItem.SubItems.Add(file.LastWriteTime.ToString()).Name="LastWrite";
                listViewItem.SubItems.Add(file.LastWriteTime.Humanize().Replace("Hace","")).Name="HumanizeLastWrite";
                listViewItem.SubItems.Add(file.IsIndexed.ToString()).Name="Indexed";

                listViewFicheros.Items.Add(listViewItem);
            }
            else
            {
                ListViewItem listViewItem = listViewFicheros.Items[key];
                listViewItem.SubItems["LastWrite"].Text = file.LastWriteTime.ToString();
                listViewItem.SubItems["HumanizeLastWrite"].Text = file.LastWriteTime.Humanize().Replace("Hace", "");
                listViewItem.SubItems["Indexed"].Text = file.IsIndexed.ToString();
            }
        }

        private IDisposable textBoxKeyPresses;
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKeyPresses != null)
            {
                textBoxKeyPresses.Dispose();
            }

            textBoxKeyPresses = Observable.FromEventPattern<KeyPressEventArgs>(textBoxNombre, "KeyPress")
            .Throttle(TimeSpan.FromSeconds(1))
                .TakeUntil(Observable.FromEventPattern<EventArgs>(textBoxNombre, "TextChanged"))
                .Subscribe(args =>
                {
                    //Leer de la base de datos
                    var busquedaInfo = collectionBusquedas.Find(x => x.Nombre == textBoxNombre.Text).First();
                    if (busquedaInfo != null)
                    {
                        textBoxFiltroFiles.Text = busquedaInfo.Filtro;
                        dateTimePickerDesde.Value = busquedaInfo.Desde;
                        dateTimePickerHasta.Value = busquedaInfo.Hasta;
                        textBoxRegexPattern.Text = busquedaInfo.IndexCriteria.Pattern;
                        textBoxRegexReplace.Text = busquedaInfo.IndexCriteria.ValuePattern;
                        textBoxBuscarContext.Text = busquedaInfo.SearchCriteria.Pattern;
                    }
                });
        }
    }
}
