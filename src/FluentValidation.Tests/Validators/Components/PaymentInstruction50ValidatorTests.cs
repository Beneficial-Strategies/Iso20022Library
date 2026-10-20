// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInstruction50ValidatorTests
{
    private readonly PaymentInstruction50Validator _sut = new();

    private static DirectDebitTransactionInformation34 ValidDirectDebitTransactionInformation() =>
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

    private static PaymentInstruction50 ValidMessage() =>
        new()
        {
            PaymentInformationIdentification = "PMTINF-001",
            PaymentMethod = PaymentMethod2Code.DirectDebit,
            RequestedCollectionDate = new DateOnly(2026, 1, 1),
            Creditor = new PartyIdentification272 { Name = "Creditor Co" },
            CreditorAccount = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
            CreditorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            DirectDebitTransactionInformation = [ValidDirectDebitTransactionInformation()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyDirectDebitTransactionInformation_HasValidationError()
    {
        var msg = ValidMessage() with { DirectDebitTransactionInformation = [] };
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.DirectDebitTransactionInformation);
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var account = ValidMessage().CreditorAccount;
        var msg = ValidMessage() with
        {
            RequestedAdviceType = new AdviceType1(),
            BatchBooking = true,
            NumberOfTransactions = "1",
            ControlSum = 100.00m,
            PaymentTypeInformation = new PaymentTypeInformation29(),
            CreditorAgentAccount = account,
            UltimateCreditor = new PartyIdentification272 { Name = "Ultimate Creditor Co" },
            ChargeBearer = ChargeBearerType1Code.BorneByDebtor,
            ChargesAccount = account,
            ChargesAccountAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            CreditorSchemeIdentification = new PartyIdentification272 { Name = "Creditor Scheme Co" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
