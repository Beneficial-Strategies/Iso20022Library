// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DebitAuthorisationResponseV06ValidatorTests
{
    private readonly DebitAuthorisationResponseV06Validator _sut = new();

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

    private static IDebitAuthorisationConfirmation2 ValidConfirmation() =>
        IsoDataFactory.Make<IDebitAuthorisationConfirmation2>(b => b
            .Set(x => x.DebitAuthorisation).To(true));

    private static IDebitAuthorisationResponseV06 ValidMessage() =>
        IsoDataFactory.Make<IDebitAuthorisationResponseV06>(b => b
            .Set(x => x.Assignment).To(ValidAssignment())
            .Set(x => x.Confirmation).To(ValidConfirmation()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
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

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
