// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader111ValidatorTests
{
    private readonly GroupHeader111Validator _sut = new();

    private static GroupHeader111 ValidMessage() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            InitiatingParty = new PartyIdentification272 { Name = "Initiator Co" },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
        };
        var msg = ValidMessage() with
        {
            CreditorAgent = agent,
            DebtorAgent = agent,
            ForwardingAgent = agent,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
