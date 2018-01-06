using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace StopGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timerO = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        public String passW { get; set; }                                           //свойство пароля

        public DispatcherTimer TimerO { get => timerO; set => timerO = value; }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это приложение поможет родителям контролировать время проведения их ребёнка за" +
                " персональным компьютером, ограничивая время пользования." +
                " указывая время сколько осталось пользоваться ПК и пароль отмены, в случае отмены БАНЕРА или при желании" +
                " изменить время пользования." +
                " Рекомендуется при выборе ВЫКЛЮЧИТЬ ПК, заранее поставить пароль при включении компьютера\n" +
                "P.S. эта версия не расчитана на умных детей");
        }
        private void BStart_Click(object sender, RoutedEventArgs e)                 //кнопка старта 
        {
            if (PasBox1.Password == "")
            {
                MessageBox.Show("Обязательно введите пароль отмены и запомните его или запишите", "ВАЖНО");
                return;
            }
            passW = PasBox1.Password;
            PasBox1.Password = "";
            BStart.Background = SystemColors.ControlBrush;
            EnabelButtonF();
            MTimer();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)                //отмена 
        {
            if (PasBox1.Password != passW)
            {
                MessageBox.Show("Обязательно введите пароль отмены", "ВАЖНО");
                return;
            }
            EnabelButtonT();
            timerO.Stop();
            WindowStyle = WindowStyle.SingleBorderWindow;
            WindowState = WindowState.Normal;
            BStart.Background = SystemColors.ControlDarkBrush;
        }

        private void StartProc(object sender, EventArgs e)                          //выбор что конкретно будет происходить
        {
            WindowStyle = WindowStyle.None;
            RadioButton rad = new RadioButton();
            if (caseBanner.IsChecked == true) Banner();
            else TurnOffComputer();
        }

        public void MTimer()                                                        //ф осчитывающа время и запускающая основную ф.
        {
            TimerO.Tick += new EventHandler(StartProc);                       
            int h = Convert.ToInt16(TextBoxH.Text);
            int m = Convert.ToInt16(TextBoxM.Text);
            TimerO.Interval = new TimeSpan(h, m, 1);
            TimerO.Start();
        }

        private void Banner()                                                       //блокирует компьютер
        {
            
            WindowState = WindowState.Maximized;
            Activate();
            Topmost = true;
            Focus();
        }

        private void TurnOffComputer()                                              //выключает компьютер
        {          
            Thread.Sleep(100);
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void EnabelButtonF()                                                 //делает некоторые кнопки недоступными
        {            
            BStart.IsEnabled = false;
            caseBanner.IsEnabled = false;
            caseSwitchOff.IsEnabled = false;            
        }

        private void EnabelButtonT()                                                 //делает некоторые кнопки недоступными
        {
            BStart.IsEnabled = true;
            caseBanner.IsEnabled = true;
            caseSwitchOff.IsEnabled = true;
        }

        private void TextBoxH_GotMouseCapture(object sender,MouseEventArgs e)
        {
            TextBoxH.Text = "";
        }

        private void TextBoxM_GotMouseCapture(object sender, MouseEventArgs e)
        {
            TextBoxM.Text = "";            
        }
    }
}
