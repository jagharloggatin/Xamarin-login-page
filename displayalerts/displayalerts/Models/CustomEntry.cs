using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace displayalerts.Models
{
    internal class CustomEntry : Entry
    {
        public static readonly BindableProperty CornerRadiusProperty = 
            BindableProperty.Create("CornerRadius", typeof(int), typeof(CustomEntry), 0);

        public int EntryCornerRadius
        {
            get { return (int)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create("BorderThickness", typeof(Color), typeof(CustomEntry), Color.AliceBlue);

        public Color EntryBorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty1 =
            BindableProperty.Create("BorderThickness", typeof(Color), typeof(CustomEntry), Color.AliceBlue);

        public Color EntryBorderColor1
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

    }
}
