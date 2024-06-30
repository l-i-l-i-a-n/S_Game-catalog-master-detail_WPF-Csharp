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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Vue.Windows
{
    /// <summary>
    /// Logique d'interaction pour VideoPlayerWindow.xaml
    /// </summary>
    public partial class VideoPlayerWindow : Window
    {
        private bool userMovingSlider = false;

        public VideoPlayerWindow(Uri source, TimeSpan position)
        {
            InitializeComponent();
            Video.Source = source;
            Video.Position = position;
            Video.Play();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((Video.Source != null) && (Video.NaturalDuration.HasTimeSpan) && (!userMovingSlider))
            {
                timelineSlider.Minimum = 0;
                timelineSlider.Maximum = Video.NaturalDuration.TimeSpan.TotalMilliseconds;
                timelineSlider.Value = Video.Position.TotalMilliseconds;
                totalVideoTime_textblock.Text = Video.NaturalDuration.TimeSpan.ToString();
            }
        }

        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            Video.Play();
        }

        private void Pause_Button_Click(object sender, RoutedEventArgs e)
        {
            Video.Pause();
        }

        private void TimelineSlider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            userMovingSlider = true;
        }

        private void TimelineSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            userMovingSlider = false;
            Video.Position = TimeSpan.FromMilliseconds(timelineSlider.Value);
        }

        private void TimelineSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            videoPosition_textblock.Text = TimeSpan.FromMilliseconds(timelineSlider.Value).ToString(@"hh\:mm\:ss");
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Video.Volume = volumeSlider.Value;
        }

        private void MuteVolume_Button_Click(object sender, RoutedEventArgs e)
        {
            volumeSlider.Value = 0;
        }

        private void ExitFullscreen_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
