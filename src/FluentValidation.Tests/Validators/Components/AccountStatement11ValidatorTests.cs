// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement11ValidatorTests
{
    private readonly AccountStatement11Validator _sut = new();

    private static ICashBalance8 ValidBalance() =>
        IsoDataFactory.Make<ICashBalance8>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<IBalanceType13>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.BalanceType10Choice.ICode>(b3 => b3
                    .Set(x3 => x3.Value).To(Codesets.ExternalBalanceType1Code.ClosingAvailable)))))
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.CreditDebitIndicator).To(Codesets.CreditDebitCode.Credit)
            .Set(x => x.Date).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));

    private static IAccountStatement11 ValidMessage() =>
        IsoDataFactory.Make<IAccountStatement11>(b => b
            .Set(x => x.Identification).To("STMT-001")
            .Set(x => x.Account).To(IsoDataFactory.Make<ICashAccount41>())
            .Set(x => x.Balance).To([ValidBalance()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Balance: CashBalance8, 1..∞ ────────────────────────────────────────────

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
