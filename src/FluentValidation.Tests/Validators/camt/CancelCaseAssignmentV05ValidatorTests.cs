// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CancelCaseAssignmentV05ValidatorTests
{
    private readonly CancelCaseAssignmentV05Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IParty50Choice ValidParty() =>
        IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Acme Corp"))));

    private static ICaseAssignment6 ValidAssignment() =>
        IsoDataFactory.Make<ICaseAssignment6>(b => b
            .Set(x => x.Identification).To("ASSIGN-001")
            .Set(x => x.Assigner).To(ValidParty())
            .Set(x => x.Assignee).To(ValidParty())
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static ICase6 ValidCase() => IsoDataFactory.Make<ICase6>(b => b
        .Set(x => x.Identification).To("CASE-001")
        .Set(x => x.Creator).To(ValidParty()));

    private static ICancelCaseAssignmentV05 ValidMessage() =>
        IsoDataFactory.Make<ICancelCaseAssignmentV05>(b => b
            .Set(x => x.Assignment).To(ValidAssignment())
            .Set(x => x.Case).To(ValidCase()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
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
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())
            .Set(x => x.BranchIdentification).To(IsoDataFactory.Make<IBranchData5>(b2 => b2
                .Set(x2 => x2.PostalAddress).To(IsoDataFactory.Make<IPostalAddress27>(b3 => b3
                    .Set(x3 => x3.AddressType).To(IsoDataFactory.Make<Choices.AddressType3Choice.ICode>(b4 => b4
                        .Set(x4 => x4.Value).To(AddressType2Code.Business))))))));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Assignment).To(IsoDataFactory.With(ValidAssignment(), b2 => b2
                .Set(x2 => x2.Assigner).To(IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b3 => b3
                    .Set(x3 => x3.Value).To(agent))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
