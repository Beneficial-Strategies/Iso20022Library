// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxCalculation1ValidatorTests
{
    private readonly TaxCalculation1Validator _sut = new();

    private static AmountAndDirection34 ValidAmount(decimal amount = 100m) =>
        new()
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = amount },
            Sign = true,
        };

    private static BillingServicesAmount3 ValidConversion() =>
        new() { SourceAmount = ValidAmount(), HostAmount = ValidAmount() };

    private static BillingServicesTax3 ValidTaxIdentification() =>
        new() { Number = "TAX-001", Rate = 5, TotalTaxAmount = ValidAmount() };

    private static TaxCalculation1 ValidMessage() =>
        new()
        {
            HostCurrency = "USD",
            TaxableServiceChargeConversion = [ValidConversion()],
            TotalTaxableServiceChargeHostAmount = ValidAmount(),
            TaxIdentification = [ValidTaxIdentification()],
            TotalTax = ValidAmount(),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── TaxableServiceChargeConversion: BillingServicesAmount3, 1..∞ ──────────

    [Fact]
    public void TaxableServiceChargeConversion_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { TaxableServiceChargeConversion = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.TaxableServiceChargeConversion);
    }

    // ── TaxIdentification: BillingServicesTax3, 1..3 ──────────────────────────

    [Fact]
    public void TaxIdentification_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { TaxIdentification = [] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TaxIdentification");
    }

    [Fact]
    public void TaxIdentification_ThreeElements_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            TaxIdentification = [ValidTaxIdentification(), ValidTaxIdentification(), ValidTaxIdentification()],
        };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.TaxIdentification);
    }

    [Fact]
    public void TaxIdentification_FourElements_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            TaxIdentification =
            [
                ValidTaxIdentification(),
                ValidTaxIdentification(),
                ValidTaxIdentification(),
                ValidTaxIdentification(),
            ],
        };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.TaxIdentification);
    }
}
