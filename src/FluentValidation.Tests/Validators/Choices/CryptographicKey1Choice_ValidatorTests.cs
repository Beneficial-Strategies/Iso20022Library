// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CryptographicKey1Choice_ValidatorTests
{
    private readonly CryptographicKey1Choice_Validator _sut = new();

    [Fact]
    public void Signature_NoValidationErrors()
    {
        var msg = BeneficialStrategies.Iso20022.Messages.Samples.CryptographicKey1Choice.Valid.Signature.Minimal;
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ILPV4_NoValidationErrors()
    {
        var msg = BeneficialStrategies.Iso20022.Messages.Samples.CryptographicKey1Choice.Valid.ILPV4.Minimal;
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
