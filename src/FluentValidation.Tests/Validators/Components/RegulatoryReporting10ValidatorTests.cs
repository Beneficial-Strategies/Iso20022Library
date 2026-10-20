// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RegulatoryReporting10ValidatorTests
{
    private readonly RegulatoryReporting10Validator _sut = new();

    private static IRegulatoryReporting10 ValidMessage() =>
        IsoDataFactory.Make<IRegulatoryReporting10>(b => b
            .Set(x => x.DebitCreditReportingIndicator).To(RegulatoryReportingType1Code.Debit));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Authority).To(IsoDataFactory.Make<IRegulatoryAuthority2>(b2 => b2
                .Set(x2 => x2.Name).To("Financial Regulator")))
            .Set(x => x.Details).To([
                IsoDataFactory.Make<IStructuredRegulatoryReporting5>(b2 => b2
                    .Set(x2 => x2.ReportingCode).To("RC01")),
            ]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
