// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditorReferenceType3ValidatorTests
{
    private readonly CreditorReferenceType3Validator _sut = new();

    private static ICreditorReferenceType3 ValidMessage() =>
        IsoDataFactory.Make<ICreditorReferenceType3>(b => b
            .Set(x => x.CodeOrProprietary).To(IsoDataFactory.Make<Choices.CreditorReferenceType2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYREFTYPE"))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Issuer).To("IssuerCo"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
