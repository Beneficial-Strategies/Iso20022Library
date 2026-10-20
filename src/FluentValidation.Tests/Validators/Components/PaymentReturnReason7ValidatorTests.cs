// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentReturnReason7ValidatorTests
{
    private readonly PaymentReturnReason7Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentReturnReason7>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Originator_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentReturnReason7>(b => b
            .Set(x => x.Originator).To(IsoDataFactory.Make<IPartyIdentification272>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Reason_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentReturnReason7>(b => b
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.ReturnReason5Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("CUSTOM"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AdditionalInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentReturnReason7>(b => b
            .Set(x => x.AdditionalInformation).To(["More detail here."]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
