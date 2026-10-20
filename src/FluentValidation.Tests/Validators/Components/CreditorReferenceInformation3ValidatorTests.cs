// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditorReferenceInformation3ValidatorTests
{
    private readonly CreditorReferenceInformation3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ICreditorReferenceInformation3>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ICreditorReferenceInformation3>(b => b
            .Set(x => x.Reference).To("REF-001")
            .Set(x => x.Type).To(IsoDataFactory.Make<ICreditorReferenceType3>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.CreditorReferenceType2Choice.IProprietary>(b3 => b3
                    .Set(x3 => x3.Value).To("MYREFTYPE"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
