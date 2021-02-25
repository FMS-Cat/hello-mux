using Mux;
using Mux.Markup;
using Xamarin.Forms;

namespace Main
{
    internal sealed class HogeTransform : RectTransform, IReloadable
    {
        [XamlImport] private extern void InitializeComponent();

        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(HogeTransform),
            "HogeTransform");

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public HogeTransform()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            UnityEngine.Debug.Log("haha");
            InitializeComponent();
        }
    }
}
