// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Case6ValidatorTests
{
    private readonly Case6Validator _sut = new();

    private static ICase6 ValidMessage() =>
        IsoDataFactory.Make<ICase6>(b => b
            .Set(x => x.Identification).To("CASE-001")
            .Set(x => x.Creator).To(IsoDataFactory.Make<Choices.Party50Choice.IParty>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                    .Set(x3 => x3.Name).To("Acme Corp"))))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReopenCaseIndication_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ReopenCaseIndication).To(true));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
