using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EpicGamesLauncher.Attached_Properties
{
    class BasicMenuButton: Button
    {
        public PathGeometry Icon
        {
            get { return (PathGeometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(PathGeometry), typeof(BasicMenuButton));



        public ImageSource ImageIcon
        {
            get => (ImageSource)GetValue(ImageIconProperty);
            set => SetValue(ImageIconProperty, value);
        }

        // Using a DependencyProperty as the backing store for ImageIcon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageIconProperty =
            DependencyProperty.Register("ImageIcon", typeof(ImageSource), typeof(BasicMenuButton));


        public double IconHeight
        {
            get => (double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        // Using a DependencyProperty as the backing store for IconHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(BasicMenuButton));



        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(BasicMenuButton));



        public Brush IconFill
        {
            get { return (Brush)GetValue(IconFillProperty); }
            set { SetValue(IconFillProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFill.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFillProperty =
            DependencyProperty.Register("IconFill", typeof(Brush), typeof(BasicMenuButton));



        public Brush IconFillOnHover
        {
            get { return (Brush)GetValue(IconFillOnHoverProperty); }
            set { SetValue(IconFillOnHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconFillOnHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconFillOnHoverProperty =
            DependencyProperty.Register("IconFillOnHover", typeof(Brush), typeof(BasicMenuButton));



        public Brush IconBackground
        {
            get { return (Brush)GetValue(IconBackgroundProperty); }
            set { SetValue(IconBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundProperty =
            DependencyProperty.Register("IconBackground", typeof(Brush), typeof(BasicMenuButton));



        public Brush IconBackgroundHover
        {
            get { return (Brush)GetValue(IconBackgroundHoverProperty); }
            set { SetValue(IconBackgroundHoverProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IconBackgroundHover.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconBackgroundHoverProperty =
            DependencyProperty.Register("IconBackgroundHover", typeof(Brush), typeof(BasicMenuButton));


    }
}