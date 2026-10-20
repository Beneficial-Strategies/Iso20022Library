// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerDirectDebitInitiationV12ValidatorTests
{
    private readonly CustomerDirectDebitInitiationV12Validator _sut = new();

    private static IGroupHeader118 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader118>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.InitiatingParty).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Initiator Co"))));

    private static IPaymentInstruction50 ValidPaymentInformation() =>
        IsoDataFactory.Make<IPaymentInstruction50>(b => b
            .Set(x => x.PaymentInformationIdentification).To("PMTINF-001")
            .Set(x => x.PaymentMethod).To(PaymentMethod2Code.DirectDebit)
            .Set(x => x.RequestedCollectionDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Creditor Co")))
            .Set(x => x.CreditorAccount).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000")))))
            .Set(x => x.CreditorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.DirectDebitTransactionInformation).To([
                IsoDataFactory.Make<IDirectDebitTransactionInformation34>(b2 => b2
                    .Set(x2 => x2.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification6>(b3 => b3
                        .Set(x3 => x3.EndToEndIdentification).To("E2E-001")))
                    .Set(x2 => x2.InstructedAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                    .Set(x2 => x2.DebtorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
                    .Set(x2 => x2.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                        .Set(x3 => x3.Name).To("Debtor Co")))
                    .Set(x2 => x2.DebtorAccount).To(IsoDataFactory.Make<ICashAccount40>(b3 => b3
                        .Set(x3 => x3.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b4 => b4
                            .Set(x4 => x4.Value).To("DE89370400440532013000")))))),
            ]));

    private static ICustomerDirectDebitInitiationV12 ValidMessage() =>
        IsoDataFactory.Make<ICustomerDirectDebitInitiationV12>(b => b
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
