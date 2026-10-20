// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using RptgSrc1 = BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice;
using SeqRange1 = BeneficialStrategies.Iso20022.Choices.SequenceRange1Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement15ValidatorTests
{
    private readonly AccountStatement15Validator _sut = new();

    private static ICashBalance8 ValidBalance() =>
        IsoDataFactory.Make<ICashBalance8>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<IBalanceType13>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.BalanceType10Choice.ICode>(b3 => b3
                    .Set(x3 => x3.Value).To(ExternalBalanceType1Code.ClosingAvailable)))))
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.CreditDebitIndicator).To(CreditDebitCode.Credit)
            .Set(x => x.Date).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1)))));

    private static IAccountStatement15 ValidMessage() =>
        IsoDataFactory.Make<IAccountStatement15>(b => b
            .Set(x => x.Identification).To("STMT-001")
            .Set(x => x.Account).To(IsoDataFactory.Make<ICashAccount43>())
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

    // ── ReportingSequence: SequenceRange1Choice variants ─────────────────────────

    [Fact]
    public void ReportingSequence_FromSequence_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReportingSequence).To(IsoDataFactory.Make<SeqRange1.IFromSequence>(b2 => b2
                .Set(x2 => x2.Value).To("SEQ-001"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_ToSequence_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReportingSequence).To(IsoDataFactory.Make<SeqRange1.IToSequence>(b2 => b2
                .Set(x2 => x2.Value).To("SEQ-999"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_FromToSequence_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReportingSequence).To(IsoDataFactory.Make<SeqRange1.IFromToSequence>(b2 => b2
                .Set(x2 => x2.FromSequence).To("SEQ-001")
                .Set(x2 => x2.ToSequence).To("SEQ-999"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_EqualSequence_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReportingSequence).To(IsoDataFactory.Make<SeqRange1.IEqualSequence>(b2 => b2
                .Set(x2 => x2.Value).To("SEQ-005"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_NotEqualSequence_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReportingSequence).To(IsoDataFactory.Make<SeqRange1.INotEqualSequence>(b2 => b2
                .Set(x2 => x2.Value).To("SEQ-006"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
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
