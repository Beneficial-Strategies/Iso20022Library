// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DirectDebitTransactionInformation34ValidatorTests
{
    private readonly DirectDebitTransactionInformation34Validator _sut = new();

    private static IDirectDebitTransactionInformation34 ValidMessage() =>
        IsoDataFactory.Make<IDirectDebitTransactionInformation34>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification6>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.InstructedAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.DebtorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Debtor Co")))
            .Set(x => x.DebtorAccount).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000"))))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation29>())
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor)
            .Set(x => x.DirectDebitTransaction).To(IsoDataFactory.Make<IDirectDebitTransaction12>())
            .Set(x => x.UltimateCreditor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Creditor Co")))
            .Set(x => x.DebtorAgentAccount).To(ValidMessage().DebtorAccount)
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Debtor Co")))
            .Set(x => x.InstructionForCreditorAgent).To("Please contact debtor")
            .Set(x => x.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYPURPOSE")))
            .Set(x => x.RegulatoryReporting).To([
                IsoDataFactory.Make<IRegulatoryReporting10>(b2 => b2
                    .Set(x2 => x2.DebitCreditReportingIndicator).To(RegulatoryReportingType1Code.Debit)),
            ])
            .Set(x => x.Tax).To(IsoDataFactory.Make<ITaxData1>())
            .Set(x => x.RelatedRemittanceInformation).To([IsoDataFactory.Make<IRemittanceLocation8>()])
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation26>())
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
