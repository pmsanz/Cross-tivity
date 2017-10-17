using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.Configuration;

namespace Main
{
    public partial class Form1 : Form
    {

        private Timer _tTimer = new Timer();

        private Timer _dTimer = new Timer();
       // private Int32 _tHours = 0;
        private Int32 _tMinutes = 1;
        private Int32 _tSeconds = 0;
       // private Int32 _dHours = 0;
        private Int32 _dMinutes = 1;
        private Int32 _dSeconds = 0;

        

          


        // _state = 0 : Programando , _state = 1 : Trabajo , _state = 2 : Descanso

        private Int32 _State = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimePicker();
        }

        private void InitializeTimePicker()
        {
           // dateTimePicker1.Value = new DateTime("");
            maskedTextBox1.Text = Convert.ToString(_tMinutes).PadLeft(2, '0') + "00";
            maskedTextBox2.Text = Convert.ToString(_dMinutes).PadLeft(2, '0') + "00";

            _tTimer.Interval = (100);
            _dTimer.Interval = (100);


            _tTimer.Tick += new EventHandler(_tTimer_Tick);
            _dTimer.Tick += new EventHandler(_dTimer_Tick);

            try
            {
                _tMinutes = Int32.Parse(ConfigurationManager.AppSettings["_tMinutes"]);
                _tSeconds = Int32.Parse(ConfigurationManager.AppSettings["_tSeconds"]);
                _dMinutes = Int32.Parse(ConfigurationManager.AppSettings["_dMinutes"]);
                _dSeconds = Int32.Parse(ConfigurationManager.AppSettings["_dSeconds"]);
            }
            catch (Exception)
            {

                _tMinutes = 1;
                _tSeconds = 0;
                _dMinutes = 1;
                _dSeconds = 0;
            }
           

           MostrarActual();
            //dateTimePicker1.Format = DateTimePickerFormat.Time;
            //dateTimePicker1.ShowUpDown = true;
            //dateTimePicker2.Format = DateTimePickerFormat.Time;
            //dateTimePicker2.ShowUpDown = true;
        }

        #region Timers


        private void _dTimer_Tick(object sender, EventArgs e)
        {
            _State = 2;
            _dSeconds = Restar(_dSeconds);
            if (_dSeconds == 59)
            {
                _dMinutes = Restar(_dMinutes);
                
                if (_dMinutes == 59)
                {
                    _dMinutes = 0;
                    _dSeconds = 0;
                    _dTimer.Stop();
                    EjecutarSonido();
                    CargarConfig();
                    _State = 0;
                }
            }
            MostrarActual();

        }

        private void _tTimer_Tick(object sender, EventArgs e)
        {
            _State = 1;
            _tSeconds = Restar(_tSeconds);
            if (_tSeconds == 59)
            {
                _tMinutes = Restar(_tMinutes);
                if (_tMinutes == 59)
                {
                    _tMinutes = 0;
                    EjecutarSonido();
                    _dTimer.Start();
                    _tTimer.Stop();
                   
                }
            }

            MostrarActual();


        }

        private void Iniciar()
        {
            
            GuardarConfig();
            _tTimer.Start();
        }
            
            
            

            void CargarConfig(){
            
             
            try
            {
                _tMinutes = Int32.Parse(ConfigurationManager.AppSettings["_tMinutes"]);
                _tSeconds = Int32.Parse(ConfigurationManager.AppSettings["_tSeconds"]);
                _dMinutes = Int32.Parse(ConfigurationManager.AppSettings["_dMinutes"]);
                _dSeconds = Int32.Parse(ConfigurationManager.AppSettings["_dSeconds"]);

               

               
            }
            catch (Exception)
            {
                
               
            }

                }

            void GuardarConfig(){

            try
                {
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["_tMinutes"].Value = _tMinutes.ToString();
                    config.AppSettings.Settings["_tSeconds"].Value = _tSeconds.ToString();
                    config.AppSettings.Settings["_dMinutes"].Value = _dMinutes.ToString();
                    config.AppSettings.Settings["_dSeconds"].Value = _dSeconds.ToString();
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");

                   


                }
                catch (Exception)
                {

                }

              
            
            }


        
        
        #endregion


        #region EjecutarSonido y Mostrar

        void EjecutarSonido() {

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "C:\\1.wav";
            wplayer.controls.play();

        }

        void MostrarActual() { 
        
            switch (_State){
                case 0:
                    lblMostrar.Text = "00 : 00 : 00";
                    break;
                case 1:
                     lblMostrar.Text = "00 : " + _tMinutes.ToString().PadLeft(2,'0') + " : " + _tSeconds.ToString().PadLeft(2,'0');
                    break;
                case 2:
                    lblMostrar.Text = "00 : " + _dMinutes.ToString().PadLeft(2,'0') + " : " + _dSeconds.ToString().PadLeft(2,'0');
                    break;
            }               
        
        }
        
        #endregion





        private void button1_Click(object sender, EventArgs e)
        {
            Iniciar();
          //  EjecutarSonido();

        }


       


        #region SumarYRestar

        private void tSumar_Click(object sender, EventArgs e)
        {
            _tMinutes = Sumar(_tMinutes);
            maskedTextBox1.Text = Convert.ToString(_tMinutes).PadLeft(2, '0') + "00";
            _State = 0;

        }

        private void tRestar_Click(object sender, EventArgs e)
        {
            _tMinutes = Restar(_tMinutes);
            maskedTextBox1.Text = Convert.ToString(_tMinutes).PadLeft(2, '0') + "00";
            _State = 0;
        }

        private void dSumar_Click(object sender, EventArgs e)
        {
            _dMinutes = Sumar(_dMinutes);
            maskedTextBox2.Text = Convert.ToString(_dMinutes).PadLeft(2, '0') + "00";
            _State = 0;
        }

        private void dRestar_Click(object sender, EventArgs e)
        {
            _dMinutes = Restar(_dMinutes);
            maskedTextBox2.Text = Convert.ToString(_dMinutes).PadLeft(2, '0') + "00";
            _State = 0;
        }


        //Funciones para Sumar y Restar

          private int Sumar(Int32 _sumar) 
        {
        _sumar++;
            if (_sumar >= 60)
                _sumar = 0;
        return _sumar;
        
        }

        private int Restar(Int32 _restar)
        {
            if (_restar == 0)
                return 59;
            else {
                _restar--;
            }
            return _restar;

        }


        #endregion





    }
}
