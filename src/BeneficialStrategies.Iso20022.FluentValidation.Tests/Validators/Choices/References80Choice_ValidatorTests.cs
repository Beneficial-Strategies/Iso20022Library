// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class References80Choice_ValidatorTests
{
    private readonly References80Choice_Validator _sut = new();

    [Fact]
    public void CommonIdentification_NoValidationErrors()
    {
        var msg = new BeneficialStrategies.Iso20022.Choices.References80Choice.CommonIdentification
        {
            Value = "REF-001",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UniqueTransactionIdentifier_NoValidationErrors()
    {
        var msg = new BeneficialStrategies.Iso20022.Choices.References80Choice.UniqueTransactionIdentifier
        {
            Value = "ABCDEFGHIJKLMNOPQR12",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
