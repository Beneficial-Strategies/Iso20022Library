// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFIPaymentStatusReportV16ValidatorTests
{
    private readonly FIToFIPaymentStatusReportV16Validator _sut = new();

    private static GroupHeader120 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static OriginalGroupHeader22 ValidOriginalGroup(ExternalPaymentGroupStatus1Code? status = null) =>
        new()
        {
            OriginalMessageIdentification = "OMSG-001",
            OriginalMessageNameIdentification = "pacs.008.001.08",
            GroupStatus = status,
        };

    private static OriginalGroupInformation33 ValidTransactionOriginalGroup() =>
        new() { OriginalMessageIdentification = "OMSG-001", OriginalMessageNameIdentification = "pacs.008.001.08" };

    private static FIToFIPaymentStatusReportV16 ValidMessage() => new() { GroupHeader = ValidGroupHeader() };

    [Fact]
    public void EmptyCollections_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationAbsenceRule (count = 0) ──────────────────────────

    [Fact]
    public void OriginalGroupAbsent_TransactionWithoutOwnOriginalGroup_HasValidationError()
    {
        var msg = ValidMessage() with { TransactionInformationAndStatus = [new PaymentTransaction177()] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationAbsenceRule");
    }

    [Fact]
    public void OriginalGroupAbsent_TransactionWithOwnOriginalGroup_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177 { OriginalGroupInformation = ValidTransactionOriginalGroup() },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationSinglePresenceRule (count = 1) ───────────────────

    [Fact]
    public void OriginalGroupPresentOnce_TransactionWithOwnOriginalGroup_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = [ValidOriginalGroup()],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177 { OriginalGroupInformation = ValidTransactionOriginalGroup() },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationSinglePresenceRule");
    }

    // ── OriginalGroupInformationMultiplePresenceRule (count > 1) ─────────────────

    [Fact]
    public void OriginalGroupPresentTwice_TransactionWithoutOwnOriginalGroup_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = [ValidOriginalGroup(), ValidOriginalGroup()],
            TransactionInformationAndStatus = [new PaymentTransaction177()],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationMultiplePresenceRule");
    }

    // ── GroupStatusAcceptedRule ───────────────────────────────────────────────────

    [Fact]
    public void GroupStatusAccepted_TransactionRejected_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus =
            [
                ValidOriginalGroup(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation),
            ],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177
                {
                    OriginalGroupInformation = ValidTransactionOriginalGroup(),
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.Rejected,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusAcceptedRule");
    }

    [Fact]
    public void GroupStatusAccepted_TransactionNotRejected_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus =
            [
                ValidOriginalGroup(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation),
            ],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177
                {
                    OriginalGroupInformation = ValidTransactionOriginalGroup(),
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupStatusAcceptedRule");
    }

    // ── GroupStatusPendingRule ────────────────────────────────────────────────────

    [Fact]
    public void GroupStatusPending_TransactionRejected_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = [ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Pending)],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177
                {
                    OriginalGroupInformation = ValidTransactionOriginalGroup(),
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.Rejected,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusPendingRule");
    }

    // ── GroupStatusRejectedRule ───────────────────────────────────────────────────

    [Fact]
    public void GroupStatusRejected_TransactionNotRejected_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = [ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Rejected)],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177
                {
                    OriginalGroupInformation = ValidTransactionOriginalGroup(),
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusRejectedRule");
    }

    [Fact]
    public void GroupStatusRejected_TransactionRejectedOrAbsent_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = [ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Rejected)],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177
                {
                    OriginalGroupInformation = ValidTransactionOriginalGroup(),
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.Rejected,
                },
                new PaymentTransaction177 { OriginalGroupInformation = ValidTransactionOriginalGroup() },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupStatusRejectedRule");
    }

    // ── GroupStatusReceivedRule ───────────────────────────────────────────────────

    [Fact]
    public void GroupStatusReceived_TransactionStatusPresent_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = [ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Received)],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177
                {
                    OriginalGroupInformation = ValidTransactionOriginalGroup(),
                    TransactionStatus = ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation,
                },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusReceivedRule");
    }

    [Fact]
    public void GroupStatusReceived_TransactionStatusAbsent_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformationAndStatus = [ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Received)],
            TransactionInformationAndStatus =
            [
                new PaymentTransaction177 { OriginalGroupInformation = ValidTransactionOriginalGroup() },
            ],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupStatusReceivedRule");
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
