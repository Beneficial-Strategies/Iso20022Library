// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pacs;

public class FIToFIPaymentStatusRequestV07ValidatorTests
{
    private readonly FIToFIPaymentStatusRequestV07Validator _sut = new();

    private static GroupHeader109 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static OriginalGroupInformation27 ValidOriginalGroupInformation() =>
        new() { OriginalMessageIdentification = "OMSG-001", OriginalMessageNameIdentification = "pacs.008.001.08" };

    private static OriginalGroupInformation33 ValidTransactionOriginalGroupInformation() =>
        new() { OriginalMessageIdentification = "OMSG-001", OriginalMessageNameIdentification = "pacs.008.001.08" };

    private static PaymentTransaction171 TransactionWithOwnOriginalGroupInformation() =>
        new() { OriginalGroupInformation = ValidTransactionOriginalGroupInformation() };

    private static PaymentTransaction171 TransactionWithoutOwnOriginalGroupInformation() => new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        // No OriginalGroupInformation and no TransactionInformation at all — none of the three
        // presence rules are triggered (they only constrain elements of TransactionInformation
        // when it's non-empty).
        var msg = new FIToFIPaymentStatusRequestV07 { GroupHeader = ValidGroupHeader() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationAbsenceRule (count = 0) ──────────────────────────

    [Fact]
    public void OriginalGroupInformationAbsent_TransactionWithoutOwnOriginalGroupInformation_HasValidationError()
    {
        var msg = new FIToFIPaymentStatusRequestV07
        {
            GroupHeader = ValidGroupHeader(),
            TransactionInformation = [TransactionWithoutOwnOriginalGroupInformation()],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationAbsenceRule");
    }

    [Fact]
    public void OriginalGroupInformationAbsent_TransactionWithOwnOriginalGroupInformation_NoValidationError()
    {
        var msg = new FIToFIPaymentStatusRequestV07
        {
            GroupHeader = ValidGroupHeader(),
            TransactionInformation = [TransactionWithOwnOriginalGroupInformation()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationSinglePresenceRule (count = 1) ───────────────────

    [Fact]
    public void OriginalGroupInformationPresentOnce_TransactionWithOwnOriginalGroupInformation_HasValidationError()
    {
        var msg = new FIToFIPaymentStatusRequestV07
        {
            GroupHeader = ValidGroupHeader(),
            OriginalGroupInformation = [ValidOriginalGroupInformation()],
            TransactionInformation = [TransactionWithOwnOriginalGroupInformation()],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationSinglePresenceRule");
    }

    [Fact]
    public void OriginalGroupInformationPresentOnce_TransactionWithoutOwnOriginalGroupInformation_NoValidationError()
    {
        var msg = new FIToFIPaymentStatusRequestV07
        {
            GroupHeader = ValidGroupHeader(),
            OriginalGroupInformation = [ValidOriginalGroupInformation()],
            TransactionInformation = [TransactionWithoutOwnOriginalGroupInformation()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalGroupInformationMultiplePresenceRule (count > 1) ─────────────────

    [Fact]
    public void OriginalGroupInformationPresentTwice_TransactionWithoutOwnOriginalGroupInformation_HasValidationError()
    {
        var msg = new FIToFIPaymentStatusRequestV07
        {
            GroupHeader = ValidGroupHeader(),
            OriginalGroupInformation = [ValidOriginalGroupInformation(), ValidOriginalGroupInformation()],
            TransactionInformation = [TransactionWithoutOwnOriginalGroupInformation()],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalGroupInformationMultiplePresenceRule");
    }

    [Fact]
    public void OriginalGroupInformationPresentTwice_TransactionWithOwnOriginalGroupInformation_NoValidationError()
    {
        var msg = new FIToFIPaymentStatusRequestV07
        {
            GroupHeader = ValidGroupHeader(),
            OriginalGroupInformation = [ValidOriginalGroupInformation(), ValidOriginalGroupInformation()],
            TransactionInformation = [TransactionWithOwnOriginalGroupInformation()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = new FIToFIPaymentStatusRequestV07
        {
            GroupHeader = ValidGroupHeader(),
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
