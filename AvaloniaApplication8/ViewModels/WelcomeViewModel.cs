using AvaloniaInside.Shell;
using ReactiveUI;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Input;

namespace AvaloniaApplication8.ViewModels;

public class WelcomeViewModel
{
    private readonly INavigator _navigationService;
    public ICommand OpenCommand { get; set; }

    public WelcomeViewModel(INavigator navigationService)
    {
        _navigationService = navigationService;
        OpenCommand = ReactiveCommand.CreateFromTask(OpenAsync);
    }

    private Task OpenAsync(CancellationToken cancellationToken)
    {
        return _navigationService.NavigateAsync("/welcome", cancellationToken);
    }
}