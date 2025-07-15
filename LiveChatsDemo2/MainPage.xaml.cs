using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace LiveChatsDemo2;

public sealed partial class MainPage : Page
{
    public TestViewModel ViewModel { get; } = new();
    public MainPage() => InitializeComponent();
}
public class TestViewModel
{
    public ISeries[] Series { get; set; } =
     [
        new LineSeries<double>
        {
            Values = [2, 1, 3, 5, 3, 4, 6],
            Fill = null
        }
     ];
}
