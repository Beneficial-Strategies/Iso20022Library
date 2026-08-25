// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TransactionParties11ValidatorTests
{
    private readonly TransactionParties11Validator _sut = new();

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent(string bic) =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = bic } };

    private static BeneficialStrategies.Iso20022.Choices.Party50Choice_ ValidParty() =>
        new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party { Value = new PartyIdentification272() };

    private static CashAccount40 ValidAccount(string id = "ACC-001") =>
        new() { Identification = new Choices.AccountIdentification4Choice.Other { Identification = id } };

    private static TransactionParties11 ValidMessage() => new() { Creditor = ValidParty(), Debtor = ValidParty() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorAccountAndDebtorAccount_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { CreditorAccount = ValidAccount(), DebtorAccount = ValidAccount() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditorAgentAndDebtorAgent_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { CreditorAgent = ValidAgent("CHASUS33XXX"), DebtorAgent = ValidAgent("DEUTDEFFXXX") };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InitiatingPartyAndUltimateParties_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            InitiatingParty = ValidParty(),
            UltimateCreditor = ValidParty(),
            UltimateDebtor = ValidParty(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Theory]
    [InlineData("IntermediaryAgent1")]
    [InlineData("IntermediaryAgent2")]
    [InlineData("IntermediaryAgent3")]
    [InlineData("PreviousInstructingAgent1")]
    [InlineData("PreviousInstructingAgent2")]
    [InlineData("PreviousInstructingAgent3")]
    public void OptionalAgentFields_Present_NoValidationErrors(string fieldName)
    {
        var msg = fieldName switch
        {
            "IntermediaryAgent1" => ValidMessage() with { IntermediaryAgent1 = ValidAgent("BOFAUS3NXXX"), IntermediaryAgent1Account = ValidAccount() },
            "IntermediaryAgent2" => ValidMessage() with { IntermediaryAgent2 = ValidAgent("BOFAUS3NXXX"), IntermediaryAgent2Account = ValidAccount() },
            "IntermediaryAgent3" => ValidMessage() with { IntermediaryAgent3 = ValidAgent("BOFAUS3NXXX"), IntermediaryAgent3Account = ValidAccount() },
            "PreviousInstructingAgent1" => ValidMessage() with { PreviousInstructingAgent1 = ValidAgent("BOFAUS3NXXX"), PreviousInstructingAgent1Account = ValidAccount() },
            "PreviousInstructingAgent2" => ValidMessage() with { PreviousInstructingAgent2 = ValidAgent("BOFAUS3NXXX"), PreviousInstructingAgent2Account = ValidAccount() },
            "PreviousInstructingAgent3" => ValidMessage() with { PreviousInstructingAgent3 = ValidAgent("BOFAUS3NXXX"), PreviousInstructingAgent3Account = ValidAccount() },
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DebtorAgentAccountAndCreditorAgentAccount_Present_NoValidationErrors()
    {
        var msg = ValidMessage() with { DebtorAgentAccount = ValidAccount(), CreditorAgentAccount = ValidAccount() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
