using Prism.Mvvm;

namespace CustomControlVMTest
{
    internal sealed class MyViewModel : BindableBase
    {
        public string Hoge { get; } = "AutowireVM付きカスタムコントロール:";
    }
}
