// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MultilateralSettlementRequest3ValidatorTests
{
    private readonly MultilateralSettlementRequest3Validator _sut = new();

    private static MovementRecord2 ValidMovementRecord(string id) =>
        new()
        {
            Identification = id,
            Amount = new AmountAndDirection5
            {
                Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            },
        };

    private static MultilateralSettlementRequest3 ValidMessage() =>
        new()
        {
            InstructionIdentification = "INSTR-001",
            MovementRecord = [ValidMovementRecord("MVMT-001"), ValidMovementRecord("MVMT-002")],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── MovementRecord minimum-count (2..∞) ──────────────────────────────────────

    [Fact]
    public void MovementRecord_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { MovementRecord = [] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "MovementRecord");
    }

    [Fact]
    public void MovementRecord_OnlyOne_HasValidationError()
    {
        var msg = ValidMessage() with { MovementRecord = [ValidMovementRecord("MVMT-001")] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "MovementRecord");
    }

    [Fact]
    public void MovementRecord_TwoElements_NoValidationError()
    {
        var result = _sut.Validate(ValidMessage());
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "MovementRecord");
    }

    // ── Optional fields ──────────────────────────────────────────────────────────

    [Fact]
    public void InstructionPriority_Present_NoValidationError()
    {
        var msg = ValidMessage() with { InstructionPriority = Priority3Code.Normal };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeRequest_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementTimeRequest = new SettlementTimeRequest2 { FromTime = new TimeOnly(9, 0, 0) },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
