// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateAcceptanceReportV08ValidatorTests
{
    private readonly MandateAcceptanceReportV08Validator _sut = new();

    private static GroupHeader110 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static MandateAcceptanceReportV08 ValidMessage() => new() { GroupHeader = ValidGroupHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingAcceptanceDetails_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingAcceptanceDetails = [new MandateAcceptance8 { AcceptanceResult = new AcceptanceResult6 { Accepted = true } }],
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
