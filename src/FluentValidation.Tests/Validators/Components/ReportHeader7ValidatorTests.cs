// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ReportHeader7ValidatorTests
{
    private readonly ReportHeader7Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.Party50Choice_ ValidParty() =>
        new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party
        {
            Value = new PartyIdentification272 { Name = "Acme Corp" },
        };

    private static ReportHeader7 ValidMessage() =>
        new()
        {
            CreationDateTime = new DateTime(2026, 1, 1),
            From = ValidParty(),
            Identification = "RPT-001",
            To = ValidParty(),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void FromAndTo_AsAgentVariant_NoValidationError()
    {
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
        };
        var msg = ValidMessage() with
        {
            From = new BeneficialStrategies.Iso20022.Choices.Party50Choice.Agent { Value = agent },
            To = new BeneficialStrategies.Iso20022.Choices.Party50Choice.Agent { Value = agent },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
