// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GenericFinancialIdentification1ValidatorTests
{
    private readonly GenericFinancialIdentification1Validator _sut = new();

    private static GenericFinancialIdentification1 ValidMessage() =>
        new() { Identification = "ID-001" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SchemeName_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SchemeName =
                new BeneficialStrategies.Iso20022.Choices.FinancialIdentificationSchemeName1Choice.Proprietary
                {
                    Value = "MYSCHEME",
                },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
