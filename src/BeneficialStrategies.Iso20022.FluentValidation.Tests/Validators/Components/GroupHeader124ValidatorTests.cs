// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader124ValidatorTests
{
    private readonly GroupHeader124Validator _sut = new();

    private static GroupHeader124 ValidMessage() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
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
            Authorisation =
            [
                new BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Proprietary { Value = "AUTH1" },
            ],
            ControlSum = 100.00m,
            CreditorAgent = agent,
            DebtorAgent = agent,
            ForwardingAgent = agent,
            GroupReversal = true,
            InitiatingParty = new PartyIdentification272 { Name = "Initiator Co" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
