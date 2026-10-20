// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyExchange26ValidatorTests
{
    private readonly CurrencyExchange26Validator _sut = new();

    private static CurrencyExchange26 ValidMessage() => new() { PreAgreedExchangeRate = 1.1m };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ForeignExchangeAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ForeignExchangeAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QuotationDateTime_Present_NoValidationError()
    {
        var msg = ValidMessage() with { QuotationDateTime = new DateTime(2026, 1, 1) };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QuotedCurrency_Present_NoValidationError()
    {
        var msg = ValidMessage() with { QuotedCurrency = "USD" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnitCurrency_Present_NoValidationError()
    {
        var msg = ValidMessage() with { UnitCurrency = "GBP" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QuoteIdentification_Present_NoValidationError()
    {
        var msg = ValidMessage() with { QuoteIdentification = "1fdb2f66-7d4c-4a5f-8fbb-123456789abc" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
