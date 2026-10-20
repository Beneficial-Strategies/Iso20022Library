// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction178ValidatorTests
{
    private readonly PaymentTransaction178Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentTransaction178>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction178>(b => b
            .Set(x => x.StatusIdentification).To("STS-001")
            .Set(x => x.OriginalInstructionIdentification).To("INSTR-001")
            .Set(x => x.OriginalEndToEndIdentification).To("E2E-001")
            .Set(x => x.OriginalUETR).To("3f2504e0-4f89-4c1a-a1a1-4f89c1a1a1a1")
            .Set(x => x.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation)
            .Set(x => x.StatusReasonInformation).To([IsoDataFactory.Make<IStatusReasonInformation14>()])
            .Set(x => x.ChargesInformation).To([
                IsoDataFactory.Make<ICharges16>(b2 => b2
                    .Set(x2 => x2.Agent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m })),
            ])
            .Set(x => x.TrackerData).To(IsoDataFactory.Make<ITrackerData7>(b2 => b2
                .Set(x2 => x2.ConfirmedAmount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m })
                .Set(x2 => x2.ConfirmedDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b3 => b3
                    .Set(x3 => x3.Value).To(new DateOnly(2026, 1, 1))))
                .Set(x2 => x2.TrackerRecord).To([
                    IsoDataFactory.Make<ITrackerRecord5>(b3 => b3
                        .Set(x3 => x3.Agent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b4 => b4
                            .Set(x4 => x4.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))),
                ])))
            .Set(x => x.AcceptanceDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.AccountServicerReference).To("ASR-001")
            .Set(x => x.ClearingSystemReference).To("CSR-001")
            .Set(x => x.OriginalTransactionReference).To(IsoDataFactory.Make<IOriginalTransactionReference47>())
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
