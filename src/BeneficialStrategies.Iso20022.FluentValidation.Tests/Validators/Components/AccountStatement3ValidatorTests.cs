// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using RptgSrc1 = BeneficialStrategies.Iso20022.Choices.ReportingSource1Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement3ValidatorTests
{
    private readonly AccountStatement3Validator _sut = new();

    private static CashBalance3 ValidBalance() =>
        new()
        {
            Type = new BalanceType12
            {
                CodeOrProprietary = new Choices.BalanceType5Choice.Code
                {
                    Value = BalanceType12Code.OpeningAvailable,
                },
            },
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            CreditDebitIndicator = CreditDebitCode.Credit,
            Date = new Choices.DateAndDateTimeChoice.Date { Value = new DateOnly(2026, 1, 1) },
        };

    private static AccountStatement3 ValidMessage() =>
        new()
        {
            Identification = "STMT-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            Account = new CashAccount25
            {
                Identification = new Choices.AccountIdentification4Choice.Other
                {
                    Identification = "ACC-001",
                },
            },
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
