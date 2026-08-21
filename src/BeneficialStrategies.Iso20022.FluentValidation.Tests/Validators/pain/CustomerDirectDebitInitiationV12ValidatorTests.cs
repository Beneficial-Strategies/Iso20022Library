// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerDirectDebitInitiationV12ValidatorTests
{
    private readonly CustomerDirectDebitInitiationV12Validator _sut = new();

    private static GroupHeader118 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
            InitiatingParty = new PartyIdentification272 { Name = "Initiator Co" },
        };

    private static PaymentInstruction50 ValidPaymentInformation() =>
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
            DirectDebitTransactionInformation =
            [
                new DirectDebitTransactionInformation34
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
                },
            ],
        };

    private static CustomerDirectDebitInitiationV12 ValidMessage() =>
        new() { GroupHeader = ValidGroupHeader(), PaymentInformation = [ValidPaymentInformation()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyPaymentInformation_HasValidationError()
    {
        var msg = ValidMessage() with { PaymentInformation = [] };
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.PaymentInformation);
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
