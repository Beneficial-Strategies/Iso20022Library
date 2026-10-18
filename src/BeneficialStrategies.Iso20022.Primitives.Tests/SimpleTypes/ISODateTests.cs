// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISODateTests : SimpleValueXsdGregorianScalarContractTests<ISODate, DateOnly>
{
    protected override DateOnly ValidNativeSample => new(2026, 10, 6);
    protected override string ValidNativeSampleWireCore => "2026-10-06";
}

/// <summary>What ISODate reads and refuses (the text of #33, replacing the loose <c>DateOnly.Parse</c>).</summary>
public class ISODateLexicalFormTests
{
    [Theory]
    [InlineData("2026-10-18", 2026, 10, 18, null)]
    [InlineData("2026-10-18Z", 2026, 10, 18, 0)]
    [InlineData("2026-10-18+02:00", 2026, 10, 18, 120)]
    [InlineData("2026-10-18-05:00", 2026, 10, 18, -300)]
    [InlineData("2024-02-29", 2024, 2, 29, null)]
    [InlineData("0001-01-01", 1, 1, 1, null)]
    [InlineData("9999-12-31Z", 9999, 12, 31, 0)]
    public void ReadsTheXsDateForms(string text, int year, int month, int day, int? offsetMinutes)
    {
        var date = new ISODate(text);
        Assert.Equal(new DateOnly(year, month, day), date.Value);
        Assert.Equal(offsetMinutes is null ? null : TimeSpan.FromMinutes(offsetMinutes.Value), date.TimezoneOffset);
        Assert.Equal(text, date.ToString());
    }

    [Theory]
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
    [InlineData("2026-10-18+15:00")]
    [InlineData("2026-10-18+2:00")]
    [InlineData("2026-10-18z")]
    [InlineData("")]
    public void RefusesEverythingElse(string text)
    {
        Assert.Throws<Iso20022FormatException>(() => new ISODate(text));
        Assert.False(ISODate.TryCreate(text, out _));
    }

    [Fact]
    public void EqualityCountsTheTimezone()
    {
        Assert.Equal(new ISODate("2026-10-18"), new ISODate("2026-10-18"));
        Assert.NotEqual(new ISODate("2026-10-18Z"), new ISODate("2026-10-18"));
        Assert.NotEqual(new ISODate("2026-10-18+01:00"), new ISODate("2026-10-18Z"));
        Assert.True(new ISODate("2026-10-18Z") == new DateOnly(2026, 10, 18)); // against a DateOnly only the date counts
    }

    [Fact]
    public void ConvertsBothWaysWithDateOnlyAndKeepsNull()
    {
        ISODate wrapped = new DateOnly(2026, 10, 18);
        DateOnly back = wrapped;
        Assert.Equal(new DateOnly(2026, 10, 18), back);

        DateOnly? none = null;
        ISODate? lifted = none;
        Assert.Null(lifted);
        DateOnly? some = new DateOnly(2026, 10, 18);
        ISODate? liftedSome = some;
        Assert.Equal("2026-10-18", liftedSome.ToString());
    }

    [Fact]
    public void JsonRoundTripKeepsTheTimezone()
    {
        var options = new System.Text.Json.JsonSerializerOptions();
        foreach (var text in new[] { "2026-10-18", "2026-10-18Z", "2026-10-18-05:00" })
        {
            var json = System.Text.Json.JsonSerializer.Serialize(new ISODate(text), options);
            Assert.Equal($"\"{text}\"", json);
            Assert.Equal(new ISODate(text), System.Text.Json.JsonSerializer.Deserialize<ISODate>(json, options));
        }
        Assert.Throws<System.Text.Json.JsonException>(() => System.Text.Json.JsonSerializer.Deserialize<ISODate>("\"10/18/2026\"", options));
    }
}
