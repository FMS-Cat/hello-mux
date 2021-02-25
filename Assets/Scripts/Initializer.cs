using Mux;
using UnityEngine;

internal sealed class Initializer
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void OnBeforeSceneLoadRuntimeMethod()
    {
        Forms.mainThread = System.Threading.SynchronizationContext.Current;
        Forms.Init();
        System.Diagnostics.Debug.Listeners.Add(new TraceListener());
    }
}
