// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class RejectInvestigationV07ValidatorTests
{
    private readonly RejectInvestigationV07Validator _sut = new();

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

    private static InvestigationRejectionJustification1 ValidJustification() =>
        new() { RejectionReason = InvestigationRejection1Code.UnderlyingPaymentNotFound };

    private static RejectInvestigationV07 ValidMessage() =>
        new() { Assignment = ValidAssignment(), Justification = ValidJustification() };

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
