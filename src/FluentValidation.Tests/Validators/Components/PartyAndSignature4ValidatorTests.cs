// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PartyAndSignature4ValidatorTests
{
    private readonly PartyAndSignature4Validator _sut = new();

    private static IPartyAndSignature4 ValidMessage() =>
        IsoDataFactory.Make<IPartyAndSignature4>(b => b
            .Set(x => x.Party).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Signing Co")))
            .Set(x => x.Signature).To(new SkipPayload()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
