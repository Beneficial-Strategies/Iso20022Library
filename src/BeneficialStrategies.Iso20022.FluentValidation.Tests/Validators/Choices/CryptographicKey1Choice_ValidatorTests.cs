// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CryptographicKey1Choice_ValidatorTests
{
    private readonly CryptographicKey1Choice_Validator _sut = new();

    [Fact]
    public void Signature_NoValidationErrors()
    {
        var msg = new BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.Signature
        {
            Value = new string('A', 64),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ILPV4_NoValidationErrors()
    {
        var msg = new BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice.ILPV4 { Value = "AB12" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
