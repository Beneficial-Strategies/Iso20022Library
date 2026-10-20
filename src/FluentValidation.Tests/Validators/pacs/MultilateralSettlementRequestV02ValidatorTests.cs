// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class MultilateralSettlementRequestV02ValidatorTests
{
    private readonly MultilateralSettlementRequestV02Validator _sut = new();

    private static IGroupHeader104 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader104>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfSettlementRequests).To("1"));

    private static IMovementRecord2 ValidMovementRecord(string id) =>
        IsoDataFactory.Make<IMovementRecord2>(b => b
            .Set(x => x.Identification).To(id)
            .Set(x => x.Amount).To(IsoDataFactory.Make<IAmountAndDirection5>(b2 => b2
                .Set(x2 => x2.Amount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }))));

    private static IMultilateralSettlementRequest3 ValidSettlementRequest() =>
        IsoDataFactory.Make<IMultilateralSettlementRequest3>(b => b
            .Set(x => x.InstructionIdentification).To("INSTR-001")
            .Set(x => x.MovementRecord).To([ValidMovementRecord("MVMT-001"), ValidMovementRecord("MVMT-002")]));

    private static IMultilateralSettlementRequestV02 ValidMessage() =>
        IsoDataFactory.Make<IMultilateralSettlementRequestV02>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.SettlementRequest).To([ValidSettlementRequest()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── SettlementRequest minimum-count (1..∞) ───────────────────────────────────

    [Fact]
    public void SettlementRequest_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementRequest).To([]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "SettlementRequest");
    }

    [Fact]
    public void SettlementRequest_MultipleElements_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementRequest).To([
                ValidSettlementRequest(),
                IsoDataFactory.With(ValidSettlementRequest(), b2 => b2
                    .Set(x2 => x2.InstructionIdentification).To("INSTR-002")),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Nested validation propagation ────────────────────────────────────────────

    [Fact]
    public void SettlementRequest_WithInvalidMovementRecordCount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementRequest).To([
                IsoDataFactory.With(ValidSettlementRequest(), b2 => b2
                    .Set(x2 => x2.MovementRecord).To([ValidMovementRecord("MVMT-001")])),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName.EndsWith("MovementRecord"));
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To(IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
