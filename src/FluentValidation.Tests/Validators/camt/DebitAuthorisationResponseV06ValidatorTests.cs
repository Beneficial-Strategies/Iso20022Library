// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DebitAuthorisationResponseV06ValidatorTests
{
    private readonly DebitAuthorisationResponseV06Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.Party50Choice_ ValidParty() =>
        new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party
        {
            Value = new PartyIdentification272 { Name = "Acme Corp" },
        };

    private static CaseAssignment6 ValidAssignment() =>
        new()
        {
            Identification = "ASSIGN-001",
            Assigner = ValidParty(),
            Assignee = ValidParty(),
            CreationDateTime = new DateTime(2026, 1, 1),
        };

    private static DebitAuthorisationConfirmation2 ValidConfirmation() =>
        new() { DebitAuthorisation = true };

    private static DebitAuthorisationResponseV06 ValidMessage() =>
        new() { Assignment = ValidAssignment(), Confirmation = ValidConfirmation() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Case_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Case = new Case6 { Identification = "CASE-001", Creator = ValidParty() },
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
