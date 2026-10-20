// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalTransactionReference46ValidatorTests
{
    private readonly OriginalTransactionReference46Validator _sut = new();

    private static IOriginalTransactionReference46 ValidMessage() =>
        IsoDataFactory.Make<IOriginalTransactionReference46>(b => b
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
        var party = IsoDataFactory.Make<IPartyIdentification272>(b => b
            .Set(x => x.Name).To("Some Party"));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m)))
            .Set(x => x.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.ExpiryDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 2, 1))))
            .Set(x => x.PaymentCondition).To(IsoDataFactory.Make<IPaymentCondition2>())
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation29>())
            .Set(x => x.PaymentMethod).To(PaymentMethod4Code.Cheque)
            .Set(x => x.MandateRelatedInformation).To(IsoDataFactory.Make<ICreditTransferMandateData1>())
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation26>())
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
            .Set(x => x.UltimateDebtor).To(party)
            .Set(x => x.Debtor).To(party)
            .Set(x => x.DebtorAccount).To(account)
            .Set(x => x.DebtorAgent).To(agent)
            .Set(x => x.DebtorAgentAccount).To(account)
            .Set(x => x.CreditorAgentAccount).To(account)
            .Set(x => x.CreditorAccount).To(account)
            .Set(x => x.UltimateCreditor).To(party));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
