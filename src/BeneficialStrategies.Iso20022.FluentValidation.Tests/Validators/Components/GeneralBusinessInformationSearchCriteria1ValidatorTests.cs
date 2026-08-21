// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GeneralBusinessInformationSearchCriteria1ValidatorTests
{
    private readonly GeneralBusinessInformationSearchCriteria1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new GeneralBusinessInformationSearchCriteria1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = new GeneralBusinessInformationSearchCriteria1
        {
            Reference = ["REF-001"],
            Subject = [new BeneficialStrategies.Iso20022.Choices.CharacterSearch1Choice.Equal { Value = "SUBJECT" }],
            Qualifier = [new InformationQualifierType1 { IsFormatted = true, Priority = Priority1Code.High }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
