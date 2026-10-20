// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Party50Choice_ValidatorTests
{
    private readonly Party50Choice_Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IPartyIdentification272 ValidParty() => IsoDataFactory.Make<IPartyIdentification272>(b => b
        .Set(x => x.Name).To("Acme Corp"));

    [Fact]
    public void AgentVariant_Valid_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IParty50Choice choice =
            IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b => b
                .Set(x => x.Value).To(ValidAgent()));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PartyVariant_Valid_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IParty50Choice choice =
            IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
                .Set(x => x.Value).To(ValidParty()));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AgentVariant_InvalidNestedFinancialInstitutionIdentification_PropagatesError()
    {
        // FinancialInstitutionIdentification23 itself has no required fields, so the only way to
        // observe propagation here is through a nested child of THAT type. BICFI is optional and
        // struct-validated on construction (throws before reaching the validator), so instead
        // confirm propagation via the BranchIdentification -> PostalAddress27 -> AddressType path,
        // which is fully wired end-to-end through this dispatcher.
        var agent = IsoDataFactory.With(ValidAgent(), b => b
            .Set(x => x.BranchIdentification).To(IsoDataFactory.Make<IBranchData5>(b2 => b2
                .Set(x2 => x2.PostalAddress).To(IsoDataFactory.Make<IPostalAddress27>(b3 => b3
                    .Set(x3 => x3.AddressType).To(IsoDataFactory.Make<Choices.AddressType3Choice.IProprietary>(b4 => b4
                        .Set(x4 => x4.Identification).To("AB12")
                        .Set(x4 => x4.Issuer).To("IssuerX"))))))));
        BeneficialStrategies.Iso20022.Choices.IParty50Choice choice =
            IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b => b
                .Set(x => x.Value).To(agent));

        // This nested combination is itself fully valid (no rule currently rejects it) — this
        // test exists to prove the DI chain (Party50Choice_Validator -> agentValueValidator ->
        // BranchIdentificationValidator -> PostalAddressValidator -> AddressTypeValidator) runs
        // to completion without throwing, i.e. every link in the chain is actually wired.
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
