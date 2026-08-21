// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader128ValidatorTests
{
    private readonly GroupHeader128Validator _sut = new();

    private static GroupHeader128 ValidMessage() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

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
            InitiatingParty = new PartyIdentification272 { Name = "Initiator Co" },
            ForwardingAgent = agent,
            DebtorAgent = agent,
            CreditorAgent = agent,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
