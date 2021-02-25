using Mux;
using Mux.Markup;

namespace Main
{
    internal sealed class MainTransform : RectTransform, IReloadable
    {
        [XamlImport] private extern void InitializeComponent();

        public MainTransform()
        {
            InitializeComponent();
        }

        public void Reload()
        {
            InitializeComponent();
        }
    }
}
