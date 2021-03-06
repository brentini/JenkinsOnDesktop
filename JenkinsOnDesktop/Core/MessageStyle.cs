﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace XPFriend.JenkinsOnDesktop.Core
{
    public class MessageStyle
    {
        public MessagePosition Position { get; set; }
        public Thickness Padding { get; set; }
        public double FontSize { get; set; }
        public FontFamily FontFamily { get; set; }

        public double Width { get; set; }
        public double Height { get; set; }

        [DefaultValue(null)]
        public Brush BorderBrush { get; set; }

        public Thickness BorderThickness { get; set; }
        public CornerRadius CornerRadius { get; set; }

        [DefaultValue(null)]
        public Brush Foreground { get; set; }

        [DefaultValue(null)]
        public Brush Background { get; set; }

        [DefaultValue(null)]
        public string BackgroundFile { get; set; }

        public MessageStyle()
        {
            this.Position = MessagePosition.Right;
            this.Padding = new Thickness(12);
            this.FontFamily = new FontFamily("Meiryo");
            this.FontSize = 14;
            this.Foreground = new SolidColorBrush(Colors.Black);
        }

        internal void SetDefaultStyle()
        {
            this.Width = 200;
            this.Height = 200;
            this.BorderBrush = new SolidColorBrush(Colors.Black);
            this.BorderThickness = new Thickness(6);
            this.CornerRadius = new CornerRadius(8);
            this.Background = new SolidColorBrush(Colors.White);
        }
    }
}
