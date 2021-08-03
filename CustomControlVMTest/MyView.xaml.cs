using Xamarin.Forms;

namespace CustomControlVMTest
{
    public partial class MyView : ContentView
    {
        public static readonly BindableProperty MyMsgProperty = BindableProperty.Create(nameof(MyMsg), typeof(string), typeof(MyView), defaultValue: "デフォルトMSG");

        public string MyMsg
        {
            get => (string)this.GetValue(MyMsgProperty);
            set => this.SetValue(MyMsgProperty, value);
        }

        public MyView()
        {
            this.InitializeComponent();
        }
    }
}
