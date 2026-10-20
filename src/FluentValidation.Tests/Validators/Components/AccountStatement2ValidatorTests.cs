// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using RptgSrc1 = BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement2ValidatorTests
{
    private readonly AccountStatement2Validator _sut = new();

    private static ICashBalance3 ValidBalance() =>
        IsoDataFactory.Make<ICashBalance3>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<IBalanceType12>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.BalanceType5Choice.ICode>(b3 => b3
                    .Set(x3 => x3.Value).To(BalanceType12Code.OpeningAvailable)))))
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.CreditDebitIndicator).To(CreditDebitCode.Credit)
            .Set(x => x.Date).To(IsoDataFactory.Make<Choices.DateAndDateTimeChoice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));

    private static IAccountStatement2 ValidMessage() =>
        IsoDataFactory.Make<IAccountStatement2>(b => b
            .Set(x => x.Identification).To("STMT-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.Account).To(IsoDataFactory.Make<ICashAccount20>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b3 => b3
                    .Set(x3 => x3.Identification).To("ACC-001")))))
            .Set(x => x.Balance).To([ValidBalance()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Balance: 1..∞ ──────────────────────────────────────────────────────────

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

    // ── ReportingSource: ReportingSource1Choice variants ─────────────────────────

    [Fact]
    public void ReportingSource_Code_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReportingSource).To(IsoDataFactory.Make<RptgSrc1.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalReportingSource1Code.Accounting))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSource_Proprietary_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReportingSource).To(IsoDataFactory.Make<RptgSrc1.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("SRC-001"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
