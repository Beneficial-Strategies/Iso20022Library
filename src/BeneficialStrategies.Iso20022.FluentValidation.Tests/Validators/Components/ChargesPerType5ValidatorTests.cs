// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerType5ValidatorTests
{
    private readonly ChargesPerType5Validator _sut = new();

    private static CashAccount40 ValidAccount() => new();

    private static BranchAndFinancialInstitutionIdentification8 ValidOwner() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static ChargesPerTypeRecord5 MinimalRecord() =>
        new()
        {
            UnderlyingTransaction = new TransactionReferences7(),
            Amount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m },
        };

    private static ChargesPerType5 ValidMessage() =>
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

    // ── Record: ChargesPerTypeRecord5, 1..∞ ───────────────────────────────────

    [Fact]
    public void Record_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Record = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Record);
    }

    // ── ChargesAccountTypeOrRecord2Rule / 1Rule ───────────────────────────────
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
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
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
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
    }

    [Fact]
    public void TopLevelAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = ValidMessage() with { ChargesAccount = ValidAccount() };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
    }

    [Fact]
    public void RecordAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = ValidMessage() with { Record = [MinimalRecord() with { ChargesAccount = ValidAccount() }] };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
    }
}
