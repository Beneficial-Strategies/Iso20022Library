// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AcceptanceResult6ValidatorTests
{
    private readonly AcceptanceResult6Validator _sut = new();

    private static IAcceptanceResult6 ValidMessage() => IsoDataFactory.Make<IAcceptanceResult6>(b => b
        .Set(x => x.Accepted).To(true));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Accepted).To(false)
            .Set(x => x.RejectReason).To(IsoDataFactory.Make<Choices.MandateReason1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalMandateReason1Code.IncorrectAccountNumber)))
            .Set(x => x.AdditionalRejectReasonInformation).To(["Additional detail"]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
