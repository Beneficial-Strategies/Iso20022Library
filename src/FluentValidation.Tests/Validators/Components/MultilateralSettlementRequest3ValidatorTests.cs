// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MultilateralSettlementRequest3ValidatorTests
{
    private readonly MultilateralSettlementRequest3Validator _sut = new();

    private static IMovementRecord2 ValidMovementRecord(string id) =>
        IsoDataFactory.Make<IMovementRecord2>(b => b
            .Set(x => x.Identification).To(id)
            .Set(x => x.Amount).To(IsoDataFactory.Make<IAmountAndDirection5>(b2 => b2
                .Set(x2 => x2.Amount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }))));

    private static IMultilateralSettlementRequest3 ValidMessage() =>
        IsoDataFactory.Make<IMultilateralSettlementRequest3>(b => b
            .Set(x => x.InstructionIdentification).To("INSTR-001")
            .Set(x => x.MovementRecord).To([ValidMovementRecord("MVMT-001"), ValidMovementRecord("MVMT-002")]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── MovementRecord minimum-count (2..∞) ──────────────────────────────────────

    [Fact]
    public void MovementRecord_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.MovementRecord).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "MovementRecord");
    }

    [Fact]
    public void MovementRecord_OnlyOne_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.MovementRecord).To([ValidMovementRecord("MVMT-001")]));
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
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructionPriority).To(Priority3Code.Normal));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeRequest_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementTimeRequest).To(IsoDataFactory.Make<ISettlementTimeRequest2>(b2 => b2
                .Set(x2 => x2.FromTime).To(new TimeOnly(9, 0, 0)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
