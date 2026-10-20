// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GeneralBusinessInformationReturnCriteria1ValidatorTests
{
    private readonly GeneralBusinessInformationReturnCriteria1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IGeneralBusinessInformationReturnCriteria1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IGeneralBusinessInformationReturnCriteria1>(b => b
            .Set(x => x.QualifierIndicator).To(true)
            .Set(x => x.SubjectIndicator).To(true)
            .Set(x => x.SubjectDetailsIndicator).To(false));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
