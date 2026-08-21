// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction76ValidatorTests
{
    private readonly CreditTransferTransaction76Validator _sut = new();

    private static CreditTransferTransaction76 ValidMessage() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification6 { EndToEndIdentification = "E2E-001" },
            Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
            {
                Currency = "USD",
                Amount = 100m,
            },
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
        var account = new CashAccount40
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };
        var party = new PartyIdentification272 { Name = "Some Party" };
        var msg = ValidMessage() with
        {
            PaymentTypeInformation = new PaymentTypeInformation28(),
            ChargeBearer = ChargeBearerType1Code.BorneByDebtor,
            PreviousInstructingAgent1 = agent,
            PreviousInstructingAgent1Account = account,
            PreviousInstructingAgent2 = agent,
            PreviousInstructingAgent2Account = account,
            PreviousInstructingAgent3 = agent,
            PreviousInstructingAgent3Account = account,
            IntermediaryAgent1 = agent,
            IntermediaryAgent1Account = account,
            IntermediaryAgent2 = agent,
            IntermediaryAgent2Account = account,
            IntermediaryAgent3 = agent,
            IntermediaryAgent3Account = account,
            CreditorAgent = agent,
            CreditorAgentAccount = account,
            Creditor = party,
            CreditorAccount = account,
            UltimateCreditor = party,
            InstructionForDebtorAgent = new InstructionForDebtorAgent1(),
            InstructionForCreditorAgent = [new InstructionForCreditorAgent3()],
            RegulatoryReporting =
            [
                new RegulatoryReporting10 { DebitCreditReportingIndicator = RegulatoryReportingType1Code.Debit },
            ],
            RelatedRemittanceInformation = [new RemittanceLocation8()],
            RemittanceInformation = new RemittanceInformation22(),
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
