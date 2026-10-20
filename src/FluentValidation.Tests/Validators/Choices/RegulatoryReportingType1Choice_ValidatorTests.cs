// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class RegulatoryReportingType1Choice_ValidatorTests
{
    private readonly RegulatoryReportingType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice.Code
        {
            Value = "CRED",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice.Proprietary
        {
            Value = "MYTYPE",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CodeVariant_PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ExternalRegulatoryReportingType1Code>();
        registry.Add("CRED");
        var sut = new RegulatoryReportingType1Choice_Validator(new ExternalRegulatoryReportingType1CodeValidator(registry));

        var value = new BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice.Code
        {
            Value = "DEBT",
        };
        var result = sut.Validate(value);
        Assert.False(result.IsValid);
    }
}
