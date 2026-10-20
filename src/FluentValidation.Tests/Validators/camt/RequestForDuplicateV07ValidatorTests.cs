// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class RequestForDuplicateV07ValidatorTests
{
    private readonly RequestForDuplicateV07Validator _sut = new();

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

    private static IRequestForDuplicateV07 ValidMessage() => IsoDataFactory.Make<IRequestForDuplicateV07>(b => b
        .Set(x => x.Assignment).To(ValidAssignment()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Case: Case6, optional (0..1) ───────────────────────────────────────

    [Fact]
    public void Case_Absent_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Case).To(null));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Case);
    }

    [Fact]
    public void Case_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Case).To(IsoDataFactory.Make<ICase6>(b2 => b2
                .Set(x2 => x2.Identification).To("CASE-001")
                .Set(x2 => x2.Creator).To(ValidParty()))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
