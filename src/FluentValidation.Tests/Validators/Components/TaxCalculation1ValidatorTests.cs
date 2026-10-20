// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxCalculation1ValidatorTests
{
    private readonly TaxCalculation1Validator _sut = new();

    private static IAmountAndDirection34 ValidAmount(decimal amount = 100m) =>
        IsoDataFactory.Make<IAmountAndDirection34>(b => b
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = amount })
            .Set(x => x.Sign).To(true));

    private static IBillingServicesAmount3 ValidConversion() =>
        IsoDataFactory.Make<IBillingServicesAmount3>(b => b
            .Set(x => x.SourceAmount).To(ValidAmount())
            .Set(x => x.HostAmount).To(ValidAmount()));

    private static IBillingServicesTax3 ValidTaxIdentification() =>
        IsoDataFactory.Make<IBillingServicesTax3>(b => b
            .Set(x => x.Number).To("TAX-001")
            .Set(x => x.Rate).To(5)
            .Set(x => x.TotalTaxAmount).To(ValidAmount()));

    private static ITaxCalculation1 ValidMessage() =>
        IsoDataFactory.Make<ITaxCalculation1>(b => b
            .Set(x => x.HostCurrency).To("USD")
            .Set(x => x.TaxableServiceChargeConversion).To([ValidConversion()])
            .Set(x => x.TotalTaxableServiceChargeHostAmount).To(ValidAmount())
            .Set(x => x.TaxIdentification).To([ValidTaxIdentification()])
            .Set(x => x.TotalTax).To(ValidAmount()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── TaxableServiceChargeConversion: BillingServicesAmount3, 1..∞ ──────────

    [Fact]
    public void TaxableServiceChargeConversion_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TaxableServiceChargeConversion).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.TaxableServiceChargeConversion);
    }

    // ── TaxIdentification: BillingServicesTax3, 1..3 ──────────────────────────

    [Fact]
    public void TaxIdentification_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TaxIdentification).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TaxIdentification");
    }

    [Fact]
    public void TaxIdentification_ThreeElements_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TaxIdentification).To([ValidTaxIdentification(), ValidTaxIdentification(), ValidTaxIdentification()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.TaxIdentification);
    }

    [Fact]
    public void TaxIdentification_FourElements_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TaxIdentification).To([
                ValidTaxIdentification(),
                ValidTaxIdentification(),
                ValidTaxIdentification(),
                ValidTaxIdentification(),
            ]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.TaxIdentification);
    }
}
