using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;

        public MainWindow()
        {
            InitializeComponent();
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader("C:\\Users\\Fabian\\Music\\Tracy Chapman - Tracy Chapman\\01 Tracy Chapman - Talkin’ Bout a Revolution.flac");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }
    }
}
