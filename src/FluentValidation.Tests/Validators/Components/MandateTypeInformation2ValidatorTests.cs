// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateTypeInformation2ValidatorTests
{
    private readonly MandateTypeInformation2Validator _sut = new();

    private static MandateTypeInformation2 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ServiceLevel = new BeneficialStrategies.Iso20022.Choices.ServiceLevel8Choice.Proprietary
            {
                Value = "MYSVCLVL",
            },
            LocalInstrument = new BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice.Proprietary
            {
                Value = "MYINSTR",
            },
            CategoryPurpose = new BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice.Proprietary
            {
                Value = "MYCAT",
            },
            Classification = new BeneficialStrategies.Iso20022.Choices.MandateClassification1Choice.Proprietary
            {
                Value = "MYCLASS",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
