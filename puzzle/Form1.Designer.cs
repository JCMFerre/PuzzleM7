namespace puzzle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPorTres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPorCuatro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPorCinco = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSonido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTemps = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentsLimitatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMaxMov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMovActuales = new System.Windows.Forms.Label();
            this.timerPartida = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelTempsRestant = new System.Windows.Forms.Label();
            this.progressBarTiempo = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(11, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jugarToolStripMenuItem,
            this.opcionsToolStripMenuItem,
            this.fAQsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jugarToolStripMenuItem
            // 
            this.jugarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dificultadToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.sortirToolStripMenuItem1});
            this.jugarToolStripMenuItem.Name = "jugarToolStripMenuItem";
            this.jugarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.jugarToolStripMenuItem.Text = "Jugar";
            // 
            // dificultadToolStripMenuItem
            // 
            this.dificultadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPorTres,
            this.menuPorCuatro,
            this.menuPorCinco});
            this.dificultadToolStripMenuItem.Name = "dificultadToolStripMenuItem";
            this.dificultadToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.dificultadToolStripMenuItem.Text = "Dificultat";
            // 
            // menuPorTres
            // 
            this.menuPorTres.Checked = true;
            this.menuPorTres.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuPorTres.Name = "menuPorTres";
            this.menuPorTres.Size = new System.Drawing.Size(91, 22);
            this.menuPorTres.Text = "3x3";
            this.menuPorTres.Click += new System.EventHandler(this.cambiarTableroEvento);
            // 
            // menuPorCuatro
            // 
            this.menuPorCuatro.Name = "menuPorCuatro";
            this.menuPorCuatro.Size = new System.Drawing.Size(91, 22);
            this.menuPorCuatro.Text = "4x4";
            this.menuPorCuatro.Click += new System.EventHandler(this.cambiarTableroEvento);
            // 
            // menuPorCinco
            // 
            this.menuPorCinco.Name = "menuPorCinco";
            this.menuPorCinco.Size = new System.Drawing.Size(91, 22);
            this.menuPorCinco.Text = "5x5";
            this.menuPorCinco.Click += new System.EventHandler(this.cambiarTableroEvento);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarEvento);
            // 
            // sortirToolStripMenuItem1
            // 
            this.sortirToolStripMenuItem1.Name = "sortirToolStripMenuItem1";
            this.sortirToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.sortirToolStripMenuItem1.Text = "Sortir";
            this.sortirToolStripMenuItem1.Click += new System.EventHandler(this.sortirEvent);
            // 
            // opcionsToolStripMenuItem
            // 
            this.opcionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSonido,
            this.menuTemps,
            this.movimentsLimitatsToolStripMenuItem});
            this.opcionsToolStripMenuItem.Name = "opcionsToolStripMenuItem";
            this.opcionsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.opcionsToolStripMenuItem.Text = "Opcions";
            // 
            // menuSonido
            // 
            this.menuSonido.Name = "menuSonido";
            this.menuSonido.Size = new System.Drawing.Size(176, 22);
            this.menuSonido.Text = "Só (Activat)";
            this.menuSonido.Click += new System.EventHandler(this.cambiarEstadoSonido);
            // 
            // menuTemps
            // 
            this.menuTemps.Name = "menuTemps";
            this.menuTemps.Size = new System.Drawing.Size(176, 22);
            this.menuTemps.Text = "Temps (Activat)";
            this.menuTemps.Click += new System.EventHandler(this.cambiarEstadoTiempo);
            // 
            // movimentsLimitatsToolStripMenuItem
            // 
            this.movimentsLimitatsToolStripMenuItem.Name = "movimentsLimitatsToolStripMenuItem";
            this.movimentsLimitatsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.movimentsLimitatsToolStripMenuItem.Text = "Moviments limitats";
            this.movimentsLimitatsToolStripMenuItem.Click += new System.EventHandler(this.movimentsLimitatsToolStripMenuItem_Click);
            // 
            // fAQsToolStripMenuItem
            // 
            this.fAQsToolStripMenuItem.Name = "fAQsToolStripMenuItem";
            this.fAQsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fAQsToolStripMenuItem.Text = "FAQ\'s";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.eventoMenuAbout);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Moviments maxims:";
            // 
            // labelMaxMov
            // 
            this.labelMaxMov.AutoSize = true;
            this.labelMaxMov.Location = new System.Drawing.Point(292, 337);
            this.labelMaxMov.Name = "labelMaxMov";
            this.labelMaxMov.Size = new System.Drawing.Size(19, 13);
            this.labelMaxMov.TabIndex = 8;
            this.labelMaxMov.Text = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movimientos actuales:";
            // 
            // labelMovActuales
            // 
            this.labelMovActuales.AutoSize = true;
            this.labelMovActuales.Location = new System.Drawing.Point(117, 337);
            this.labelMovActuales.Name = "labelMovActuales";
            this.labelMovActuales.Size = new System.Drawing.Size(19, 13);
            this.labelMovActuales.TabIndex = 10;
            this.labelMovActuales.Text = "12";
            // 
            // timerPartida
            // 
            this.timerPartida.Interval = 1000;
            this.timerPartida.Tick += new System.EventHandler(this.tickTimerPartida);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Temps restant:";
            // 
            // labelTempsRestant
            // 
            this.labelTempsRestant.AutoSize = true;
            this.labelTempsRestant.Location = new System.Drawing.Point(177, 368);
            this.labelTempsRestant.Name = "labelTempsRestant";
            this.labelTempsRestant.Size = new System.Drawing.Size(19, 13);
            this.labelTempsRestant.TabIndex = 12;
            this.labelTempsRestant.Text = "30";
            // 
            // progressBarTiempo
            // 
            this.progressBarTiempo.Location = new System.Drawing.Point(13, 384);
            this.progressBarTiempo.Maximum = 30;
            this.progressBarTiempo.Name = "progressBarTiempo";
            this.progressBarTiempo.Size = new System.Drawing.Size(298, 26);
            this.progressBarTiempo.Step = 1;
            this.progressBarTiempo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 422);
            this.Controls.Add(this.progressBarTiempo);
            this.Controls.Add(this.labelTempsRestant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMovActuales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMaxMov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzle";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPorTres;
        private System.Windows.Forms.ToolStripMenuItem menuPorCuatro;
        private System.Windows.Forms.ToolStripMenuItem menuPorCinco;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSonido;
        private System.Windows.Forms.ToolStripMenuItem menuTemps;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimentsLimitatsToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMaxMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMovActuales;
        private System.Windows.Forms.Timer timerPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTempsRestant;
        private System.Windows.Forms.ProgressBar progressBarTiempo;
    }
}

