// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max30DecimalNumberTests : SimpleValueXsdNumericContractTests<Max30DecimalNumber, decimal>
{
    protected override decimal ValidNativeSample => 1.5m;

    // No ExcessiveTotalDigits test: System.Decimal's own ~28-29 significant-digit ceiling is
    // below this type's nominal 30-digit ISO bound, so no representable decimal value can
    // actually trigger that check — see the type's <remarks> for the documented limitation.

    [Fact]
    public void MaxDecimalValue_StillWithinDecimalsOwnPrecisionCeiling_DoesNotThrowOnTotalDigits()
    {
        // decimal.MaxValue has 29 significant digits with scale 0 — fewer than TotalDigits (30),
        // so it passes the total-digits check even though it's an extreme value. This documents
        // the practical limitation rather than asserting a failure case that doesn't exist.
        Assert.True(Max30DecimalNumber.TryCreate(decimal.MaxValue, out _));
    }
}
