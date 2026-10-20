// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CaseStatusReportRequestV05ValidatorTests
{
    private readonly CaseStatusReportRequestV05Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IParty50Choice ValidParty() =>
        IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Acme Corp"))));

    private static IReportHeader7 ValidRequestHeader() =>
        IsoDataFactory.Make<IReportHeader7>(b => b
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.From).To(ValidParty())
            .Set(x => x.Identification).To("RPT-001")
            .Set(x => x.To).To(ValidParty()));

    private static ICase6 ValidCase() => IsoDataFactory.Make<ICase6>(b => b
        .Set(x => x.Identification).To("CASE-001")
        .Set(x => x.Creator).To(ValidParty()));

    private static ICaseStatusReportRequestV05 ValidMessage() =>
        IsoDataFactory.Make<ICaseStatusReportRequestV05>(b => b
            .Set(x => x.RequestHeader).To(ValidRequestHeader())
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
}
