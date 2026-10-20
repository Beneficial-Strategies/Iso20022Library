// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalMessageInformation1ValidatorTests
{
    private readonly OriginalMessageInformation1Validator _sut = new();

    private static IOriginalMessageInformation1 ValidMessage() =>
        IsoDataFactory.Make<IOriginalMessageInformation1>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.MessageNameIdentification).To("pain.017.001.04"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreationDateTime_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
