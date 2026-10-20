// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditTransferTransaction76ValidatorTests
{
    private readonly CreditTransferTransaction76Validator _sut = new();

    private static ICreditTransferTransaction76 ValidMessage() =>
        IsoDataFactory.Make<ICreditTransferTransaction76>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification6>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m))));

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
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation26>())
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor)
            .Set(x => x.ExchangeRateInformation).To(IsoDataFactory.Make<IExchangeRate1>())
            .Set(x => x.MandateRelatedInformation).To(IsoDataFactory.Make<ICreditTransferMandateData1>())
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Debtor Co")))
            .Set(x => x.IntermediaryAgent1).To(agent)
            .Set(x => x.IntermediaryAgent1Account).To(account)
            .Set(x => x.IntermediaryAgent2).To(agent)
            .Set(x => x.IntermediaryAgent2Account).To(account)
            .Set(x => x.IntermediaryAgent3).To(agent)
            .Set(x => x.IntermediaryAgent3Account).To(account)
            .Set(x => x.CreditorAgent).To(agent)
            .Set(x => x.CreditorAgentAccount).To(account)
            .Set(x => x.Creditor).To(party)
            .Set(x => x.CreditorAccount).To(account)
            .Set(x => x.UltimateCreditor).To(party)
            .Set(x => x.InstructionForDebtorAgent).To(IsoDataFactory.Make<IInstructionForDebtorAgent1>())
            .Set(x => x.InstructionForCreditorAgent).To([IsoDataFactory.Make<IInstructionForCreditorAgent3>()])
            .Set(x => x.RegulatoryReporting).To([
                IsoDataFactory.Make<IRegulatoryReporting10>(b2 => b2
                    .Set(x2 => x2.DebitCreditReportingIndicator).To(RegulatoryReportingType1Code.Debit)),
            ])
            .Set(x => x.RelatedRemittanceInformation).To([IsoDataFactory.Make<IRemittanceLocation8>()])
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation26>())
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
