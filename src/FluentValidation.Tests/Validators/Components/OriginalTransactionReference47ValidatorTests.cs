// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalTransactionReference47ValidatorTests
{
    private readonly OriginalTransactionReference47Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IOriginalTransactionReference47>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var account = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));
        var party = IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Some Party"))));
        var msg = IsoDataFactory.Make<IOriginalTransactionReference47>(b => b
            .Set(x => x.InterbankSettlementAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m)))
            .Set(x => x.InterbankSettlementDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.RequestedCollectionDate).To(new DateOnly(2026, 1, 2))
            .Set(x => x.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.CreditorSchemeIdentification).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Creditor Scheme Co")))
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction15>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod1Code.InstructedAgent)))
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation27>())
            .Set(x => x.PaymentMethod).To(PaymentMethod4Code.Cheque)
            .Set(x => x.MandateRelatedInformation).To(IsoDataFactory.Make<Choices.MandateRelatedData5Choice.IDirectDebitMandate>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<IMandateRelatedInformation16>())))
            .Set(x => x.RemittanceInformation).To(IsoDataFactory.Make<IRemittanceInformation26>())
            .Set(x => x.UltimateDebtor).To(party)
            .Set(x => x.Debtor).To(party)
            .Set(x => x.DebtorAccount).To(account)
            .Set(x => x.DebtorAgent).To(agent)
            .Set(x => x.DebtorAgentAccount).To(account)
            .Set(x => x.CreditorAgent).To(agent)
            .Set(x => x.CreditorAgentAccount).To(account)
            .Set(x => x.Creditor).To(party)
            .Set(x => x.CreditorAccount).To(account)
            .Set(x => x.UltimateCreditor).To(party)
            .Set(x => x.Purpose).To(IsoDataFactory.Make<Choices.Purpose2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYPURPOSE"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
