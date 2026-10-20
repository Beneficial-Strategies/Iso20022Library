// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateCancellationReason2ValidatorTests
{
    private readonly MandateCancellationReason2Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IMandateReason1Choice ValidReason() =>
        IsoDataFactory.Make<Choices.MandateReason1Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalMandateReason1Code.IncorrectAccountNumber));

    private static IMandateCancellationReason2 ValidMessage() => IsoDataFactory.Make<IMandateCancellationReason2>(b => b
        .Set(x => x.Reason).To(ValidReason()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AdditionalInformation).To(["Additional detail"])
            .Set(x => x.Originator).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Originator Co"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
