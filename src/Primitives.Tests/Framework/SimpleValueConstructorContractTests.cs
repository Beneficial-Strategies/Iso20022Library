// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// The contract of a simple-value struct (#7, #12): a constructor given a value that is not valid for the type throws
/// <see cref="Iso20022FormatException"/> (or <see cref="ArgumentNullException"/> for null), and nothing else. A constructor that checks
/// the shape of a text and then hands it to a parser that can still fail would let a <see cref="FormatException"/> or an
/// <see cref="OverflowException"/> out, which the readers cannot tell from a bug.
/// </summary>
public class SimpleValueConstructorContractTests
{
    private static readonly string?[] HostileStrings =
    [
        "", " ", "  x  ", "-1", "+1", "0", "00", "1e400", "NaN", "INF", "-INF", ".", "-", "+", "--", "Z", "1.2.3", "abc", "<", "&", "\0", "ÄÖÜ漢字", "٣٤٥",
        "99999999999999999999999999", "-99999999999999999999999999", "12345678901234567890.12345678901234567890", "0.000000000000000000000000000001",
        "2026-13-45", "2026-02-30", "2026-00-10", "0000-01-01", "0001-01-01", "9999-12-31", "10000-01-01", "-0001", "0000", "99999999999999999999999999",
        "24:00:00", "24:00:01", "23:59:60", "25:61:61", "00:00:00+25:00", "00:00:00-14:01", "+14:00", "+99:99",
        "2026-01-01T25:00:00", "2026-01-01T00:00:00+25:00", "0001-01-01T00:00:00+14:00", "9999-12-31T23:59:59.9999999Z", "9999-12-31T23:59:60Z", "9999-12-31T23:59:59-14:00",
        "P", "PT", "P1Y2M3DT4H5M6.7S", "P99999999999999999999Y", "PT99999999999999999999S", "-P1D", "P1.5Y",
        "1.", ".5", "1,5", "0x10", "1_000", "١", "TRUE", "True", "yes", "2", "AAAA", "AAA=", "!!!!", "ZZ", "0g", "g0", new string('a', 5000), new string('9', 5000),
        null,
    ];

    private static readonly object?[] HostileNumbers =
    [
        0m, -1m, 1m, decimal.MaxValue, decimal.MinValue, 0.0000000001m, 79228162514264337593543950335m,
        0, -1, int.MaxValue, int.MinValue, 0L, -1L, long.MaxValue, long.MinValue, 0u, uint.MaxValue, ulong.MaxValue, (short)-1, short.MaxValue, byte.MaxValue, sbyte.MinValue,
        0.0, -1.0, double.NaN, double.PositiveInfinity, double.NegativeInfinity, double.MaxValue, double.Epsilon, 0f, float.NaN, float.MaxValue,
    ];

    private static IEnumerable<object?> HostileFor(Type parameter)
    {
        if (parameter == typeof(string))
            return HostileStrings;
        if (parameter == typeof(bool))
            return [true, false];
        if (parameter == typeof(DateTime))
            return [DateTime.MinValue, DateTime.MaxValue, new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc), new DateTime(9999, 12, 31, 23, 59, 59, DateTimeKind.Local)];
        if (parameter == typeof(DateOnly))
            return [DateOnly.MinValue, DateOnly.MaxValue];
        if (parameter == typeof(TimeOnly))
            return [TimeOnly.MinValue, TimeOnly.MaxValue];
        if (parameter == typeof(byte[]))
            return [Array.Empty<byte>(), new byte[1], new byte[100_000], null];
        if (parameter == typeof(TimeSpan))
            return [TimeSpan.Zero, TimeSpan.MinValue, TimeSpan.MaxValue];
        return HostileNumbers.Where(n => n is not null && n.GetType() == parameter);
    }

    private static IEnumerable<Type> SimpleValueStructs() =>
        typeof(IIsoSimpleValue<>).Assembly.GetTypes()
            .Where(t => t.IsValueType && !t.IsEnum && t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IIsoSimpleValue<>)));

    [Fact]
    public void ThereAreManySimpleValueStructs_ToCheck()
    {
        Assert.True(SimpleValueStructs().Count() > 400, $"found only {SimpleValueStructs().Count()}");
    }

    [Fact]
    public void AnInvalidValue_GivesOnlyIso20022FormatException_OrArgumentNull_FromEveryConstructorOfOneParameter()
    {
        var problems = new SortedSet<string>(StringComparer.Ordinal);
        var calls = 0;
        foreach (var type in SimpleValueStructs())
            foreach (var ctor in type.GetConstructors().Where(c => c.GetParameters().Length == 1))
                foreach (var argument in HostileFor(ctor.GetParameters()[0].ParameterType))
                {
                    calls++;
                    try
                    {
                        ctor.Invoke([argument]);
                    }
                    catch (TargetInvocationException ex) when (ex.InnerException is Iso20022FormatException or ArgumentNullException)
                    {
                        // the contract
                    }
                    catch (TargetInvocationException ex)
                    {
                        var shown = argument is string s ? (s.Length > 30 ? s[..30] + "…" : s) : argument?.ToString() ?? "null";
                        problems.Add($"{type.Name}({ctor.GetParameters()[0].ParameterType.Name}) '{shown}': {ex.InnerException?.GetType().Name}");
                    }
                }

        Assert.True(calls > 10_000, $"only {calls} calls were made");
        Assert.True(problems.Count == 0, $"{problems.Count} combinations break the contract:{Environment.NewLine}" + string.Join(Environment.NewLine, problems.Take(60)));
    }
}
