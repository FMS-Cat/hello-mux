using Mux;
using Mux.Markup;
using System.ComponentModel;

namespace Main
{
    internal sealed class MainViewModel : INotifyPropertyChanged
    {
        private UnityEngine.Font _font;
        private UnityEngine.Texture _hogeTexture;

        public UnityEngine.Font Font
        {
            get => _font;
            set
            {
                _font = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Font)));
            }
        }

        public UnityEngine.Texture HogeTexture
        {
            get => _hogeTexture;
            set
            {
                _hogeTexture = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HogeTexture)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
