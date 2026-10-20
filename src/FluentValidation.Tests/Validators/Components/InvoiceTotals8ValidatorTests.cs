// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InvoiceTotals8ValidatorTests
{
    private readonly InvoiceTotals8Validator _sut = new();

    private static IServiceCategoryTotals7 ValidServiceCategoryTotal() =>
        IsoDataFactory.Make<IServiceCategoryTotals7>(b => b
            .Set(x => x.TotalInvoiceAmount).To(IsoDataFactory.Make<IAmountAndForeignExchange1>(b2 => b2
                .Set(x2 => x2.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m })))
            .Set(x => x.ServiceCategory).To(IsoDataFactory.Make<Choices.ServiceCategory1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("SVC1"))));

    private static IInvoiceTotals8 ValidMessage() =>
        IsoDataFactory.Make<IInvoiceTotals8>(b => b
            .Set(x => x.AccountIdentification).To(IsoDataFactory.Make<Choices.AccountIdentification38Choice.ICashAccountIdentification>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b3 => b3
                    .Set(x3 => x3.Identification).To("ACC-001")))))
            .Set(x => x.InvoiceTotals).To(IsoDataFactory.Make<IInvoiceTotals7>(b2 => b2
                .Set(x2 => x2.TotalInvoiceAmount).To(IsoDataFactory.Make<IAmountAndForeignExchange1>(b3 => b3
                    .Set(x3 => x3.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m })))
                .Set(x2 => x2.PaymentDueDate).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.ServiceCategoryTotals).To([ValidServiceCategoryTotal()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ServiceCategoryTotals: ServiceCategoryTotals7, 1..∞ ───────────────────

    [Fact]
    public void ServiceCategoryTotals_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ServiceCategoryTotals).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ServiceCategoryTotals);
    }

    [Fact]
    public void ServiceCategoryTotals_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ServiceCategoryTotals).To([ValidServiceCategoryTotal()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ServiceCategoryTotals);
    }
}
