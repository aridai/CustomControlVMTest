using Prism.Mvvm;

namespace CustomControlVMTest
{
    internal sealed class MainPageViewModel : BindableBase
    {
        public string ParentMsg { get; } = "親からのメッセージ";

        public string Hoge { get; } = "親のほげ";
    }
}
