// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class References80Choice_ValidatorTests
{
    private readonly References80Choice_Validator _sut = new();

    [Fact]
    public void CommonIdentification_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<Choices.References80Choice.ICommonIdentification>(b => b
            .Set(x => x.Value).To("REF-001"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UniqueTransactionIdentifier_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<Choices.References80Choice.IUniqueTransactionIdentifier>(b => b
            .Set(x => x.Value).To("ABCDEFGHIJKLMNOPQR12"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
