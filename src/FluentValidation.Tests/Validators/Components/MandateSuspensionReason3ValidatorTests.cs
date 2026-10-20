// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateSuspensionReason3ValidatorTests
{
    private readonly MandateSuspensionReason3Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IMandateSuspensionReason1Choice ValidReason() =>
        IsoDataFactory.Make<Choices.MandateSuspensionReason1Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalMandateSuspensionReason1Code.ContractAmended));

    private static IMandateSuspensionReason3 ValidMessage() => IsoDataFactory.Make<IMandateSuspensionReason3>(b => b
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
