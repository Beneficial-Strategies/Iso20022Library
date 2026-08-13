// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Transactions11ValidatorTests
{
    private readonly Transactions11Validator _sut = new();

    private static TransactionReport8 MinimalReport(
        DateOnly? requestedExecutionDate = null,
        Codesets.CreditDebitCode? creditDebitIndicator = null
    ) =>
        new()
        {
            PaymentIdentification = new Choices.PaymentIdentification8Choice.TransactionIdentification
            {
                Value = "TXN-001",
            },
            TransactionOrError = new Choices.TransactionOrError6Choice.Transaction
            {
                Value = new Transaction159
                {
                    CreditDebitIndicator = creditDebitIndicator,
                    Payment =
                        requestedExecutionDate is null
                            ? null
                            : new PaymentInstruction47
                            {
                                RequestedExecutionDate = new Choices.DateAndDateTime2Choice.Date
                                {
                                    Value = requestedExecutionDate.Value,
                                },
                            },
                },
            },
        };

    private static Transactions11 ValidMessage() => new() { TransactionReport = [MinimalReport()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── TransactionReport: TransactionReport8, 1..∞ ───────────────────────────

    [Fact]
    public void TransactionReport_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { TransactionReport = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.TransactionReport);
    }

    // ── TransferValueDateRule ─────────────────────────────────────────────────

    [Fact]
    public void CommonRequestedExecutionDateAndReportRequestedExecutionDate_Violates_TransferValueDateRule()
    {
        var msg = ValidMessage() with
        {
            PaymentCommonInformation = new PaymentCommon6
            {
                RequestedExecutionDate = new Choices.DateAndDateTime2Choice.Date
                {
                    Value = new DateOnly(2026, 1, 1),
                },
            },
            TransactionReport = [MinimalReport(requestedExecutionDate: new DateOnly(2026, 1, 1))],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TransferValueDateRule");
    }

    [Fact]
    public void CommonRequestedExecutionDateOnly_DoesNotViolate_TransferValueDateRule()
    {
        var msg = ValidMessage() with
        {
            PaymentCommonInformation = new PaymentCommon6
            {
                RequestedExecutionDate = new Choices.DateAndDateTime2Choice.Date
                {
                    Value = new DateOnly(2026, 1, 1),
                },
            },
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TransferValueDateRule");
    }

    // ── CreditDebitIndicator1Rule ─────────────────────────────────────────────

    [Fact]
    public void CommonCreditDebitIndicatorAndReportCreditDebitIndicator_Violates_CreditDebitIndicator1Rule()
    {
        var msg = ValidMessage() with
        {
            PaymentCommonInformation = new PaymentCommon6 { CreditDebitIndicator = Codesets.CreditDebitCode.Credit },
            TransactionReport = [MinimalReport(creditDebitIndicator: Codesets.CreditDebitCode.Credit)],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CreditDebitIndicator1Rule");
    }

    [Fact]
    public void CommonCreditDebitIndicatorOnly_DoesNotViolate_CreditDebitIndicator1Rule()
    {
        var msg = ValidMessage() with
        {
            PaymentCommonInformation = new PaymentCommon6 { CreditDebitIndicator = Codesets.CreditDebitCode.Credit },
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "CreditDebitIndicator1Rule");
    }
}
