// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerType6ValidatorTests
{
    private readonly ChargesPerType6Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static CashAccount40 ValidAccount() => new();

    private static ChargesPerTypeRecord6 MinimalRecord() =>
        new()
        {
            UnderlyingTransaction = new TransactionReferences7(),
            Amount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m },
        };

    private static ChargesPerType6 ValidMessage() =>
        new()
        {
            Type = new Choices.ChargeType3Choice.Proprietary { Identification = "CHRG" },
            Record = [MinimalRecord()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Record: ChargesPerTypeRecord6, 1..∞ ───────────────────────────────────

    [Fact]
    public void Record_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Record = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Record);
    }

    // ── ChargesAccountAgent2Rule / ChargesAccountAgentRule ────────────────────
    // Both rules express the same mutual-exclusivity condition from opposite directions.

    [Fact]
    public void TopLevelAgentAndRecordAgent_Violates_BothRules()
    {
        var msg = ValidMessage() with
        {
            ChargesAccountAgent = ValidAgent(),
            Record = [MinimalRecord() with { ChargesAccountAgent = ValidAgent() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }

    [Fact]
    public void TopLevelAgentAccountAndRecordAgentAccount_Violates_BothRules()
    {
        var msg = ValidMessage() with
        {
            ChargesAccountAgentAccount = ValidAccount(),
            Record = [MinimalRecord() with { ChargesAccountAgentAccount = ValidAccount() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }

    [Fact]
    public void TopLevelAgentOnly_DoesNotViolate_EitherRule()
    {
        var msg = ValidMessage() with { ChargesAccountAgent = ValidAgent() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }

    [Fact]
    public void RecordAgentOnly_DoesNotViolate_EitherRule()
    {
        var msg = ValidMessage() with { Record = [MinimalRecord() with { ChargesAccountAgent = ValidAgent() }] };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }
}
