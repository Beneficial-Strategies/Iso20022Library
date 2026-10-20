// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class LiquidityDebitTransfer4ValidatorTests
{
    private readonly LiquidityDebitTransfer4Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IAmount2Choice ValidAmount() =>
        IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b => b
            .Set(x => x.Currency).To("USD")
            .Set(x => x.Amount).To(100m));

    private static ILiquidityDebitTransfer4 ValidMessage() => IsoDataFactory.Make<ILiquidityDebitTransfer4>(b => b
        .Set(x => x.TransferredAmount).To(ValidAmount()));

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
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Creditor).To(agent)
            .Set(x => x.CreditorAccount).To(account)
            .Set(x => x.Debtor).To(agent)
            .Set(x => x.DebtorAccount).To(account)
            .Set(x => x.LiquidityTransferIdentification).To(IsoDataFactory.Make<IPaymentIdentification8>(b2 => b2
                .Set(x2 => x2.EndToEndIdentification).To("E2E-001")))
            .Set(x => x.SettlementDate).To(new DateOnly(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
