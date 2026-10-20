// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupHeader20ValidatorTests
{
    private readonly OriginalGroupHeader20Validator _sut = new();

    private static IOriginalGroupHeader20 ValidMessage() =>
        IsoDataFactory.Make<IOriginalGroupHeader20>(b => b
            .Set(x => x.OriginalMessageIdentification).To("MSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pain.007.001.13"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalCreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.ReversalReasonInformation).To([IsoDataFactory.Make<IPaymentReversalReason10>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
