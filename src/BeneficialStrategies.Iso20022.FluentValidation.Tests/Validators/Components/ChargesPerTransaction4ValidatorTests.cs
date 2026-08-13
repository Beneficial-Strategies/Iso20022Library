// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerTransaction4ValidatorTests
{
    private readonly ChargesPerTransaction4Validator _sut = new();

    private static CashAccount40 ValidAccount() => new();

    private static BranchAndFinancialInstitutionIdentification8 ValidOwner() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static ChargesPerTransactionRecord4 MinimalRecord() =>
        new() { UnderlyingTransaction = new TransactionReferences7() };

    private static ChargesPerTransaction4 ValidMessage() => new() { Record = [MinimalRecord()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Record: ChargesPerTransactionRecord4, 1..∞ ────────────────────────────

    [Fact]
    public void Record_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Record = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Record);
    }

    // ── ChargesAccountTransactionOrRecord2Rule / 1Rule ────────────────────────
    // Both rules express the same mutual-exclusivity condition from opposite directions.

    [Fact]
    public void TopLevelAccountAndRecordAccount_Violates_BothRules()
    {
        var msg = ValidMessage() with
        {
            ChargesAccount = ValidAccount(),
            Record = [MinimalRecord() with { ChargesAccount = ValidAccount() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }

    [Fact]
    public void TopLevelOwnerAndRecordOwner_Violates_BothRules()
    {
        var msg = ValidMessage() with
        {
            ChargesAccountOwner = ValidOwner(),
            Record = [MinimalRecord() with { ChargesAccountOwner = ValidOwner() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }

    [Fact]
    public void TopLevelAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = ValidMessage() with { ChargesAccount = ValidAccount() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }

    [Fact]
    public void RecordAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = ValidMessage() with { Record = [MinimalRecord() with { ChargesAccount = ValidAccount() }] };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }
}
