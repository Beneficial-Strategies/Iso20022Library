// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInstruction48ValidatorTests
{
    private readonly PaymentInstruction48Validator _sut = new();

    private static ICreditTransferTransaction74 ValidCreditTransferTransaction() =>
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

    private static IPaymentInstruction48 ValidMessage() =>
        IsoDataFactory.Make<IPaymentInstruction48>(b => b
            .Set(x => x.PaymentMethod).To(PaymentMethod7Code.Cheque)
            .Set(x => x.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Debtor Co")))
            .Set(x => x.DebtorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.CreditTransferTransaction).To([ValidCreditTransferTransaction()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyCreditTransferTransaction_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditTransferTransaction).To([]));
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.CreditTransferTransaction);
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var account = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentInformationIdentification).To("PMTINF-001")
            .Set(x => x.RequestedAdviceType).To(IsoDataFactory.Make<IAdviceType1>())
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation29>())
            .Set(x => x.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.ExpiryDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 2, 1))))
            .Set(x => x.PaymentCondition).To(IsoDataFactory.Make<IPaymentCondition2>())
            .Set(x => x.DebtorAccount).To(account)
            .Set(x => x.DebtorAgentAccount).To(account)
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Debtor Co")))
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
