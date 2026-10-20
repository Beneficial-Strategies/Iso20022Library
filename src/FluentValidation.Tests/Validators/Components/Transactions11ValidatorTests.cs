// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Transactions11ValidatorTests
{
    private readonly Transactions11Validator _sut = new();

    private static ITransactionReport8 MinimalReport(
        DateOnly? requestedExecutionDate = null,
        Codesets.CreditDebitCode? creditDebitIndicator = null
    ) =>
        IsoDataFactory.Make<ITransactionReport8>(b => b
            .Set(x => x.PaymentIdentification).To(IsoDataFactory.Make<Choices.PaymentIdentification8Choice.ITransactionIdentification>(b2 => b2
                .Set(x2 => x2.Value).To("TXN-001")))
            .Set(x => x.TransactionOrError).To(IsoDataFactory.Make<Choices.TransactionOrError6Choice.ITransaction>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<ITransaction159>(b3 => b3
                    .Set(x3 => x3.CreditDebitIndicator).To(creditDebitIndicator)
                    .Set(x3 => x3.Payment).To(requestedExecutionDate is null
                            ? null
                            : IsoDataFactory.Make<IPaymentInstruction47>(b4 => b4
                                .Set(x4 => x4.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b5 => b5
                                    .Set(x5 => x5.Value).To(requestedExecutionDate.Value))))))))));

    private static ITransactions11 ValidMessage() => IsoDataFactory.Make<ITransactions11>(b => b
        .Set(x => x.TransactionReport).To([MinimalReport()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── TransactionReport: TransactionReport8, 1..∞ ───────────────────────────

    [Fact]
    public void TransactionReport_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TransactionReport).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.TransactionReport);
    }

    // ── TransferValueDateRule ─────────────────────────────────────────────────

    [Fact]
    public void CommonRequestedExecutionDateAndReportRequestedExecutionDate_Violates_TransferValueDateRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentCommonInformation).To(IsoDataFactory.Make<IPaymentCommon6>(b2 => b2
                .Set(x2 => x2.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b3 => b3
                    .Set(x3 => x3.Value).To(new DateOnly(2026, 1, 1))))))
            .Set(x => x.TransactionReport).To([MinimalReport(requestedExecutionDate: new DateOnly(2026, 1, 1))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TransferValueDateRule");
    }

    [Fact]
    public void CommonRequestedExecutionDateOnly_DoesNotViolate_TransferValueDateRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentCommonInformation).To(IsoDataFactory.Make<IPaymentCommon6>(b2 => b2
                .Set(x2 => x2.RequestedExecutionDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b3 => b3
                    .Set(x3 => x3.Value).To(new DateOnly(2026, 1, 1)))))));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TransferValueDateRule");
    }

    // ── CreditDebitIndicator1Rule ─────────────────────────────────────────────

    [Fact]
    public void CommonCreditDebitIndicatorAndReportCreditDebitIndicator_Violates_CreditDebitIndicator1Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentCommonInformation).To(IsoDataFactory.Make<IPaymentCommon6>(b2 => b2
                .Set(x2 => x2.CreditDebitIndicator).To(Codesets.CreditDebitCode.Credit)))
            .Set(x => x.TransactionReport).To([MinimalReport(creditDebitIndicator: Codesets.CreditDebitCode.Credit)]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CreditDebitIndicator1Rule");
    }

    [Fact]
    public void CommonCreditDebitIndicatorOnly_DoesNotViolate_CreditDebitIndicator1Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentCommonInformation).To(IsoDataFactory.Make<IPaymentCommon6>(b2 => b2
                .Set(x2 => x2.CreditDebitIndicator).To(Codesets.CreditDebitCode.Credit))));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "CreditDebitIndicator1Rule");
    }
}
