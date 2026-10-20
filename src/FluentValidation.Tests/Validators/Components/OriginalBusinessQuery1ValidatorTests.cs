// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalBusinessQuery1ValidatorTests
{
    private readonly OriginalBusinessQuery1Validator _sut = new();

    private static IOriginalBusinessQuery1 ValidMessage() => IsoDataFactory.Make<IOriginalBusinessQuery1>(b => b
        .Set(x => x.MessageIdentification).To("ORIG-MSG-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.MessageNameIdentification).To("camt.003.001.08")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
