// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// The amounts whose currency is implied by the context (#22): decimals with the facets of the data dictionary entry
/// (not negative, total digits, fraction digits) and no currency.
/// </summary>
public abstract class ImpliedAmountTests<TStruct> : SimpleValueXsdNumericContractTests<TStruct, decimal>
    where TStruct : struct, IIsoSimpleValue<decimal>, IIsoAmount
{
    protected abstract int TotalDigits { get; }
    protected abstract int FractionDigits { get; }

    protected override decimal ValidNativeSample => 12345.5m;

    private TStruct Make(object value) => (TStruct)Activator.CreateInstance(typeof(TStruct), value)!;

    private void AssertRefused(object value)
    {
        var ex = Assert.Throws<System.Reflection.TargetInvocationException>(() => Make(value));
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Fact]
    public void HasNoCurrency_AndIsAnAmount()
    {
        Assert.Null(typeof(TStruct).GetProperty("Currency"));
        Assert.True(typeof(TStruct).IsValueType);
        Assert.Equal(IsoKind.Amount, Iso.KindOf<TStruct>());
    }

    [Fact]
    public void Zero_IsAPositiveAmount() => Assert.Equal(0m, Make(0m).Value);

    [Fact]
    public void Negative_IsRefused() => AssertRefused(-0.01m);

    [Fact]
    public void ExactlyTheTotalDigits_IsAccepted()
    {
        var text = new string('9', TotalDigits - FractionDigits) + "." + new string('9', FractionDigits);
        Assert.Equal(decimal.Parse(text, System.Globalization.CultureInfo.InvariantCulture), Make(text).Value);
    }

    [Fact]
    public void OneDigitMoreThanTheTotal_IsRefused() =>
        AssertRefused(new string('9', TotalDigits - FractionDigits + 1) + "." + new string('9', FractionDigits));

    [Fact]
    public void OneFractionDigitMoreThanAllowed_IsRefused() => AssertRefused("0." + new string('1', FractionDigits + 1));

    [Theory]
    [InlineData("-1")]
    [InlineData("+1")]
    [InlineData(" 1")]
    [InlineData("1 ")]
    [InlineData("1,000.50")]
    [InlineData("1e2")]
    [InlineData("")]
    [InlineData("abc")]
    public void TextThatIsNotDigitsWithAnOptionalPoint_IsRefused(string text) => AssertRefused(text);

    [Theory]
    [InlineData("10.50", 10.50)]
    [InlineData("0", 0)]
    [InlineData(".5", 0.5)]
    [InlineData("10.", 10)]
    public void DigitsWithAnOptionalPoint_AreRead(string text, double expected) => Assert.Equal((decimal)expected, Make(text).Value);
}

public class ImpliedCurrencyAndAmountTests : ImpliedAmountTests<ImpliedCurrencyAndAmount>
{
    protected override int TotalDigits => 18;
    protected override int FractionDigits => 5;
}

public class ImpliedCurrencyAnd20AmountTests : ImpliedAmountTests<ImpliedCurrencyAnd20Amount>
{
    protected override int TotalDigits => 20;
    protected override int FractionDigits => 19;
}

public class RestrictedFINImpliedCurrencyAndAmountTests : ImpliedAmountTests<RestrictedFINImpliedCurrencyAndAmount>
{
    protected override int TotalDigits => 14;
    protected override int FractionDigits => 5;
}
