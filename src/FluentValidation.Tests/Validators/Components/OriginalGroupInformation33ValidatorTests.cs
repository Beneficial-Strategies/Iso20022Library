// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupInformation33ValidatorTests
{
    private readonly OriginalGroupInformation33Validator _sut = new();

    private static IOriginalGroupInformation33 ValidMessage() =>
        IsoDataFactory.Make<IOriginalGroupInformation33>(b => b
            .Set(x => x.OriginalMessageIdentification).To("MSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.08"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalCreationDateTime_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalCreationDateTime).To(new DateTime(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
