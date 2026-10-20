// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement1ValidatorTests
{
    private readonly AccountStatement1Validator _sut = new();

    private static ICashBalance2 ValidBalance() =>
        IsoDataFactory.Make<ICashBalance2>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.BalanceType2Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(Codesets.BalanceType9Code.OpeningBooked)))
            .Set(x => x.Amount).To(new CurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.CreditDebitIndicator).To(Codesets.CreditDebitCode.Credit)
            .Set(x => x.Date).To(IsoDataFactory.Make<Choices.DateAndDateTimeChoice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));

    private static IAccountStatement1 ValidMessage() =>
        IsoDataFactory.Make<IAccountStatement1>(b => b
            .Set(x => x.Identification).To("STMT-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.Account).To(IsoDataFactory.Make<ICashAccount13>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification3Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000")))))
            .Set(x => x.Balance).To([ValidBalance()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Balance: CashBalance2, 1..∞ ────────────────────────────────────────────

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
