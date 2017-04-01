using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace puzzle
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private int y = 0;
        private int PosIniciaTop = 0;
        private int PosIniciaLeft = 0;

        private Image[] imagenes;
        private PictureBox[] pbs;
        private bool[] imagenesCodigas;

        private Configuracio configuracio;

        private System.Media.SoundPlayer soundPlayer;

        private int numMovimientosActuales;

        private bool primeraVezTiempo;

        public Form1()
        {
            InitializeComponent();
            configuracio = new Configuracio();
            cambiarLabelMovimientosMax();
            soundPlayer = new System.Media.SoundPlayer(Properties.Resources.musica);
            soundPlayer.Load();
            imagenes = getImagenes();
            anadirTagImagenes();
            cargarDeCero();
            comenzarPuzzle();
        }

        private void cargarDeCero()
        {
            pbs = new PictureBox[9];
            imagenesCodigas = new bool[9];
            numMovimientosActuales = configuracio.getNumMovimentsMaxim();
            actualizarLabelMovimientosActuales();
            resetTiempo();
            primeraVezTiempo = menuTemps.Checked;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            PictureBox pictureBox = (PictureBox)sender;
            PosIniciaTop = pictureBox.Top;
            PosIniciaLeft = pictureBox.Left;
            if (primeraVezTiempo)
            {
                primeraVezTiempo = false;
                timerPartida.Start();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BringToFront();
            if (e.Button == MouseButtons.Left)
            {
                pictureBox.Left = (pictureBox.Left + e.X) - x;
                pictureBox.Top = (pictureBox.Top + e.Y) - y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int topActual = pictureBox.Top, topTemp, leftActual = pictureBox.Left, leftTemp;
            for (int i = 0; i < pbs.Length; i++)
            {
                topTemp = pbs[i].Top;
                leftTemp = pbs[i].Left;
                if (leftTemp <= leftActual && leftTemp + 100 > leftActual &&
                    topTemp <= topActual && topTemp + 100 > topActual && pictureBox != pbs[i])
                {
                    Image aux = pictureBox.Image;
                    pictureBox.Image = pbs[i].Image;
                    pictureBox.Tag = pbs[i].Image.Tag;

                    pbs[i].Image = aux;
                    pbs[i].Tag = aux.Tag;
                    --numMovimientosActuales;
                    actualizarLabelMovimientosActuales();
                    break;
                }
            }
            pictureBox.Left = PosIniciaLeft;
            pictureBox.Top = PosIniciaTop;
            if (compGanar())
            {
                timerPartida.Stop();
                MessageBox.Show("Puzle completat satisfactòriament!");
                comenzarPuzzle();
            }
        }

        private Image[] getImagenes()
        {
            return new Image[] {Properties.Resources.img1, Properties.Resources.img2, Properties.Resources.img3,
                Properties.Resources.img4, Properties.Resources.img5, Properties.Resources.img6,
                Properties.Resources.img7, Properties.Resources.img8, Properties.Resources.img9};
        }

        private void anadirTagImagenes()
        {
            for (int i = 1; i <= imagenes.Length; i++)
            {
                imagenes[i - 1].Tag = i;
            }
        }

        private bool compGanar()
        {
            bool ganado = true;
            for (int i = 1; i <= pbs.Length; i++)
            {
                if ((int)pbs[i - 1].Tag != i)
                {
                    ganado = false;
                    break;
                }
            }
            return ganado;
        }

        private void comenzarPuzzle()
        {
            reiniciarJuego();
            PictureBox pictureBoxAnadir;
            Point[] puntosPosiciones = obtenerPuntosPosiciones();
            Random random = new Random();
            int aleatorio;
            for (int i = 0; i < pbs.Length; i++)
            {
                aleatorio = -33;
                pictureBoxAnadir = new PictureBox();
                pictureBoxAnadir.Height = 100;
                pictureBoxAnadir.Width = 100;
                pictureBoxAnadir.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxAnadir.Location = puntosPosiciones[i];
                while (aleatorio == -33 || imagenesCodigas[aleatorio])
                {
                    aleatorio = random.Next(0, pbs.Length);
                }
                imagenesCodigas[aleatorio] = true;
                pictureBoxAnadir.Image = imagenes[aleatorio];
                pictureBoxAnadir.Tag = pictureBoxAnadir.Image.Tag;
                pictureBoxAnadir.MouseMove += pictureBox1_MouseMove;
                pictureBoxAnadir.MouseUp += pictureBox1_MouseUp;
                pictureBoxAnadir.MouseDown += pictureBox1_MouseDown;
                pbs[i] = pictureBoxAnadir;
                this.panel1.Controls.Add(pbs[i]);
            }
        }

        private void reiniciarJuego()
        {
            for (int i = 0; i < pbs.Length; i++)
            {
                if (pbs[i] != null)
                {
                    panel1.Controls.Remove(pbs[i]);
                }
            }
            cargarDeCero();
        }

        private Point[] obtenerPuntosPosiciones()
        {
            Point[] puntos = new Point[9];
            int posX = 0, posY = 0;
            for (int i = 0; i < puntos.Length; i++)
            {
                if (posX >= 300)
                {
                    posX = 0;
                    posY += 100;
                }
                puntos[i] = new Point(posX, posY);
                posX += 100;
            }
            return puntos;
        }

        private void cambiarTableroEvento(object sender, EventArgs e)
        {
            ponerOpcionesMenuTableroFalse();
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void ponerOpcionesMenuTableroFalse()
        {
            menuPorCinco.Checked = false;
            menuPorTres.Checked = false;
            menuPorCuatro.Checked = false;
        }

        private void cambiarEstadoSonido(object sender, EventArgs e)
        {
            bool checkeado = !menuSonido.Checked;
            cambiarMusica(checkeado);
            menuSonido.Checked = checkeado;
            menuSonido.Text = checkeado ? "Só (Activat)" : "Só (Desactivat)";
        }

        private void cambiarEstadoTiempo(object sender, EventArgs e)
        {
            bool checkeado = !menuTemps.Checked;
            menuTemps.Checked = checkeado;
            menuTemps.Text = checkeado ? "Temps (Activat)" : "Temps (Desactivat)";
            cambiarTiempo();
        }

        private void sortirEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reiniciarEvento(object sender, EventArgs e)
        {
            comenzarPuzzle();
        }

        private void eventoMenuAbout(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        public void configuracionCambiada()
        {
            cambiarLabelMovimientosMax();
            comenzarPuzzle();
        }

        private void cambiarLabelMovimientosMax()
        {
            labelMaxMov.Text = configuracio.getNumMovimentsMaxim().ToString();
        }

        private void movimentsLimitatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormConfiguracio(configuracio, this).ShowDialog();
        }

        private void cambiarMusica(bool activada)
        {
            if (activada)
            {
                soundPlayer.PlayLooping();
            }
            else
            {
                soundPlayer.Stop();
            }
        }

        private void actualizarLabelMovimientosActuales()
        {
            labelMovActuales.Text = numMovimientosActuales.ToString();
            if (numMovimientosActuales == 0)
            {
                timerPartida.Stop();
                MessageBox.Show("Has arribat al límit de moviments, has perdut! (Es reiniciarà el lloc).");
                comenzarPuzzle();
            }
        }

        private void cambiarTiempo()
        {
            comenzarPuzzle();
        }

        private void resetTiempo()
        {
            timerPartida.Stop();
            labelTempsRestant.Text = "30";
            progressBarTiempo.Value = 0;
        }

        private void tickTimerPartida(object sender, EventArgs e)
        {
            progressBarTiempo.PerformStep();
            int valor = progressBarTiempo.Value;
            labelTempsRestant.Text = (30 - valor).ToString();
            if (valor == 30)
            {
                timerPartida.Stop();
                MessageBox.Show("Temps esgotat, has perdut!");
                comenzarPuzzle();
            }
        }
    }
}
