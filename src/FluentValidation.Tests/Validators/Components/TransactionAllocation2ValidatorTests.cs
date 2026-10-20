// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TransactionAllocation2ValidatorTests
{
    private readonly TransactionAllocation2Validator _sut = new();

    private static ITransactionAllocation2 ValidMessage() =>
        IsoDataFactory.Make<ITransactionAllocation2>(b => b
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.CreditDebitIndicator).To(CreditDebitCode.Credit)
            .Set(x => x.Account).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000")))))
            .Set(x => x.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalPurpose1Code.CashManagementTransfer)))
            .Set(x => x.Reference).To("REF-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Amount_UnsetCurrency_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Amount).To(ValidMessage().Amount with { Currency = default }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Currency");
    }

    [Fact]
    public void Amount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Amount).To(ValidMessage().Amount with { Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Amount");
    }

    [Fact]
    public void RelatedReferences_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RelatedReferences).To([
                IsoDataFactory.Make<Choices.References80Choice.ICommonIdentification>(b2 => b2
                    .Set(x2 => x2.Value).To("REF-002")),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
