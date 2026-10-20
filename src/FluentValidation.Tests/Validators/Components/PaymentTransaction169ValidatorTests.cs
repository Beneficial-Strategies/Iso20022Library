// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction169ValidatorTests
{
    private readonly PaymentTransaction169Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentTransaction169>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentTransaction169>(b => b
            .Set(x => x.StatusIdentification).To("STS-001")
            .Set(x => x.OriginalInstructionIdentification).To("INSTR-001")
            .Set(x => x.OriginalEndToEndIdentification).To("E2E-001")
            .Set(x => x.OriginalUETR).To("3f2504e0-4f89-4c1a-a1a1-4f89c1a1a1a1")
            .Set(x => x.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation)
            .Set(x => x.StatusReasonInformation).To([IsoDataFactory.Make<IStatusReasonInformation14>()])
            .Set(x => x.PaymentConditionStatus).To(IsoDataFactory.Make<IPaymentConditionStatus2>())
            .Set(x => x.ChargesInformation).To([
                IsoDataFactory.Make<ICharges16>(b2 => b2
                    .Set(x2 => x2.Agent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
                    .Set(x2 => x2.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m })),
            ])
            .Set(x => x.DebtorDecisionDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.AcceptanceDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.AccountServicerReference).To("ASR-001")
            .Set(x => x.ClearingSystemReference).To("CSR-001")
            .Set(x => x.OriginalTransactionReference).To(IsoDataFactory.Make<IOriginalTransactionReference46>(b2 => b2
                .Set(x2 => x2.CreditorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                    .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
                .Set(x2 => x2.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                    .Set(x3 => x3.Name).To("Creditor Co")))))
            .Set(x => x.EnclosedFile).To([
                IsoDataFactory.Make<IDocument15>(b2 => b2
                    .Set(x2 => x2.Enclosure).To(Convert.ToBase64String([1, 2, 3]))
                    .Set(x2 => x2.Identification).To("DOC-001")
                    .Set(x2 => x2.Format).To(IsoDataFactory.Make<Choices.DocumentFormat1Choice.ICode>(b3 => b3
                        .Set(x3 => x3.Value).To(ExternalDocumentFormat1Code.PDF)))
                    .Set(x2 => x2.IssueDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b3 => b3
                        .Set(x3 => x3.Value).To(new DateOnly(2026, 1, 1))))
                    .Set(x2 => x2.Type).To(IsoDataFactory.Make<Choices.DocumentType1Choice.ICode>(b3 => b3
                        .Set(x3 => x3.Value).To(ExternalDocumentType1Code.CommercialInvoice)))),
            ])
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
