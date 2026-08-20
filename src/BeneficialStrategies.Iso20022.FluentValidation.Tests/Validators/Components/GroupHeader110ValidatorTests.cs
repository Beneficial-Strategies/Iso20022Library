// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader110ValidatorTests
{
    private readonly GroupHeader110Validator _sut = new();

    private static GroupHeader110 ValidMessage() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
        };
        var msg = ValidMessage() with
        {
            Authorisation =
            [
                new BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Proprietary
                {
                    Value = "LEVEL2",
                },
            ],
            InitiatingParty = new PartyIdentification272 { Name = "Acme Corp" },
            InstructingAgent = agent,
            InstructedAgent = agent,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
