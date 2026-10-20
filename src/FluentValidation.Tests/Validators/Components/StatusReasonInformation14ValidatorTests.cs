// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StatusReasonInformation14ValidatorTests
{
    private readonly StatusReasonInformation14Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IStatusReasonInformation14>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IStatusReasonInformation14>(b => b
            .Set(x => x.AdditionalInformation).To(["Status note"])
            .Set(x => x.Originator).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Originator Co")))
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.StatusReason6Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYSTATUSREASON"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
