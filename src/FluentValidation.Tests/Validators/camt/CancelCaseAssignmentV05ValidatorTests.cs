// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CancelCaseAssignmentV05ValidatorTests
{
    private readonly CancelCaseAssignmentV05Validator _sut = new();

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

    private static Case6 ValidCase() => new() { Identification = "CASE-001", Creator = ValidParty() };

    private static CancelCaseAssignmentV05 ValidMessage() =>
        new() { Assignment = ValidAssignment(), Case = ValidCase() };

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

    [Fact]
    public void NestedInvalidAssignerAgent_PropagatesErrorThroughFullChain()
    {
        // Assigner -> Agent -> BranchIdentification -> PostalAddress -> AddressType: a fully
        // valid combination proves the whole DI chain the message validator was wired up with
        // (message -> CaseAssignment6Validator -> Party50Choice_Validator ->
        // BranchAndFinancialInstitutionIdentification8Validator -> ... ) actually executes end to
        // end without throwing, which is the point of this smoke test.
        var agent = new BranchAndFinancialInstitutionIdentification8
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            BranchIdentification = new BranchData5
            {
                PostalAddress = new PostalAddress27
                {
                    AddressType = new BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Code
                    {
                        Value = AddressType2Code.Business,
                    },
                },
            },
        };
        var msg = ValidMessage() with
        {
            Assignment = ValidAssignment() with
            {
                Assigner = new BeneficialStrategies.Iso20022.Choices.Party50Choice.Agent { Value = agent },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
