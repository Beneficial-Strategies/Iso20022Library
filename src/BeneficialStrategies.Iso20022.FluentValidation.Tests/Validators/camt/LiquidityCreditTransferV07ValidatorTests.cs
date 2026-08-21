// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class LiquidityCreditTransferV07ValidatorTests
{
    private readonly LiquidityCreditTransferV07Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static LiquidityCreditTransfer4 ValidLiquidityCreditTransfer() =>
        new()
        {
            TransferredAmount = new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency
            {
                Currency = "USD",
                Amount = 100m,
            },
        };

    private static LiquidityCreditTransferV07 ValidMessage() =>
        new() { MessageHeader = ValidMessageHeader(), LiquidityCreditTransfer = ValidLiquidityCreditTransfer() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
