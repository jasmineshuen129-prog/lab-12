// Lab 11
// Code under test. Do not change this file and do not submit it.
// Gradescope replaces it with its own implementations
// (several correct ones and several faulty ones).

namespace SensorCode;

/// <summary>One concentration measurement taken at a known time.</summary>
public readonly record struct Point(
    double TimeSeconds,
    double ConcentrationMgPerL);

public static class Exposure
{
    /// <summary>
    /// Estimates cumulative exposure: the area under the
    /// concentration-time curve, assuming concentration changes linearly
    /// between consecutive measurements (trapezoid rule).
    /// </summary>
    /// <param name="points">
    /// Non-null; at least two items; all times and concentrations finite;
    /// times strictly increasing; all concentrations nonnegative.
    /// </param>
    /// <returns>
    /// Sum over i = 0..Count-2 of
    ///   (points[i].ConcentrationMgPerL + points[i+1].ConcentrationMgPerL) / 2
    ///   * (points[i+1].TimeSeconds - points[i].TimeSeconds)
    /// in mg*s/L.
    /// </returns>
    /// <remarks>
    /// Effects: neither points nor its elements are modified.
    /// No outcome is specified for inputs that violate the requirements.
    /// </remarks>
    public static double Integrate(IReadOnlyList<Point> points)
    {
        // Intentionally not implemented. Your job is to write tests, not
        // this method. Locally, every Integrate test fails with
        // NotImplementedException; Gradescope runs your tests against
        // real implementations.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Requires finite values and lower &lt;= upper. Returns true exactly
    /// when x is strictly outside the inclusive interval [lower, upper].
    /// Used only for the Part III examples.
    /// </summary>
    public static bool IsOutside(double x, double lower, double upper)
        => x < lower || x > upper;
}
