// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalTransactionReference47ValidatorTests
{
    private readonly OriginalTransactionReference47Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new OriginalTransactionReference47()).ShouldNotHaveAnyValidationErrors();
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
        var party = new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party
        {
            Value = new PartyIdentification272 { Name = "Some Party" },
        };
        var msg = new OriginalTransactionReference47
        {
            InterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
            {
                Currency = "USD",
                Amount = 100m,
            },
            InterbankSettlementDate = new DateOnly(2026, 1, 1),
            RequestedCollectionDate = new DateOnly(2026, 1, 2),
            RequestedExecutionDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
            CreditorSchemeIdentification = new PartyIdentification272 { Name = "Creditor Scheme Co" },
            SettlementInformation = new SettlementInstruction15 { SettlementMethod = SettlementMethod1Code.InstructedAgent },
            PaymentTypeInformation = new PaymentTypeInformation27(),
            PaymentMethod = PaymentMethod4Code.Cheque,
            MandateRelatedInformation = new BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice.DirectDebitMandate
            {
                Value = new MandateRelatedInformation16(),
            },
            RemittanceInformation = new RemittanceInformation26(),
            UltimateDebtor = party,
            Debtor = party,
            DebtorAccount = account,
            DebtorAgent = agent,
            DebtorAgentAccount = account,
            CreditorAgent = agent,
            CreditorAgentAccount = account,
            Creditor = party,
            CreditorAccount = account,
            UltimateCreditor = party,
            Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Proprietary { Value = "MYPURPOSE" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
