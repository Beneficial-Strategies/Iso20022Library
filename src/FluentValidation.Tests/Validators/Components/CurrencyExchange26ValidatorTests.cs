// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyExchange26ValidatorTests
{
    private readonly CurrencyExchange26Validator _sut = new();

    private static ICurrencyExchange26 ValidMessage() => IsoDataFactory.Make<ICurrencyExchange26>(b => b
        .Set(x => x.PreAgreedExchangeRate).To(1.1m));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ForeignExchangeAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ForeignExchangeAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b3 => b3
                    .Set(x3 => x3.BICFI).To("DEUTDEFFXXX"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QuotationDateTime_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.QuotationDateTime).To(new DateTime(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QuotedCurrency_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.QuotedCurrency).To("USD"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnitCurrency_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnitCurrency).To("GBP"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void QuoteIdentification_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.QuoteIdentification).To("1fdb2f66-7d4c-4a5f-8fbb-123456789abc"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
