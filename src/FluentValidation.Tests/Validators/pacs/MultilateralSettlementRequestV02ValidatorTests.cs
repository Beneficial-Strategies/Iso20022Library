// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class MultilateralSettlementRequestV02ValidatorTests
{
    private readonly MultilateralSettlementRequestV02Validator _sut = new();

    private static GroupHeader104 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfSettlementRequests = "1",
        };

    private static MovementRecord2 ValidMovementRecord(string id) =>
        new()
        {
            Identification = id,
            Amount = new AmountAndDirection5
            {
                Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            },
        };

    private static MultilateralSettlementRequest3 ValidSettlementRequest() =>
        new()
        {
            InstructionIdentification = "INSTR-001",
            MovementRecord = [ValidMovementRecord("MVMT-001"), ValidMovementRecord("MVMT-002")],
        };

    private static MultilateralSettlementRequestV02 ValidMessage() =>
        new() { GroupHeader = ValidGroupHeader(), SettlementRequest = [ValidSettlementRequest()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── SettlementRequest minimum-count (1..∞) ───────────────────────────────────

    [Fact]
    public void SettlementRequest_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { SettlementRequest = [] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "SettlementRequest");
    }

    [Fact]
    public void SettlementRequest_MultipleElements_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementRequest =
            [
                ValidSettlementRequest(),
                ValidSettlementRequest() with { InstructionIdentification = "INSTR-002" },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Nested validation propagation ────────────────────────────────────────────

    [Fact]
    public void SettlementRequest_WithInvalidMovementRecordCount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementRequest =
            [
                ValidSettlementRequest() with { MovementRecord = [ValidMovementRecord("MVMT-001")] },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName.EndsWith("MovementRecord"));
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
