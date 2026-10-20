// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction74ValidatorTests
{
    private readonly CreditTransferTransaction74Validator _sut = new();

    private static ICreditTransferTransaction74 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction74>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification6>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m)))
            .Set(x => x.CreditorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Creditor Co"))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var account = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));

        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation29>())
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor)
            .Set(x => x.PaymentCondition).To(IsoDataFactory.Make<IPaymentCondition2>())
            .Set(x => x.MandateRelatedInformation).To(IsoDataFactory.Make<ICreditTransferMandateData1>())
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Debtor Co")))
            .Set(x => x.IntermediaryAgent1).To(agent)
            .Set(x => x.IntermediaryAgent2).To(agent)
            .Set(x => x.IntermediaryAgent3).To(agent)
            .Set(x => x.CreditorAgentAccount).To(account)
            .Set(x => x.CreditorAccount).To(account)
            .Set(x => x.UltimateCreditor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Creditor Co")))
            .Set(x => x.InstructionForCreditorAgent).To([IsoDataFactory.Make<IInstructionForCreditorAgent3>()])
            .Set(x => x.RegulatoryReporting).To([
                IsoDataFactory.Make<IRegulatoryReporting10>(b2 => b2
                    .Set(x2 => x2.DebitCreditReportingIndicator).To(RegulatoryReportingType1Code.Debit)),
            ])
            .Set(x => x.RelatedRemittanceInformation).To([IsoDataFactory.Make<IRemittanceLocation8>()])
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
