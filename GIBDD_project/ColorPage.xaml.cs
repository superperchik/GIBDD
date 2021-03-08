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


namespace GIBDD_project
{
    /// <summary>
    /// Логика взаимодействия для ColorPage.xaml
    /// </summary>
    public partial class ColorPage : Page
    {
        System.Drawing.Bitmap bitmp;
        System.Drawing.Point p;
        public ColorPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bitmapImage = getPixels(Palitra);
        }

        RenderTargetBitmap bitmapImage;
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point position = e.GetPosition(Palitra);
            if ((position.X <= bitmapImage.PixelWidth) && (position.Y <= bitmapImage.PixelHeight))
            {
                var croppedBitmap = new CroppedBitmap(bitmapImage,
                                                      new Int32Rect((int)position.X, (int)position.Y, 1, 1));

                var pixels = new byte[4];
                croppedBitmap.CopyPixels(pixels, 4, 0);

                border.Background = new SolidColorBrush(Color.FromArgb(pixels[3], pixels[2], pixels[1], pixels[0]));
            }
            //ХРЕНЬ
            // p = Palitra.PointToClient(Cursor.position);
             ColorCode.Text = System.Drawing.ColorTranslator.ToHtml(System.Drawing.Color.White);
        }

        RenderTargetBitmap getPixels(FrameworkElement elem)
        {
            PresentationSource source = PresentationSource.FromVisual(this);
            double dpiX = 96.0 * source.CompositionTarget.TransformToDevice.M11;
            double dpiY = 96.0 * source.CompositionTarget.TransformToDevice.M22;

            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)elem.ActualWidth, (int)elem.ActualHeight, dpiX, dpiY, PixelFormats.Pbgra32);
            bitmap.Render(elem);

            return bitmap;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
             ColorCode_Copy.Text = ColorCode.Text;
          
        }

        
    }
}
