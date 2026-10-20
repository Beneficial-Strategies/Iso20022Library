// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInstruction51ValidatorTests
{
    private readonly PaymentInstruction51Validator _sut = new();

    private static ICreditTransferTransaction76 ValidCreditTransferTransaction() =>
        IsoDataFactory.Make<ICreditTransferTransaction76>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<IPaymentIdentification6>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m))));

    private static IPaymentInstruction51 ValidMessage() =>
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
            .Set(x => x.CreditTransferTransactionInformation).To([ValidCreditTransferTransaction()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EmptyCreditTransferTransactionInformation_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreditTransferTransactionInformation).To([]));
        var result = _sut.TestValidate(msg);
        result.ShouldHaveValidationErrorFor(x => x.CreditTransferTransactionInformation);
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var account = ValidMessage().DebtorAccount;
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RequestedAdviceType).To(IsoDataFactory.Make<IAdviceType1>())
            .Set(x => x.BatchBooking).To(true)
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.ControlSum).To(100.00m)
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation26>())
            .Set(x => x.PoolingAdjustmentDate).To(new DateOnly(2026, 1, 1))
            .Set(x => x.DebtorAgentAccount).To(account)
            .Set(x => x.InstructionForDebtorAgent).To("Contact debtor first")
            .Set(x => x.UltimateDebtor).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Ultimate Debtor Co")))
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor)
            .Set(x => x.ChargesAccount).To(account)
            .Set(x => x.ChargesAccountAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
