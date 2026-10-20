// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFIPaymentStatusRequestV07ValidatorTests
{
    private readonly FIToFIPaymentStatusRequestV07Validator _sut = new();

    private static IGroupHeader109 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader109>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IOriginalGroupInformation27 ValidOriginalGroupInformation() =>
        IsoDataFactory.Make<IOriginalGroupInformation27>(b => b
            .Set(x => x.OriginalMessageIdentification).To("OMSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.08"));

    private static IOriginalGroupInformation33 ValidTransactionOriginalGroupInformation() =>
        IsoDataFactory.Make<IOriginalGroupInformation33>(b => b
            .Set(x => x.OriginalMessageIdentification).To("OMSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.08"));

    private static IPaymentTransaction171 TransactionWithOwnOriginalGroupInformation() =>
        IsoDataFactory.Make<IPaymentTransaction171>(b => b
            .Set(x => x.OriginalGroupInformation).To(ValidTransactionOriginalGroupInformation()));

    private static IPaymentTransaction171 TransactionWithoutOwnOriginalGroupInformation() => IsoDataFactory.Make<IPaymentTransaction171>();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        // No OriginalGroupInformation and no TransactionInformation at all — none of the three
        // presence rules are triggered (they only constrain elements of TransactionInformation
        // when it's non-empty).
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationAbsenceRule (count = 0) ──────────────────────────

    [Fact]
    public void OriginalGroupInformationAbsent_TransactionWithoutOwnOriginalGroupInformation_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.TransactionInformation).To([TransactionWithoutOwnOriginalGroupInformation()]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationAbsenceRule");
    }

    [Fact]
    public void OriginalGroupInformationAbsent_TransactionWithOwnOriginalGroupInformation_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.TransactionInformation).To([TransactionWithOwnOriginalGroupInformation()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationSinglePresenceRule (count = 1) ───────────────────

    [Fact]
    public void OriginalGroupInformationPresentOnce_TransactionWithOwnOriginalGroupInformation_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.OriginalGroupInformation).To([ValidOriginalGroupInformation()])
            .Set(x => x.TransactionInformation).To([TransactionWithOwnOriginalGroupInformation()]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationSinglePresenceRule");
    }

    [Fact]
    public void OriginalGroupInformationPresentOnce_TransactionWithoutOwnOriginalGroupInformation_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.OriginalGroupInformation).To([ValidOriginalGroupInformation()])
            .Set(x => x.TransactionInformation).To([TransactionWithoutOwnOriginalGroupInformation()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationMultiplePresenceRule (count > 1) ─────────────────

    [Fact]
    public void OriginalGroupInformationPresentTwice_TransactionWithoutOwnOriginalGroupInformation_HasValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.OriginalGroupInformation).To([ValidOriginalGroupInformation(), ValidOriginalGroupInformation()])
            .Set(x => x.TransactionInformation).To([TransactionWithoutOwnOriginalGroupInformation()]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationMultiplePresenceRule");
    }

    [Fact]
    public void OriginalGroupInformationPresentTwice_TransactionWithOwnOriginalGroupInformation_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.OriginalGroupInformation).To([ValidOriginalGroupInformation(), ValidOriginalGroupInformation()])
            .Set(x => x.TransactionInformation).To([TransactionWithOwnOriginalGroupInformation()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IFIToFIPaymentStatusRequestV07>(b => b
            .Set(x => x.GroupHeader).To(ValidGroupHeader())
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
