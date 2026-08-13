// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class IntraBalanceCancellation7ValidatorTests
{
    private readonly IntraBalanceCancellation7Validator _sut = new();

    private static CashAccount40 ValidAccount() => new();

    private static SystemPartyIdentification8 ValidOwner() =>
        new() { Identification = new PartyIdentification136 { Identification = new Choices.PartyIdentification120Choice.NameAndAddress { Name = "Owner" } } };

    private static BranchAndFinancialInstitutionIdentification8 ValidServicer() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static ProcessingStatus69Choice_ ValidStatus() => new Choices.ProcessingStatus69Choice.AcknowledgedAccepted();

    private static IntraBalanceCancellation8 MinimalItem() => new() { RequestReference = "REQ-001" };

    // ValidMessage sets all four top-level fields and no item-level equivalents — satisfies all
    // four XOR constraints simultaneously (top-level present, item-level absent).
    private static IntraBalanceCancellation7 ValidMessage() =>
        new()
        {
            CashAccount = ValidAccount(),
            CashAccountOwner = ValidOwner(),
            CashAccountServicer = ValidServicer(),
            ProcessingStatus = ValidStatus(),
            Cancellation = [MinimalItem()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Cancellation: 1..* ────────────────────────────────────────────────────

    [Fact]
    public void Cancellation_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Cancellation = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Cancellation);
    }

    // ── CashAccountRule ───────────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccount_Violates_CashAccountRule()
    {
        var msg = ValidMessage() with { Cancellation = [MinimalItem() with { CashAccount = ValidAccount() }] };
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

    [Fact]
    public void TopLevelCashAccountOnly_DoesNotViolate_CashAccountRule()
    {
        var result = _sut.Validate(ValidMessage());
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "CashAccountRule");
    }

    // ── CashAccountOwnerRule ──────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccountOwner_Violates_CashAccountOwnerRule()
    {
        var msg = ValidMessage() with { Cancellation = [MinimalItem() with { CashAccountOwner = ValidOwner() }] };
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

    // ── ProcessingStatusRule ──────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemProcessingStatus_Violates_ProcessingStatusRule()
    {
        var msg = ValidMessage() with { Cancellation = [MinimalItem() with { ProcessingStatus = ValidStatus() }] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ProcessingStatusRule");
    }

    [Fact]
    public void NeitherProcessingStatus_Violates_ProcessingStatusRule()
    {
        var msg = ValidMessage() with { ProcessingStatus = null };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ProcessingStatusRule");
    }

    // ── CashAccountServicerRule ───────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccountServicer_Violates_CashAccountServicerRule()
    {
        var msg = ValidMessage() with
        {
            Cancellation = [MinimalItem() with { CashAccountServicer = ValidServicer() }],
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
