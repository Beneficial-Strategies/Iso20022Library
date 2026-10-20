// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFIPaymentStatusReportV16ValidatorTests
{
    private readonly FIToFIPaymentStatusReportV16Validator _sut = new();

    private static IGroupHeader120 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader120>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IOriginalGroupHeader22 ValidOriginalGroup(ExternalPaymentGroupStatus1Code? status = null) =>
        IsoDataFactory.Make<IOriginalGroupHeader22>(b => b
            .Set(x => x.OriginalMessageIdentification).To("OMSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.08")
            .Set(x => x.GroupStatus).To(status));

    private static IOriginalGroupInformation33 ValidTransactionOriginalGroup() =>
        IsoDataFactory.Make<IOriginalGroupInformation33>(b => b
            .Set(x => x.OriginalMessageIdentification).To("OMSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.08"));

    private static IFIToFIPaymentStatusReportV16 ValidMessage() => IsoDataFactory.Make<IFIToFIPaymentStatusReportV16>(b => b
        .Set(x => x.GroupHeader).To(ValidGroupHeader()));

    [Fact]
    public void EmptyCollections_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationAbsenceRule (count = 0) ──────────────────────────

    [Fact]
    public void OriginalGroupAbsent_TransactionWithoutOwnOriginalGroup_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TransactionInformationAndStatus).To([IsoDataFactory.Make<IPaymentTransaction177>()]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationAbsenceRule");
    }

    [Fact]
    public void OriginalGroupAbsent_TransactionWithOwnOriginalGroup_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationSinglePresenceRule (count = 1) ───────────────────

    [Fact]
    public void OriginalGroupPresentOnce_TransactionWithOwnOriginalGroup_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([ValidOriginalGroup()])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationSinglePresenceRule");
    }

    // ── OriginalGroupInformationMultiplePresenceRule (count > 1) ─────────────────

    [Fact]
    public void OriginalGroupPresentTwice_TransactionWithoutOwnOriginalGroup_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([ValidOriginalGroup(), ValidOriginalGroup()])
            .Set(x => x.TransactionInformationAndStatus).To([IsoDataFactory.Make<IPaymentTransaction177>()]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationMultiplePresenceRule");
    }

    // ── GroupStatusAcceptedRule ───────────────────────────────────────────────────

    [Fact]
    public void GroupStatusAccepted_TransactionRejected_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([
                ValidOriginalGroup(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation),
            ])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())
                    .Set(x2 => x2.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.Rejected)),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusAcceptedRule");
    }

    [Fact]
    public void GroupStatusAccepted_TransactionNotRejected_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([
                ValidOriginalGroup(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation),
            ])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())
                    .Set(x2 => x2.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation)),
            ]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupStatusAcceptedRule");
    }

    // ── GroupStatusPendingRule ────────────────────────────────────────────────────

    [Fact]
    public void GroupStatusPending_TransactionRejected_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Pending)])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())
                    .Set(x2 => x2.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.Rejected)),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusPendingRule");
    }

    // ── GroupStatusRejectedRule ───────────────────────────────────────────────────

    [Fact]
    public void GroupStatusRejected_TransactionNotRejected_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Rejected)])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())
                    .Set(x2 => x2.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation)),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusRejectedRule");
    }

    [Fact]
    public void GroupStatusRejected_TransactionRejectedOrAbsent_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Rejected)])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())
                    .Set(x2 => x2.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.Rejected)),
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())),
            ]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupStatusRejectedRule");
    }

    // ── GroupStatusReceivedRule ───────────────────────────────────────────────────

    [Fact]
    public void GroupStatusReceived_TransactionStatusPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Received)])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())
                    .Set(x2 => x2.TransactionStatus).To(ExternalPaymentTransactionStatus1Code.AcceptedTechnicalValidation)),
            ]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusReceivedRule");
    }

    [Fact]
    public void GroupStatusReceived_TransactionStatusAbsent_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To([ValidOriginalGroup(ExternalPaymentGroupStatus1Code.Received)])
            .Set(x => x.TransactionInformationAndStatus).To([
                IsoDataFactory.Make<IPaymentTransaction177>(b2 => b2
                    .Set(x2 => x2.OriginalGroupInformation).To(ValidTransactionOriginalGroup())),
            ]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "GroupStatusReceivedRule");
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
