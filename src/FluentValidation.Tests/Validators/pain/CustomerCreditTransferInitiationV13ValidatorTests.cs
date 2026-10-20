// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerCreditTransferInitiationV13ValidatorTests
{
    private readonly CustomerCreditTransferInitiationV13Validator _sut = new();

    private static GroupHeader114 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
            InitiatingParty = new PartyIdentification272 { Name = "Initiator Co" },
        };

    private static PaymentInstruction51 ValidPaymentInformation() =>
        new()
        {
            PaymentInformationIdentification = "PMTINF-001",
            PaymentMethod = PaymentMethod3Code.CreditTransfer,
            RequestedExecutionDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
            Debtor = new PartyIdentification272 { Name = "Debtor Co" },
            DebtorAccount = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
            DebtorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            CreditTransferTransactionInformation =
            [
                new CreditTransferTransaction76
                {
                    PaymentIdentification = new PaymentIdentification6 { EndToEndIdentification = "E2E-001" },
                    Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
                    {
                        Currency = "USD",
                        Amount = 100m,
                    },
                },
            ],
        };

    private static CustomerCreditTransferInitiationV13 ValidMessage() =>
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
