// Lab 11
// Student name:
// Student number:

//Submit ONLY this file to Gradescope.
//Rules (details in Part IV of the handout):
// - Use only Point and Exposure.Integrate. Do not use Exposure.IsOutside,
//   reflection, files, timing, or randomness.
// - Call Exposure.Integrate at most 12 times in total (the example below counts).
// - Every call to Integrate must satisfy its preconditions.
// - Every test must pass every correct implementation.
// - Give each test a // PARTITION: comment.

using SensorCode;

namespace SensorCode.Tests;

public class ExposureTests
{
    // ---------- Shared helpers (do not change the tolerance) ----------

    /// Approximate comparison with an absolute-plus-relative tolerance.
    static void ExpectNear(double expected, double actual)
    {
        Assert.True(double.IsFinite(actual), $"result is not finite: {actual}");
        double tolerance = 1e-9 + 1e-9 * Math.Abs(expected);
        Assert.True(Math.Abs(actual - expected) <= tolerance,
            $"expected {expected}, actual {actual}");
    }

    /// Builds points from (time, concentration) pairs:
    /// Pts(0, 0, 60, 1) is { Point(0, 0), Point(60, 1) }.
    static Point[] Pts(params double[] timeConcentrationPairs)
    {
        Assert.True(timeConcentrationPairs.Length % 2 == 0,
            "Pts needs (time, concentration) pairs");
        var result = new Point[timeConcentrationPairs.Length / 2];
        for (int i = 0; i < result.Length; i++)
            result[i] = new Point(timeConcentrationPairs[2 * i],
                                  timeConcentrationPairs[2 * i + 1]);
        return result;
    }

    // ---------- Example test (counts toward your budget) ----------

    // PARTITION: IRREGULAR, RISING
    [Fact]
    public void UnequalIntervals()
    {
        var points = Pts(0, 0, 60, 1, 180, 3);
        // Hand calculation: (0+1)/2*60 + (1+3)/2*120 = 30 + 240 = 270
        ExpectNear(270.0, Exposure.Integrate(points));
    }

    // ---------- Your tests ----------
    // TODO
}
