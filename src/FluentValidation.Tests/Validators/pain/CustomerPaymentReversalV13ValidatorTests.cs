// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class CustomerPaymentReversalV13ValidatorTests
{
    private readonly CustomerPaymentReversalV13Validator _sut = new();

    private static IGroupHeader124 ValidGroupHeader(bool? groupReversal = false, string numberOfTransactions = "1") =>
        IsoDataFactory.Make<IGroupHeader124>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To(numberOfTransactions)
            .Set(x => x.GroupReversal).To(groupReversal));

    private static IOriginalGroupHeader20 ValidOriginalGroupInformation() =>
        IsoDataFactory.Make<IOriginalGroupHeader20>(b => b
            .Set(x => x.OriginalMessageIdentification).To("MSG-000")
            .Set(x => x.OriginalMessageNameIdentification).To("pain.008.001.13"));

    /// <summary>
    /// Individual-transaction-reversal mode: GroupReversal is false, one payment-information block
    /// is itself flagged PaymentInformationReversal=true, which exempts it from the
    /// GroupReversalAndNumberOfTransactionsGuideline count check.
    /// </summary>
    private static ICustomerPaymentReversalV13 ValidMessage() =>
        IsoDataFactory.Make<ICustomerPaymentReversalV13>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.OriginalGroupInformation).To(ValidOriginalGroupInformation())
            .Set(x => x.OriginalPaymentInformationAndReversal).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction53>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationReversal).To(true)),
            ]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupReversalMode_ValidMessage_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<ICustomerPaymentReversalV13>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader(groupReversal: true))
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.With(ValidOriginalGroupInformation(), b2 => b2
                .Set(x2 => x2.ReversalReasonInformation).To([
                    IsoDataFactory.Make<IPaymentReversalReason10>(b3 => b3
                        .Set(x3 => x3.Reason).To(IsoDataFactory.Make<Choices.ReversalReason4Choice.IProprietary>(b4 => b4
                            .Set(x4 => x4.Value).To("MYREVREASON")))),
                ])))
            .Set(x => x.OriginalPaymentInformationAndReversal).To([]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupReversalTrue_WithPaymentInformationPresent_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader(groupReversal: true))
            .Set(x => x.OriginalGroupInformation).To(IsoDataFactory.With(ValidOriginalGroupInformation(), b2 => b2
                .Set(x2 => x2.ReversalReasonInformation).To([
                    IsoDataFactory.Make<IPaymentReversalReason10>(b3 => b3
                        .Set(x3 => x3.Reason).To(IsoDataFactory.Make<Choices.ReversalReason4Choice.IProprietary>(b4 => b4
                            .Set(x4 => x4.Value).To("MYREVREASON")))),
                ]))));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndPaymentInformationNotPresentRule");
    }

    [Fact]
    public void GroupReversalTrue_WithoutReason_HasValidationError()
    {
        var msg = IsoDataFactory.Make<ICustomerPaymentReversalV13>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader(groupReversal: true))
            .Set(x => x.OriginalGroupInformation).To(ValidOriginalGroupInformation())
            .Set(x => x.OriginalPaymentInformationAndReversal).To([]));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndReasonRule");
    }

    [Fact]
    public void GroupReversalFalse_WithoutPaymentInformation_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalPaymentInformationAndReversal).To([]));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndPaymentInformationPresentRule");
    }

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMismatch_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader(numberOfTransactions: "5"))
            .Set(x => x.OriginalPaymentInformationAndReversal).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction53>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationReversal).To(false)
                    .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction174>(), IsoDataFactory.Make<IPaymentTransaction174>()])),
            ]));
        var result = _sut.Validate(msg);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "GroupReversalAndNumberOfTransactionsGuideline");
    }

    [Fact]
    public void GroupReversalFalse_NumberOfTransactionsMatches_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader(numberOfTransactions: "2"))
            .Set(x => x.OriginalPaymentInformationAndReversal).To([
                IsoDataFactory.Make<IOriginalPaymentInstruction53>(b2 => b2
                    .Set(x2 => x2.OriginalPaymentInformationIdentification).To("PMTINF-001")
                    .Set(x2 => x2.PaymentInformationReversal).To(false)
                    .Set(x2 => x2.TransactionInformation).To([IsoDataFactory.Make<IPaymentTransaction174>(), IsoDataFactory.Make<IPaymentTransaction174>()])),
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
