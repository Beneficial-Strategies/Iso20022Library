// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CreditorPaymentActivationRequestV12ValidatorTests
{
    private readonly CreditorPaymentActivationRequestV12Validator _sut = new();

    private static GroupHeader112 ValidGroupHeader() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
            InitiatingParty = new PartyIdentification272 { Name = "Initiator Co" },
        };

    private static PaymentInstruction48 ValidPaymentInformation() =>
        new()
        {
            PaymentMethod = PaymentMethod7Code.Cheque,
            Debtor = new PartyIdentification272 { Name = "Debtor Co" },
            DebtorAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            CreditTransferTransaction =
            [
                new CreditTransferTransaction74
                {
                    PaymentIdentification = new PaymentIdentification6 { EndToEndIdentification = "E2E-001" },
                    Amount = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
                    {
                        Currency = "USD",
                        Amount = 100m,
                    },
                    CreditorAgent = new BranchAndFinancialInstitutionIdentification8
                    {
                        FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
                    },
                    Creditor = new PartyIdentification272 { Name = "Creditor Co" },
                },
            ],
        };

    private static CreditorPaymentActivationRequestV12 ValidMessage() =>
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
