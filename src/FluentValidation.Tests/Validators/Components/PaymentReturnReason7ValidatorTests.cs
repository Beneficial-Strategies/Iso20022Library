// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentReturnReason7ValidatorTests
{
    private readonly PaymentReturnReason7Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentReturnReason7()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Originator_Present_NoValidationError()
    {
        var msg = new PaymentReturnReason7 { Originator = new PartyIdentification272() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Reason_Present_NoValidationError()
    {
        var msg = new PaymentReturnReason7
        {
            Reason = new BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice.Proprietary { Value = "CUSTOM" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AdditionalInformation_Present_NoValidationError()
    {
        var msg = new PaymentReturnReason7 { AdditionalInformation = ["More detail here."] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
