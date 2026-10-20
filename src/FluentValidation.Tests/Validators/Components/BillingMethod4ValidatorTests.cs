// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BillingMethod4ValidatorTests
{
    private readonly BillingMethod4Validator _sut = new();

    private static IBillingServiceParameters2 ValidServiceDetail() =>
        IsoDataFactory.Make<IBillingServiceParameters2>(b => b
            .Set(x => x.BankService).To(IsoDataFactory.Make<IBillingServiceIdentification2>(b2 => b2
                .Set(x2 => x2.Identification).To("SVC-001")
                .Set(x2 => x2.Description).To("Service")))
            .Set(x => x.ServiceChargeAmount).To(IsoDataFactory.Make<IAmountAndDirection34>(b2 => b2
                .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m })
                .Set(x2 => x2.Sign).To(true))));

    private static ITaxCalculation1 ValidTaxCalculation() =>
        IsoDataFactory.Make<ITaxCalculation1>(b => b
            .Set(x => x.HostCurrency).To("USD")
            .Set(x => x.TotalTaxableServiceChargeHostAmount).To(IsoDataFactory.Make<IAmountAndDirection34>(b2 => b2
                .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                .Set(x2 => x2.Sign).To(true)))
            .Set(x => x.TotalTax).To(IsoDataFactory.Make<IAmountAndDirection34>(b2 => b2
                .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 5m })
                .Set(x2 => x2.Sign).To(true)))
            .Set(x => x.TaxableServiceChargeConversion).To([
                IsoDataFactory.Make<IBillingServicesAmount3>(b2 => b2
                    .Set(x2 => x2.SourceAmount).To(IsoDataFactory.Make<IAmountAndDirection34>(b3 => b3
                        .Set(x3 => x3.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                        .Set(x3 => x3.Sign).To(true)))
                    .Set(x2 => x2.HostAmount).To(IsoDataFactory.Make<IAmountAndDirection34>(b3 => b3
                        .Set(x3 => x3.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                        .Set(x3 => x3.Sign).To(true)))),
            ])
            .Set(x => x.TaxIdentification).To([
                IsoDataFactory.Make<IBillingServicesTax3>(b2 => b2
                    .Set(x2 => x2.Number).To("TAX-001")
                    .Set(x2 => x2.Rate).To(5m)
                    .Set(x2 => x2.TotalTaxAmount).To(IsoDataFactory.Make<IAmountAndDirection34>(b3 => b3
                        .Set(x3 => x3.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 5m })
                        .Set(x3 => x3.Sign).To(true)))),
            ]));

    private static IBillingMethod4 ValidMessage() =>
        IsoDataFactory.Make<IBillingMethod4>(b => b
            .Set(x => x.ServiceDetail).To([ValidServiceDetail()])
            .Set(x => x.TaxCalculation).To(ValidTaxCalculation()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ServiceDetail: BillingServiceParameters2, 1..∞ ────────────────────────

    [Fact]
    public void ServiceDetail_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ServiceDetail).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ServiceDetail);
    }

    [Fact]
    public void ServiceDetail_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ServiceDetail).To([ValidServiceDetail()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ServiceDetail);
    }
}
