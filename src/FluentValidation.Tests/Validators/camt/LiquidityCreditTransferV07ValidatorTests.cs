// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class LiquidityCreditTransferV07ValidatorTests
{
    private readonly LiquidityCreditTransferV07Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static ILiquidityCreditTransfer4 ValidLiquidityCreditTransfer() =>
        IsoDataFactory.Make<ILiquidityCreditTransfer4>(b => b
            .Set(x => x.TransferredAmount).To(IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m))));

    private static ILiquidityCreditTransferV07 ValidMessage() =>
        IsoDataFactory.Make<ILiquidityCreditTransferV07>(b => b
            .Set(x => x.MessageHeader).To(ValidMessageHeader())
            .Set(x => x.LiquidityCreditTransfer).To(ValidLiquidityCreditTransfer()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
