// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentReversalReason10ValidatorTests
{
    private readonly PaymentReversalReason10Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentReversalReason10>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentReversalReason10>(b => b
            .Set(x => x.AdditionalInformation).To(["Reversal note"])
            .Set(x => x.Originator).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Originator Co")))
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.ReversalReason4Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYREVREASON"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
