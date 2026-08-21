// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction178ValidatorTests
{
    private readonly PaymentTransaction178Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentTransaction178()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new PaymentTransaction178
        {
            StatusIdentification = "STS-001",
            OriginalInstructionIdentification = "INSTR-001",
            OriginalEndToEndIdentification = "E2E-001",
            OriginalUETR = "3f2504e0-4f89-4c1a-a1a1-4f89c1a1a1a1",
            TransactionStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
            StatusReasonInformation = [new StatusReasonInformation14()],
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
            TrackerData = new TrackerData7
            {
                ConfirmedAmount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
                ConfirmedDate = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
                {
                    Value = new DateOnly(2026, 1, 1),
                },
                TrackerRecord =
                [
                    new TrackerRecord5
                    {
                        Agent = new BranchAndFinancialInstitutionIdentification8
                        {
                            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
                        },
                    },
                ],
            },
            AcceptanceDateTime = new DateTime(2026, 1, 1),
            AccountServicerReference = "ASR-001",
            ClearingSystemReference = "CSR-001",
            OriginalTransactionReference = new OriginalTransactionReference47(),
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
