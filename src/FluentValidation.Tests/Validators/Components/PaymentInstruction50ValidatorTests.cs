// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInstruction50ValidatorTests
{
    private readonly PaymentInstruction50Validator _sut = new();

    private static IDirectDebitTransactionInformation34 ValidDirectDebitTransactionInformation() =>
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

    private static IPaymentInstruction50 ValidMessage() =>
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
            .Set(x => x.DirectDebitTransactionInformation).To([ValidDirectDebitTransactionInformation()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyDirectDebitTransactionInformation_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.DirectDebitTransactionInformation).To([]));
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.DirectDebitTransactionInformation);
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var account = ValidMessage().CreditorAccount;
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RequestedAdviceType).To(IsoDataFactory.Make<IAdviceType1>())
            .Set(x => x.BatchBooking).To(true)
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.ControlSum).To(100.00m)
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation29>())
            .Set(x => x.CreditorAgentAccount).To(account)
            .Set(x => x.UltimateCreditor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Creditor Co")))
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor)
            .Set(x => x.ChargesAccount).To(account)
            .Set(x => x.ChargesAccountAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.CreditorSchemeIdentification).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Creditor Scheme Co"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
