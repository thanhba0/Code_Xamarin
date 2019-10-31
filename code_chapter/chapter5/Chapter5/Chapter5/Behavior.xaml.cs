using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public static class MyBehavior
    {
        public static readonly BindableProperty PropertyNameProperty =
            BindableProperty.CreateAttached(
                "PropertyName", typeof(bool), typeof(MyBehavior), false, propertyChanged: OnPropertyNameChanged);
        public static bool GetPropertyName(BindableObject view)
        {
            return (bool)view.GetValue(PropertyNameProperty);
        }
        public static void SetPropertyName(BindableObject view, bool value)
        {
            view.SetValue(PropertyNameProperty, value);
        }
        static void OnPropertyNameChanged(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as Entry; if (entry == null)
            {
                return;
            }
            /* Validate Entry */
        }
    }


    public class MyBehavior : Behavior<View>
    {
        protected override void OnAttachedTo(View bindable)
        {
            base.OnAttachedTo(bindable);
            // Initialize
        }
        protected override void OnDetachingFrom(View bindable)
        {
            base.OnDetachingFrom(bindable);
            // Clean up
        }
        // Behavior Implementation
    }


}