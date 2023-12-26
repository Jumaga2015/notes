
namespace AM.UI
{
    partial class FormAM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxFiltroFiles = new System.Windows.Forms.TextBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.listViewFicheros = new System.Windows.Forms.ListView();
            this.columnHeaderFichero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFechaHumana = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOcurrencias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxDesde = new System.Windows.Forms.ListBox();
            this.listBoxHasta = new System.Windows.Forms.ListBox();
            this.labelIndexar = new System.Windows.Forms.Label();
            this.textBoxRegexPattern = new System.Windows.Forms.TextBox();
            this.textBoxBuscarIndex = new System.Windows.Forms.TextBox();
            this.labelBuscarIndex = new System.Windows.Forms.Label();
            this.textBoxRegexReplace = new System.Windows.Forms.TextBox();
            this.textBoxBuscarContext = new System.Windows.Forms.TextBox();
            this.labelBuscarContext = new System.Windows.Forms.Label();
            this.buttonDale = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(13, 13);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(76, 10);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(194, 22);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Text = "default";
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxFiltroFiles
            // 
            this.textBoxFiltroFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFiltroFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFiltroFiles.Location = new System.Drawing.Point(321, 10);
            this.textBoxFiltroFiles.Name = "textBoxFiltroFiles";
            this.textBoxFiltroFiles.Size = new System.Drawing.Size(754, 22);
            this.textBoxFiltroFiles.TabIndex = 3;
            this.textBoxFiltroFiles.Text = "C:\\Users\\jumag\\Documents\\Source\\Avanade\\Miralogs\\Data\\file*.log";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.Location = new System.Drawing.Point(280, 13);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(36, 16);
            this.labelFiltro.TabIndex = 2;
            this.labelFiltro.Text = "Filtro";
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.CustomFormat = "ddMMMMyyyy HH:mm:ss";
            this.dateTimePickerDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(76, 37);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(239, 22);
            this.dateTimePickerDesde.TabIndex = 4;
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaDesde.Location = new System.Drawing.Point(21, 43);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(48, 16);
            this.labelFechaDesde.TabIndex = 5;
            this.labelFechaDesde.Text = "Desde";
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaHasta.Location = new System.Drawing.Point(21, 68);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(43, 16);
            this.labelFechaHasta.TabIndex = 7;
            this.labelFechaHasta.Text = "Hasta";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.CustomFormat = "ddMMMMyyyy HH:mm:ss";
            this.dateTimePickerHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(76, 63);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(239, 22);
            this.dateTimePickerHasta.TabIndex = 6;
            // 
            // listViewFicheros
            // 
            this.listViewFicheros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFicheros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFichero,
            this.columnHeaderFecha,
            this.columnHeaderFechaHumana,
            this.columnHeaderValido,
            this.columnHeaderOcurrencias});
            this.listViewFicheros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewFicheros.GridLines = true;
            this.listViewFicheros.HideSelection = false;
            this.listViewFicheros.Location = new System.Drawing.Point(16, 156);
            this.listViewFicheros.Name = "listViewFicheros";
            this.listViewFicheros.Size = new System.Drawing.Size(1059, 347);
            this.listViewFicheros.TabIndex = 8;
            this.listViewFicheros.UseCompatibleStateImageBehavior = false;
            this.listViewFicheros.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFichero
            // 
            this.columnHeaderFichero.Text = "Fichero";
            this.columnHeaderFichero.Width = 200;
            // 
            // columnHeaderFecha
            // 
            this.columnHeaderFecha.Text = "Fecha";
            this.columnHeaderFecha.Width = 138;
            // 
            // columnHeaderFechaHumana
            // 
            this.columnHeaderFechaHumana.Text = "FechaH";
            this.columnHeaderFechaHumana.Width = 113;
            // 
            // columnHeaderValido
            // 
            this.columnHeaderValido.Text = "Indexado";
            this.columnHeaderValido.Width = 57;
            // 
            // columnHeaderOcurrencias
            // 
            this.columnHeaderOcurrencias.Text = "Ocurrencias";
            this.columnHeaderOcurrencias.Width = 137;
            // 
            // listBoxDesde
            // 
            this.listBoxDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDesde.FormattingEnabled = true;
            this.listBoxDesde.IntegralHeight = false;
            this.listBoxDesde.ItemHeight = 18;
            this.listBoxDesde.Items.AddRange(new object[] {
            "Nada",
            "Ayer",
            "3Día",
            "5Días",
            "Semana"});
            this.listBoxDesde.Location = new System.Drawing.Point(321, 38);
            this.listBoxDesde.Name = "listBoxDesde";
            this.listBoxDesde.Size = new System.Drawing.Size(140, 20);
            this.listBoxDesde.TabIndex = 9;
            this.listBoxDesde.SelectedIndexChanged += new System.EventHandler(this.listBoxOffsetDesde_SelectedIndexChanged);
            // 
            // listBoxHasta
            // 
            this.listBoxHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHasta.FormattingEnabled = true;
            this.listBoxHasta.IntegralHeight = false;
            this.listBoxHasta.ItemHeight = 18;
            this.listBoxHasta.Items.AddRange(new object[] {
            "Ahora",
            "1Día",
            "2Días",
            "3Días",
            "5Días",
            "Semana"});
            this.listBoxHasta.Location = new System.Drawing.Point(321, 64);
            this.listBoxHasta.Name = "listBoxHasta";
            this.listBoxHasta.Size = new System.Drawing.Size(140, 20);
            this.listBoxHasta.TabIndex = 10;
            this.listBoxHasta.SelectedIndexChanged += new System.EventHandler(this.listBoxOffsetHasta_SelectedIndexChanged);
            // 
            // labelIndexar
            // 
            this.labelIndexar.AutoSize = true;
            this.labelIndexar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexar.Location = new System.Drawing.Point(467, 40);
            this.labelIndexar.Name = "labelIndexar";
            this.labelIndexar.Size = new System.Drawing.Size(51, 16);
            this.labelIndexar.TabIndex = 11;
            this.labelIndexar.Text = "Indexar";
            // 
            // textBoxRegexPattern
            // 
            this.textBoxRegexPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegexPattern.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegexPattern.Location = new System.Drawing.Point(525, 37);
            this.textBoxRegexPattern.Name = "textBoxRegexPattern";
            this.textBoxRegexPattern.Size = new System.Drawing.Size(352, 20);
            this.textBoxRegexPattern.TabIndex = 12;
            this.textBoxRegexPattern.Text = "Orden: (?\'orden\'000\\d{7})";
            // 
            // textBoxBuscarIndex
            // 
            this.textBoxBuscarIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarIndex.Location = new System.Drawing.Point(554, 63);
            this.textBoxBuscarIndex.Name = "textBoxBuscarIndex";
            this.textBoxBuscarIndex.Size = new System.Drawing.Size(352, 22);
            this.textBoxBuscarIndex.TabIndex = 14;
            // 
            // labelBuscarIndex
            // 
            this.labelBuscarIndex.AutoSize = true;
            this.labelBuscarIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarIndex.Location = new System.Drawing.Point(467, 66);
            this.labelBuscarIndex.Name = "labelBuscarIndex";
            this.labelBuscarIndex.Size = new System.Drawing.Size(81, 16);
            this.labelBuscarIndex.TabIndex = 13;
            this.labelBuscarIndex.Text = "BuscarIndex";
            // 
            // textBoxRegexReplace
            // 
            this.textBoxRegexReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRegexReplace.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegexReplace.Location = new System.Drawing.Point(883, 37);
            this.textBoxRegexReplace.Name = "textBoxRegexReplace";
            this.textBoxRegexReplace.Size = new System.Drawing.Size(192, 20);
            this.textBoxRegexReplace.TabIndex = 15;
            this.textBoxRegexReplace.Text = "${orden}";
            // 
            // textBoxBuscarContext
            // 
            this.textBoxBuscarContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarContext.Location = new System.Drawing.Point(554, 91);
            this.textBoxBuscarContext.Name = "textBoxBuscarContext";
            this.textBoxBuscarContext.Size = new System.Drawing.Size(352, 22);
            this.textBoxBuscarContext.TabIndex = 17;
            // 
            // labelBuscarContext
            // 
            this.labelBuscarContext.AutoSize = true;
            this.labelBuscarContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarContext.Location = new System.Drawing.Point(499, 94);
            this.labelBuscarContext.Name = "labelBuscarContext";
            this.labelBuscarContext.Size = new System.Drawing.Size(49, 16);
            this.labelBuscarContext.TabIndex = 16;
            this.labelBuscarContext.Text = "Buscar";
            // 
            // buttonDale
            // 
            this.buttonDale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDale.Location = new System.Drawing.Point(16, 118);
            this.buttonDale.Name = "buttonDale";
            this.buttonDale.Size = new System.Drawing.Size(78, 32);
            this.buttonDale.TabIndex = 18;
            this.buttonDale.Text = "Dale";
            this.buttonDale.UseVisualStyleBackColor = true;
            this.buttonDale.Click += new System.EventHandler(this.buttonDale_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 515);
            this.Controls.Add(this.buttonDale);
            this.Controls.Add(this.textBoxBuscarContext);
            this.Controls.Add(this.labelBuscarContext);
            this.Controls.Add(this.textBoxRegexReplace);
            this.Controls.Add(this.textBoxBuscarIndex);
            this.Controls.Add(this.labelBuscarIndex);
            this.Controls.Add(this.textBoxRegexPattern);
            this.Controls.Add(this.labelIndexar);
            this.Controls.Add(this.listBoxHasta);
            this.Controls.Add(this.listBoxDesde);
            this.Controls.Add(this.listViewFicheros);
            this.Controls.Add(this.labelFechaHasta);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.labelFechaDesde);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.textBoxFiltroFiles);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormAM";
            this.Text = "MiraLogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxFiltroFiles;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label labelFechaDesde;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.ListView listViewFicheros;
        private System.Windows.Forms.ColumnHeader columnHeaderFichero;
        private System.Windows.Forms.ColumnHeader columnHeaderFecha;
        private System.Windows.Forms.ColumnHeader columnHeaderFechaHumana;
        private System.Windows.Forms.ColumnHeader columnHeaderValido;
        private System.Windows.Forms.ListBox listBoxDesde;
        private System.Windows.Forms.ListBox listBoxHasta;
        private System.Windows.Forms.Label labelIndexar;
        private System.Windows.Forms.TextBox textBoxRegexPattern;
        private System.Windows.Forms.TextBox textBoxBuscarIndex;
        private System.Windows.Forms.Label labelBuscarIndex;
        private System.Windows.Forms.TextBox textBoxRegexReplace;
        private System.Windows.Forms.TextBox textBoxBuscarContext;
        private System.Windows.Forms.Label labelBuscarContext;
        private System.Windows.Forms.Button buttonDale;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColumnHeader columnHeaderOcurrencias;
    }
}

