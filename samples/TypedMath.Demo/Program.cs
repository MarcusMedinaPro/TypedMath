using System.Text;
using MarcusMedinaPro.TypedMath.DecimalExtension;
using MarcusMedinaPro.TypedMath.IntExtension;

Console.OutputEncoding = Encoding.UTF8;

var marketingBudget = 1_250m
    .Add(325m)      // add agency fee
    .Subtract(110m) // remove unused credits
    .AddPercent(15m); // expected growth boost

Console.WriteLine($"Marketing budget after tweaks : {marketingBudget:C}");

var engineeringHours = 420
    .Add(36)            // incident response
    .SubtractPercent(5) // automation savings
    .AddPercent(12);    // roadmap push

Console.WriteLine($"Engineering hours forecast     : {engineeringHours}h");

var runwayMonths = 12
    .AddPercent(25)   // new investment
    .SubtractPercent(10); // infrastructure upgrades

Console.WriteLine($"Runway after adjustments       : {runwayMonths} months");

var scenarios = new[]
{
    (Label: "Optimistic", Value: 4_500m.AddPercent(18m).Subtract(250m)),
    (Label: "Base", Value: 4_500m.AddPercent(8m).Subtract(150m)),
    (Label: "Pessimistic", Value: 4_500m.SubtractPercent(6m))
};

Console.WriteLine();
Console.WriteLine("Quarterly revenue storyboard:");
foreach (var scenario in scenarios)
{
    Console.WriteLine($" - {scenario.Label}: {scenario.Value:C}");
}
