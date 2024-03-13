using AvaloniaInside.Shell;
using System.Threading.Tasks;
using System.Threading;

namespace AvaloniaApplication8.Views
{
    public partial class WelcomeView : Page
    {
        public WelcomeView()
        {
            InitializeComponent();
        }

        public override Task InitialiseAsync(CancellationToken cancellationToken)
        {
            DataContext = new ViewModels.WelcomeViewModel(Navigator);
            return base.InitialiseAsync(cancellationToken);
        }
    }
}
