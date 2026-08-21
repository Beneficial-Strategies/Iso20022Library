// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PartyAndSignature4ValidatorTests
{
    private readonly PartyAndSignature4Validator _sut = new();

    private static PartyAndSignature4 ValidMessage() =>
        new()
        {
            Party = new PartyIdentification272 { Name = "Signing Co" },
            Signature = new SkipPayload(),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
