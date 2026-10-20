// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement5ValidatorTests
{
    private readonly AccountStatement5Validator _sut = new();

    private static ICashBalance3 ValidBalance() =>
        IsoDataFactory.Make<ICashBalance3>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<IBalanceType12>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.BalanceType5Choice.ICode>(b3 => b3
                    .Set(x3 => x3.Value).To(Codesets.BalanceType12Code.OpeningAvailable)))))
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.CreditDebitIndicator).To(Codesets.CreditDebitCode.Credit)
            .Set(x => x.Date).To(IsoDataFactory.Make<Choices.DateAndDateTimeChoice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));

    private static IAccountStatement5 ValidMessage() =>
        IsoDataFactory.Make<IAccountStatement5>(b => b
            .Set(x => x.Identification).To("STMT-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.Account).To(IsoDataFactory.Make<ICashAccount25>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b3 => b3
                    .Set(x3 => x3.Identification).To("ACC-001")))))
            .Set(x => x.Balance).To([ValidBalance()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Balance: CashBalance3, 1..∞ ────────────────────────────────────────────

    [Fact]
    public void Balance_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Balance).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Balance);
    }

    [Fact]
    public void Balance_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Balance).To([ValidBalance()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Balance);
    }
}
