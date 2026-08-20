// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CaseStatusReportRequestV05ValidatorTests
{
    private readonly CaseStatusReportRequestV05Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.Party50Choice_ ValidParty() =>
        new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party
        {
            Value = new PartyIdentification272 { Name = "Acme Corp" },
        };

    private static ReportHeader7 ValidRequestHeader() =>
        new()
        {
            CreationDateTime = new DateTime(2026, 1, 1),
            From = ValidParty(),
            Identification = "RPT-001",
            To = ValidParty(),
        };

    private static Case6 ValidCase() => new() { Identification = "CASE-001", Creator = ValidParty() };

    private static CaseStatusReportRequestV05 ValidMessage() =>
        new() { RequestHeader = ValidRequestHeader(), Case = ValidCase() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
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
