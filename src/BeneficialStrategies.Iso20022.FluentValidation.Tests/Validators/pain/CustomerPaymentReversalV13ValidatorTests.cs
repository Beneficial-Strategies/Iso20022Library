// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerPaymentReversalV13ValidatorTests
{
    private readonly CustomerPaymentReversalV13Validator _sut = new();

    private static GroupHeader124 ValidGroupHeader(bool? groupReversal = false, string numberOfTransactions = "1") =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = numberOfTransactions,
            GroupReversal = groupReversal,
        };

    private static OriginalGroupHeader20 ValidOriginalGroupInformation() =>
        new() { OriginalMessageIdentification = "MSG-000", OriginalMessageNameIdentification = "pain.008.001.13" };

    /// <summary>
    /// Individual-transaction-reversal mode: GroupReversal is false, one payment-information block
    /// is itself flagged PaymentInformationReversal=true, which exempts it from the
    /// GroupReversalAndNumberOfTransactionsGuideline count check.
    /// </summary>
    private static CustomerPaymentReversalV13 ValidMessage() =>
        new()
        {
            GroupHeader = ValidGroupHeader(),
            OriginalGroupInformation = ValidOriginalGroupInformation(),
            OriginalPaymentInformationAndReversal =
            [
                new OriginalPaymentInstruction53
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationReversal = true,
                },
            ],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupReversalMode_ValidMessage_NoValidationErrors()
    {
        var msg = new CustomerPaymentReversalV13
        {
            GroupHeader = ValidGroupHeader(groupReversal: true),
            OriginalGroupInformation = ValidOriginalGroupInformation() with
            {
                ReversalReasonInformation =
                [
                    new PaymentReversalReason10
                    {
                        Reason = new BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice.Proprietary
                        {
                            Value = "MYREVREASON",
                        },
                    },
                ],
            },
            OriginalPaymentInformationAndReversal = [],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupReversalTrue_WithPaymentInformationPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader(groupReversal: true),
            OriginalGroupInformation = ValidOriginalGroupInformation() with
            {
                ReversalReasonInformation =
                [
                    new PaymentReversalReason10
                    {
                        Reason = new BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice.Proprietary
                        {
                            Value = "MYREVREASON",
                        },
                    },
                ],
            },
        };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndPaymentInformationNotPresentRule");
    }

    [Fact]
    public void GroupReversalTrue_WithoutReason_HasValidationError()
    {
        var msg = new CustomerPaymentReversalV13
        {
            GroupHeader = ValidGroupHeader(groupReversal: true),
            OriginalGroupInformation = ValidOriginalGroupInformation(),
            OriginalPaymentInformationAndReversal = [],
        };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndReasonRule");
    }

    [Fact]
    public void GroupReversalFalse_WithoutPaymentInformation_HasValidationError()
    {
        var msg = ValidMessage() with { OriginalPaymentInformationAndReversal = [] };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndPaymentInformationPresentRule");
    }

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMismatch_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader(numberOfTransactions: "5"),
            OriginalPaymentInformationAndReversal =
            [
                new OriginalPaymentInstruction53
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationReversal = false,
                    TransactionInformation = [new PaymentTransaction174(), new PaymentTransaction174()],
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndNumberOfTransactionsGuideline");
    }

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMatches_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            GroupHeader = ValidGroupHeader(numberOfTransactions: "2"),
            OriginalPaymentInformationAndReversal =
            [
                new OriginalPaymentInstruction53
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationReversal = false,
                    TransactionInformation = [new PaymentTransaction174(), new PaymentTransaction174()],
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
