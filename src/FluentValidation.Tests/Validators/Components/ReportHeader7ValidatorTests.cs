// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ReportHeader7ValidatorTests
{
    private readonly ReportHeader7Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IParty50Choice ValidParty() =>
        IsoDataFactory.Make<Choices.Party50Choice.IParty>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Acme Corp"))));

    private static IReportHeader7 ValidMessage() =>
        IsoDataFactory.Make<IReportHeader7>(b => b
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.From).To(ValidParty())
            .Set(x => x.Identification).To("RPT-001")
            .Set(x => x.To).To(ValidParty()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void FromAndTo_AsAgentVariant_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.From).To(IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b2 => b2
                .Set(x2 => x2.Value).To(agent)))
            .Set(x => x.To).To(IsoDataFactory.Make<Choices.Party50Choice.IAgent>(b2 => b2
                .Set(x2 => x2.Value).To(agent))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
