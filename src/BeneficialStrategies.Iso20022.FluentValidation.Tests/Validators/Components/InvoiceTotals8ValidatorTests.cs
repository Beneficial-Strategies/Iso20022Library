// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InvoiceTotals8ValidatorTests
{
    private readonly InvoiceTotals8Validator _sut = new();

    private static ServiceCategoryTotals7 ValidServiceCategoryTotal() =>
        new()
        {
            TotalInvoiceAmount = new AmountAndForeignExchange1
            {
                Amount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
            },
            ServiceCategory = new Choices.ServiceCategory1Choice.Proprietary { Value = "SVC1" },
        };

    private static InvoiceTotals8 ValidMessage() =>
        new()
        {
            AccountIdentification = new Choices.AccountIdentification38Choice.CashAccountIdentification
            {
                Value = new Choices.AccountIdentification4Choice.Other { Identification = "ACC-001" },
            },
            InvoiceTotals = new InvoiceTotals7
            {
                TotalInvoiceAmount = new AmountAndForeignExchange1
                {
                    Amount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
                },
                PaymentDueDate = new DateOnly(2026, 1, 1),
            },
            ServiceCategoryTotals = [ValidServiceCategoryTotal()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ServiceCategoryTotals: ServiceCategoryTotals7, 1..∞ ───────────────────

    [Fact]
    public void ServiceCategoryTotals_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { ServiceCategoryTotals = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ServiceCategoryTotals);
    }

    [Fact]
    public void ServiceCategoryTotals_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { ServiceCategoryTotals = [ValidServiceCategoryTotal()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ServiceCategoryTotals);
    }
}
