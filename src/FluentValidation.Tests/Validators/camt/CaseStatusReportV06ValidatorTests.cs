// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CaseStatusReportV06ValidatorTests
{
    private readonly CaseStatusReportV06Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IParty50Choice ValidParty() =>
        IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Acme Corp"))));

    private static IReportHeader7 ValidHeader() =>
        IsoDataFactory.Make<IReportHeader7>(b => b
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.From).To(ValidParty())
            .Set(x => x.Identification).To("RPT-001")
            .Set(x => x.To).To(ValidParty()));

    private static ICase6 ValidCase() => IsoDataFactory.Make<ICase6>(b => b
        .Set(x => x.Identification).To("CASE-001")
        .Set(x => x.Creator).To(ValidParty()));

    private static ICaseStatus2 ValidStatus() =>
        IsoDataFactory.Make<ICaseStatus2>(b => b
            .Set(x => x.DateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.CaseStatus).To(CaseStatus2Code.Assigned));

    private static ICaseStatusReportV06 ValidMessage() =>
        IsoDataFactory.Make<ICaseStatusReportV06>(b => b
            .Set(x => x.Header).To(ValidHeader())
            .Set(x => x.Case).To(ValidCase())
            .Set(x => x.Status).To(ValidStatus()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void NewAssignment_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.NewAssignment).To(IsoDataFactory.Make<ICaseAssignment6>(b2 => b2
                .Set(x2 => x2.Identification).To("ASSIGN-001")
                .Set(x2 => x2.Assigner).To(ValidParty())
                .Set(x2 => x2.Assignee).To(ValidParty())
                .Set(x2 => x2.CreationDateTime).To(new DateTime(2026, 1, 1)))));
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
