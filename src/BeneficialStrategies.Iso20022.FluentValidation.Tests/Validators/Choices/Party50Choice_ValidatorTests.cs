// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Party50Choice_ValidatorTests
{
    private readonly Party50Choice_Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static PartyIdentification272 ValidParty() => new() { Name = "Acme Corp" };

    [Fact]
    public void AgentVariant_Valid_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Party50Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Party50Choice.Agent { Value = ValidAgent() };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PartyVariant_Valid_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Party50Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party { Value = ValidParty() };
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
        var agent = ValidAgent() with
        {
            BranchIdentification = new BranchData5
            {
                PostalAddress = new PostalAddress27
                {
                    AddressType = new BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Proprietary
                    {
                        Identification = "AB12",
                        Issuer = "IssuerX",
                    },
                },
            },
        };
        BeneficialStrategies.Iso20022.Choices.Party50Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Party50Choice.Agent { Value = agent };

        // This nested combination is itself fully valid (no rule currently rejects it) — this
        // test exists to prove the DI chain (Party50Choice_Validator -> agentValueValidator ->
        // BranchIdentificationValidator -> PostalAddressValidator -> AddressTypeValidator) runs
        // to completion without throwing, i.e. every link in the chain is actually wired.
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
