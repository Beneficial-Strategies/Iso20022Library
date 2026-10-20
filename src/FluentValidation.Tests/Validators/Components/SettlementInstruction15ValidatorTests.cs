// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SettlementInstruction15ValidatorTests
{
    private readonly SettlementInstruction15Validator _sut = new();

    private static SettlementInstruction15 ValidMessage() =>
        new() { SettlementMethod = SettlementMethod1Code.InstructedAgent };

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
        var account = new CashAccount40
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };
        var msg = ValidMessage() with
        {
            ClearingSystem = new BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification3Choice.Proprietary
            {
                Value = "MYSYS",
            },
            InstructedReimbursementAgent = agent,
            InstructedReimbursementAgentAccount = account,
            InstructingReimbursementAgent = agent,
            InstructingReimbursementAgentAccount = account,
            SettlementAccount = account,
            ThirdReimbursementAgent = agent,
            ThirdReimbursementAgentAccount = account,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
