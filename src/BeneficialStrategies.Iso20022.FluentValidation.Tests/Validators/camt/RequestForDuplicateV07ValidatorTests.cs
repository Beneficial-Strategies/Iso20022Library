// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class RequestForDuplicateV07ValidatorTests
{
    private readonly RequestForDuplicateV07Validator _sut = new();

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

    private static RequestForDuplicateV07 ValidMessage() => new() { Assignment = ValidAssignment() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Case: Case6, optional (0..1) ───────────────────────────────────────

    [Fact]
    public void Case_Absent_NoValidationError()
    {
        var msg = ValidMessage() with { Case = null };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Case);
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
}
