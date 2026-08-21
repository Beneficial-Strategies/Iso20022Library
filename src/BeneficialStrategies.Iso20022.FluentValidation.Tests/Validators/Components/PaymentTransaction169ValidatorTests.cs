// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction169ValidatorTests
{
    private readonly PaymentTransaction169Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentTransaction169()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new PaymentTransaction169
        {
            StatusIdentification = "STS-001",
            OriginalInstructionIdentification = "INSTR-001",
            OriginalEndToEndIdentification = "E2E-001",
            OriginalUETR = "3f2504e0-4f89-4c1a-a1a1-4f89c1a1a1a1",
            TransactionStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
            StatusReasonInformation = [new StatusReasonInformation14()],
            PaymentConditionStatus = new PaymentConditionStatus2(),
            ChargesInformation =
            [
                new Charges16
                {
                    Agent = new BranchAndFinancialInstitutionIdentification8
                    {
                        FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
                    },
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m },
                },
            ],
            DebtorDecisionDateTime = new DateTime(2026, 1, 1),
            AcceptanceDateTime = new DateTime(2026, 1, 1),
            AccountServicerReference = "ASR-001",
            ClearingSystemReference = "CSR-001",
            OriginalTransactionReference = new OriginalTransactionReference46
            {
                CreditorAgent = new BranchAndFinancialInstitutionIdentification8
                {
                    FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
                },
                Creditor = new PartyIdentification272 { Name = "Creditor Co" },
            },
            EnclosedFile =
            [
                new Document15
                {
                    Enclosure = Convert.ToBase64String([1, 2, 3]),
                    Identification = "DOC-001",
                    Format = new BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice.Code
                    {
                        Value = ExternalDocumentFormat1Code.PDF,
                    },
                    IssueDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
                    {
                        Value = new DateOnly(2026, 1, 1),
                    },
                    Type = new BeneficialStrategies.Iso20022.Choices.DocumentType1Choice.Code
                    {
                        Value = ExternalDocumentType1Code.CommercialInvoice,
                    },
                },
            ],
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
