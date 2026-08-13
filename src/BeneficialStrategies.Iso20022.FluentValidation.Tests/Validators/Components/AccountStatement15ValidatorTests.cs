// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using RptgSrc1 = BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice;
using SeqRange1 = BeneficialStrategies.Iso20022.Choices.SequenceRange1Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement15ValidatorTests
{
    private readonly AccountStatement15Validator _sut = new();

    private static CashBalance8 ValidBalance() =>
        new()
        {
            Type = new BalanceType13
            {
                CodeOrProprietary = new Choices.BalanceType10Choice.Code
                {
                    Value = ExternalBalanceType1Code.ClosingAvailable,
                },
            },
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            CreditDebitIndicator = CreditDebitCode.Credit,
            Date = new Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2026, 1, 1) },
        };

    private static AccountStatement15 ValidMessage() =>
        new()
        {
            Identification = "STMT-001",
            Account = new CashAccount43(),
            Balance = [ValidBalance()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Balance: 1..∞ ──────────────────────────────────────────────────────────

    [Fact]
    public void Balance_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Balance = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Balance);
    }

    [Fact]
    public void Balance_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { Balance = [ValidBalance()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Balance);
    }

    // ── ReportingSequence: SequenceRange1Choice variants ─────────────────────────

    [Fact]
    public void ReportingSequence_FromSequence_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ReportingSequence = new SeqRange1.FromSequence { Value = "SEQ-001" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_ToSequence_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ReportingSequence = new SeqRange1.ToSequence { Value = "SEQ-999" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_FromToSequence_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ReportingSequence = new SeqRange1.FromToSequence
            {
                FromSequence = "SEQ-001",
                ToSequence = "SEQ-999",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_EqualSequence_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ReportingSequence = new SeqRange1.EqualSequence { Value = "SEQ-005" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSequence_NotEqualSequence_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ReportingSequence = new SeqRange1.NotEqualSequence { Value = "SEQ-006" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── ReportingSource: ReportingSource1Choice variants ─────────────────────────

    [Fact]
    public void ReportingSource_Code_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ReportingSource = new RptgSrc1.Code
            {
                Value = ExternalReportingSource1Code.Accounting,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReportingSource_Proprietary_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            ReportingSource = new RptgSrc1.Proprietary { Value = "SRC-001" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
