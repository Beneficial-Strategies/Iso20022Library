// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader110ValidatorTests
{
    private readonly GroupHeader110Validator _sut = new();

    private static IGroupHeader110 ValidMessage() =>
        IsoDataFactory.Make<IGroupHeader110>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Authorisation).To([
                IsoDataFactory.Make<Choices.Authorisation1Choice.IProprietary>(b2 => b2
                    .Set(x2 => x2.Value).To("LEVEL2")),
            ])
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Acme Corp")))
            .Set(x => x.InstructingAgent).To(agent)
            .Set(x => x.InstructedAgent).To(agent));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
