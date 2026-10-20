// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CreditorPaymentActivationRequestV12ValidatorTests
{
    private readonly CreditorPaymentActivationRequestV12Validator _sut = new();

    private static IGroupHeader112 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader112>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Initiator Co"))));

    private static IPaymentInstruction48 ValidPaymentInformation() =>
        IsoDataFactory.Make<IPaymentInstruction48>(b => b
            .Set(x => x.PaymentMethod).To(PaymentMethod7Code.Cheque)
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Debtor Co")))
            .Set(x => x.DebtorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.CreditTransferTransaction).To([
                IsoDataFactory.Make<ICreditTransferTransaction74>(b2 => b2
                    .Set(x2 => x2.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification6>(b3 => b3
                        .Set(x3 => x3.EndToEndIdentification).To("E2E-001")))
                    .Set(x2 => x2.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b3 => b3
                        .Set(x3 => x3.Currency).To("USD")
                        .Set(x3 => x3.Amount).To(100m)))
                    .Set(x2 => x2.CreditorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
                    .Set(x2 => x2.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                        .Set(x3 => x3.Name).To("Creditor Co")))),
            ]));

    private static ICreditorPaymentActivationRequestV12 ValidMessage() =>
        IsoDataFactory.Make<ICreditorPaymentActivationRequestV12>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.PaymentInformation).To([ValidPaymentInformation()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyPaymentInformation_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentInformation).To([]));
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.PaymentInformation);
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
