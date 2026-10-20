// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class IntraBalanceMovements4ValidatorTests
{
    private readonly IntraBalanceMovements4Validator _sut = new();

    private static CashAccount40 ValidAccount() => new();

    private static SystemPartyIdentification8 ValidOwner() =>
        new()
        {
            Identification = new PartyIdentification136
            {
                Identification = new Choices.PartyIdentification120Choice.NameAndAddress { Name = "Owner" },
            },
        };

    private static BranchAndFinancialInstitutionIdentification8 ValidServicer() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static IntraBalanceStatusAndReason2 ValidStatusAndReason() => new();

    private static IntraBalanceMovement7 MinimalItem() => new() { AccountOwnerTransactionIdentification = "TXN-001" };

    // ValidMessage sets all four top-level fields and no item-level equivalents — satisfies all
    // four XOR constraints simultaneously (top-level present, item-level absent).
    private static IntraBalanceMovements4 ValidMessage() =>
        new()
        {
            CashAccount = ValidAccount(),
            CashAccountOwner = ValidOwner(),
            CashAccountServicer = ValidServicer(),
            StatusAndReason = ValidStatusAndReason(),
            Movement = [MinimalItem()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Movement: 1..* ────────────────────────────────────────────────────────

    [Fact]
    public void Movement_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Movement = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Movement);
    }

    // ── CashAccountRule ───────────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccount_Violates_CashAccountRule()
    {
        var msg = ValidMessage() with { Movement = [MinimalItem() with { CashAccount = ValidAccount() }] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountRule");
    }

    [Fact]
    public void NeitherCashAccount_Violates_CashAccountRule()
    {
        var msg = ValidMessage() with { CashAccount = null };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountRule");
    }

    // ── CashAccountOwnerRule ──────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccountOwner_Violates_CashAccountOwnerRule()
    {
        var msg = ValidMessage() with { Movement = [MinimalItem() with { CashAccountOwner = ValidOwner() }] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountOwnerRule");
    }

    [Fact]
    public void NeitherCashAccountOwner_Violates_CashAccountOwnerRule()
    {
        var msg = ValidMessage() with { CashAccountOwner = null };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountOwnerRule");
    }

    // ── StatusAndReasonRule ───────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemStatusAndReason_Violates_StatusAndReasonRule()
    {
        var msg = ValidMessage() with
        {
            Movement = [MinimalItem() with { StatusAndReason = ValidStatusAndReason() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "StatusAndReasonRule");
    }

    [Fact]
    public void NeitherStatusAndReason_Violates_StatusAndReasonRule()
    {
        var msg = ValidMessage() with { StatusAndReason = null };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "StatusAndReasonRule");
    }

    // ── CashAccountServicerRule ───────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccountServicer_Violates_CashAccountServicerRule()
    {
        var msg = ValidMessage() with
        {
            Movement = [MinimalItem() with { CashAccountServicer = ValidServicer() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountServicerRule");
    }

    [Fact]
    public void NeitherCashAccountServicer_Violates_CashAccountServicerRule()
    {
        var msg = ValidMessage() with { CashAccountServicer = null };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountServicerRule");
    }
}
