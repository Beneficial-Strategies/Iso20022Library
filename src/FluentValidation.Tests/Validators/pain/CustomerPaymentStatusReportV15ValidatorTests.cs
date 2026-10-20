// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerPaymentStatusReportV15ValidatorTests
{
    private readonly CustomerPaymentStatusReportV15Validator _sut = new();

    private static IGroupHeader128 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader128>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IOriginalGroupHeader22 ValidOriginalGroupInformation(
        ExternalPaymentGroupStatus1Code? groupStatus = null
    ) =>
        IsoDataFactory.Make<IOriginalGroupHeader22>(b => b
            .Set(x => x.OriginalMessageIdentification).To("MSG-000")
            .Set(x => x.OriginalMessageNameIdentification).To("pain.001.001.13")
            .Set(x => x.GroupStatus).To(groupStatus));

    private static ICustomerPaymentStatusReportV15 ValidMessage() =>
        IsoDataFactory.Make<ICustomerPaymentStatusReportV15>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.OriginalGroupInformationAndStatus).To(ValidOriginalGroupInformation()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupStatusAccepted_WithRejectedPaymentInformationStatus_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To(ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation
            ))
            .Set(x => x.OriginalPaymentInformationAndStatus).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction56>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationStatus).To(ExternalPaymentGroupStatus1Code.Rejected)),
            ]));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusAcceptedRule");
    }

    [Fact]
    public void GroupStatusPending_WithRejectedPaymentInformationStatus_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To(ValidOriginalGroupInformation(ExternalPaymentGroupStatus1Code.Pending))
            .Set(x => x.OriginalPaymentInformationAndStatus).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction56>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationStatus).To(ExternalPaymentGroupStatus1Code.Rejected)),
            ]));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusPendingRule");
    }

    [Fact]
    public void GroupStatusRejected_WithNonRejectedPaymentInformationStatus_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To(ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Rejected
            ))
            .Set(x => x.OriginalPaymentInformationAndStatus).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction56>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationStatus).To(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation)),
            ]));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusRejectedRule");
    }

    [Fact]
    public void GroupStatusRejected_WithRejectedPaymentInformationStatus_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To(ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Rejected
            ))
            .Set(x => x.OriginalPaymentInformationAndStatus).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction56>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationStatus).To(ExternalPaymentGroupStatus1Code.Rejected)),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupStatusReceived_WithPaymentInformationStatusPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To(ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Received
            ))
            .Set(x => x.OriginalPaymentInformationAndStatus).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction56>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationStatus).To(ExternalPaymentGroupStatus1Code.AcceptedTechnicalValidation)),
            ]));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupStatusReceivedRule");
    }

    [Fact]
    public void GroupStatusReceived_WithNoPaymentInformationStatus_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalGroupInformationAndStatus).To(ValidOriginalGroupInformation(
                ExternalPaymentGroupStatus1Code.Received
            ))
            .Set(x => x.OriginalPaymentInformationAndStatus).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction56>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
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
