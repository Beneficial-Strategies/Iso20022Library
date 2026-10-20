// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader128ValidatorTests
{
    private readonly GroupHeader128Validator _sut = new();

    private static IGroupHeader128 ValidMessage() =>
        IsoDataFactory.Make<IGroupHeader128>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Initiator Co")))
            .Set(x => x.ForwardingAgent).To(agent)
            .Set(x => x.DebtorAgent).To(agent)
            .Set(x => x.CreditorAgent).To(agent));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
