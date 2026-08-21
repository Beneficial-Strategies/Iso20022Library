// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DirectDebitTransactionInformation34ValidatorTests
{
    private readonly DirectDebitTransactionInformation34Validator _sut = new();

    private static DirectDebitTransactionInformation34 ValidMessage() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification6 { EndToEndIdentification = "E2E-001" },
            InstructedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            DebtorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            Debtor = new PartyIdentification272 { Name = "Debtor Co" },
            DebtorAccount = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
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
        var msg = ValidMessage() with
        {
            PaymentTypeInformation = new PaymentTypeInformation29(),
            ChargeBearer = ChargeBearerType1Code.BorneByDebtor,
            DirectDebitTransaction = new DirectDebitTransaction12(),
            UltimateCreditor = new PartyIdentification272 { Name = "Ultimate Creditor Co" },
            DebtorAgentAccount = ValidMessage().DebtorAccount,
            UltimateDebtor = new PartyIdentification272 { Name = "Ultimate Debtor Co" },
            InstructionForCreditorAgent = "Please contact debtor",
            Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Proprietary { Value = "MYPURPOSE" },
            RegulatoryReporting =
            [
                new RegulatoryReporting10 { DebitCreditReportingIndicator = RegulatoryReportingType1Code.Debit },
            ],
            Tax = new TaxData1(),
            RelatedRemittanceInformation = [new RemittanceLocation8()],
            RemittanceInformation = new RemittanceInformation26(),
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
