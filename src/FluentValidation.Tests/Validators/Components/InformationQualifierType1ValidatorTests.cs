// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InformationQualifierType1ValidatorTests
{
    private readonly InformationQualifierType1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IInformationQualifierType1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IInformationQualifierType1>(b => b
            .Set(x => x.IsFormatted).To(true)
            .Set(x => x.Priority).To(Priority1Code.High));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
