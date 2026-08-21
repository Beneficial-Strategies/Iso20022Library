// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerPaymentStatusReportV15ValidatorTests
{
    private readonly CustomerPaymentStatusReportV15Validator _sut = new();

    private static GroupHeader128 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static OriginalGroupHeader22 ValidOriginalGroupInformation(
        ExternalPaymentGroupStatus1Code? groupStatus = null
    ) =>
        new()
        {
            OriginalMessageIdentification = "MSG-000",
            OriginalMessageNameIdentification = "pain.001.001.13",
            GroupStatus = groupStatus,
        };

    private static CustomerPaymentStatusReportV15 ValidMessage() =>
        new()
        {
            GroupHeader = ValidGroupHeader(),
            OriginalGroupInformationAndStatus = ValidOriginalGroupInformation(),
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupStatusAccepted_WithRejectedPaymentInformationStatus_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation
            ),
            OriginalPaymentInformationAndStatus =
            [
                new OriginalPaymentInstruction56
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationStatus = ExternalPaymentGroupStatus1Code.Rejected,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusAcceptedRule");
    }

    [Fact]
    public void GroupStatusPending_WithRejectedPaymentInformationStatus_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = ValidOriginalGroupInformation(ExternalPaymentGroupStatus1Code.Pending),
            OriginalPaymentInformationAndStatus =
            [
                new OriginalPaymentInstruction56
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationStatus = ExternalPaymentGroupStatus1Code.Rejected,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusPendingRule");
    }

    [Fact]
    public void GroupStatusRejected_WithNonRejectedPaymentInformationStatus_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Rejected
            ),
            OriginalPaymentInformationAndStatus =
            [
                new OriginalPaymentInstruction56
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationStatus = ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusRejectedRule");
    }

    [Fact]
    public void GroupStatusRejected_WithRejectedPaymentInformationStatus_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Rejected
            ),
            OriginalPaymentInformationAndStatus =
            [
                new OriginalPaymentInstruction56
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationStatus = ExternalPaymentGroupStatus1Code.Rejected,
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupStatusReceived_WithPaymentInformationStatusPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Received
            ),
            OriginalPaymentInformationAndStatus =
            [
                new OriginalPaymentInstruction56
                {
                    OriginalPaymentInformationIdentification = "PMTINF-001",
                    PaymentInformationStatus = ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusReceivedRule");
    }

    [Fact]
    public void GroupStatusReceived_WithNoPaymentInformationStatus_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Received
            ),
            OriginalPaymentInformationAndStatus =
            [
                new OriginalPaymentInstruction56 { OriginalPaymentInformationIdentification = "PMTINF-001" },
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
