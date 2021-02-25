using Mux;
using Mux.Markup;
using System.ComponentModel;

namespace Main
{
    [UnityEngine.RequireComponent(typeof(UnityEngine.Canvas))]
    internal sealed class Main : UnityEngine.MonoBehaviour
    {
        private readonly MainViewModel _viewModel = new MainViewModel();

        // This field won't be used in anywhere,
        // but we have to have a reference to a root transform
        // in order to take live reloading effect
        private MainTransform _mainTransform;

#pragma warning disable CS0649
        [UnityEngine.SerializeField]
        private UnityEngine.Font _font;

        [UnityEngine.SerializeField]
        private UnityEngine.Texture _hogeTexture;
#pragma warning restore CS0649

        private void Awake()
        {
            _mainTransform = new MainTransform();
            _mainTransform.BindingContext = _viewModel;
            _mainTransform.X = new Stretch();
            _mainTransform.Y = new Stretch();
            _mainTransform.AddTo(gameObject);
        }

        private void OnValidate()
        {
            _viewModel.Font = _font;
            _viewModel.HogeTexture = _hogeTexture;
        }
    }
}
