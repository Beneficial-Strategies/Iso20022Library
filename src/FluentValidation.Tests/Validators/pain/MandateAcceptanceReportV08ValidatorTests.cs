// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateAcceptanceReportV08ValidatorTests
{
    private readonly MandateAcceptanceReportV08Validator _sut = new();

    private static IGroupHeader110 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader110>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IMandateAcceptanceReportV08 ValidMessage() => IsoDataFactory.Make<IMandateAcceptanceReportV08>(b => b
        .Set(x => x.GroupHeader).To(ValidGroupHeader()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingAcceptanceDetails_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingAcceptanceDetails).To([IsoDataFactory.Make<IMandateAcceptance8>(b2 => b2
                .Set(x2 => x2.AcceptanceResult).To(IsoDataFactory.Make<IAcceptanceResult6>(b3 => b3
                .Set(x3 => x3.Accepted).To(true))))]));
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
