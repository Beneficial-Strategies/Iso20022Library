// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISODateTests : SimpleValueNativeScalarContractTests<ISODate, DateOnly>
{
    protected override DateOnly ValidNativeSample => new(2026, 10, 6);
    protected override string ValidNativeSampleWire => "2026-10-06";
    protected override DateOnly OtherNativeSample => new(2026, 10, 7);
    protected override string OtherNativeSampleWire => "2026-10-07";
}

/// <summary>What ISODate reads and refuses (#33, replacing the loose <c>DateOnly.Parse</c>): <c>YYYY-MM-DD</c> and nothing else.</summary>
public class ISODateLexicalFormTests
{
    [Theory]
    [InlineData("2026-10-18", 2026, 10, 18)]
    [InlineData("2024-02-29", 2024, 2, 29)]
    [InlineData("0001-01-01", 1, 1, 1)]
    [InlineData("9999-12-31", 9999, 12, 31)]
    public void ReadsYyyyMmDd(string text, int year, int month, int day)
    {
        var date = new ISODate(text);
        Assert.Equal(new DateOnly(year, month, day), date.Value);
        Assert.Equal(text, date.ToString());
    }

    [Theory]
    [InlineData("2026-10-18Z")] // the format has no timezone
    [InlineData("2026-10-18+02:00")]
    [InlineData("2026-10-18-05:00")]
    [InlineData("10/18/2026")]
    [InlineData("October 18, 2026")]
    [InlineData("2026-1-8")]
    [InlineData("2026-10-18T00:00:00")]
    [InlineData(" 2026-10-18")]
    [InlineData("2026-10-18 ")]
    [InlineData("2026-10-18\n")]
    [InlineData("20261018")]
    [InlineData("18.10.2026")]
    [InlineData("2026-02-30")]
    [InlineData("2025-02-29")]
    [InlineData("2026-13-01")]
    [InlineData("0000-01-01")]
    [InlineData("-0043-01-01")]
    [InlineData("12026-01-01")]
    [InlineData("")]
    public void RefusesEverythingElse(string text)
    {
        Assert.Throws<Iso20022FormatException>(() => new ISODate(text));
        Assert.False(ISODate.TryCreate(text, out _));
    }

    [Fact]
    public void ConvertsBothWaysWithDateOnlyAndKeepsNull()
    {
        ISODate wrapped = new DateOnly(2026, 10, 18);
        DateOnly back = wrapped;
        Assert.Equal(new DateOnly(2026, 10, 18), back);
        Assert.True(wrapped == new DateOnly(2026, 10, 18));

        DateOnly? none = null;
        ISODate? lifted = none;
        Assert.Null(lifted);
        DateOnly? some = new DateOnly(2026, 10, 18);
        ISODate? liftedSome = some;
        Assert.Equal("2026-10-18", liftedSome.ToString());
    }
}
