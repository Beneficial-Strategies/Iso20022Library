// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerCreditTransferInitiationV13ValidatorTests
{
    private readonly CustomerCreditTransferInitiationV13Validator _sut = new();

    private static IGroupHeader114 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader114>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Initiator Co"))));

    private static IPaymentInstruction51 ValidPaymentInformation() =>
        IsoDataFactory.Make<IPaymentInstruction51>(b => b
            .Set(x => x.PaymentInformationIdentification).To("PMTINF-001")
            .Set(x => x.PaymentMethod).To(PaymentMethod3Code.CreditTransfer)
            .Set(x => x.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Debtor Co")))
            .Set(x => x.DebtorAccount).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000")))))
            .Set(x => x.DebtorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.CreditTransferTransactionInformation).To([
                IsoDataFactory.Make<ICreditTransferTransaction76>(b2 => b2
                    .Set(x2 => x2.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification6>(b3 => b3
                        .Set(x3 => x3.EndToEndIdentification).To("E2E-001")))
                    .Set(x2 => x2.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b3 => b3
                        .Set(x3 => x3.Currency).To("USD")
                        .Set(x3 => x3.Amount).To(100m)))),
            ]));

    private static ICustomerCreditTransferInitiationV13 ValidMessage() =>
        IsoDataFactory.Make<ICustomerCreditTransferInitiationV13>(b => b
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
