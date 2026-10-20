// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BillingMethod4ValidatorTests
{
    private readonly BillingMethod4Validator _sut = new();

    private static BillingServiceParameters2 ValidServiceDetail() =>
        new()
        {
            BankService = new BillingServiceIdentification2 { Identification = "SVC-001", Description = "Service" },
            ServiceChargeAmount = new AmountAndDirection34
            {
                Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m },
                Sign = true,
            },
        };

    private static TaxCalculation1 ValidTaxCalculation() =>
        new()
        {
            HostCurrency = "USD",
            TotalTaxableServiceChargeHostAmount = new AmountAndDirection34
            {
                Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
                Sign = true,
            },
            TotalTax = new AmountAndDirection34
            {
                Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 5m },
                Sign = true,
            },
            TaxableServiceChargeConversion =
            [
                new BillingServicesAmount3
                {
                    SourceAmount = new AmountAndDirection34
                    {
                        Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
                        Sign = true,
                    },
                    HostAmount = new AmountAndDirection34
                    {
                        Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
                        Sign = true,
                    },
                },
            ],
            TaxIdentification =
            [
                new BillingServicesTax3
                {
                    Number = "TAX-001",
                    Rate = 5m,
                    TotalTaxAmount = new AmountAndDirection34
                    {
                        Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 5m },
                        Sign = true,
                    },
                },
            ],
        };

    private static BillingMethod4 ValidMessage() =>
        new() { ServiceDetail = [ValidServiceDetail()], TaxCalculation = ValidTaxCalculation() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ServiceDetail: BillingServiceParameters2, 1..∞ ────────────────────────

    [Fact]
    public void ServiceDetail_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { ServiceDetail = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ServiceDetail);
    }

    [Fact]
    public void ServiceDetail_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { ServiceDetail = [ValidServiceDetail()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ServiceDetail);
    }
}
