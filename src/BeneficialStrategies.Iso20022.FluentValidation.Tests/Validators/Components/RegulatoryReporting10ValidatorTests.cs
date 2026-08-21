// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RegulatoryReporting10ValidatorTests
{
    private readonly RegulatoryReporting10Validator _sut = new();

    private static RegulatoryReporting10 ValidMessage() =>
        new() { DebitCreditReportingIndicator = RegulatoryReportingType1Code.Debit };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Authority = new RegulatoryAuthority2 { Name = "Financial Regulator" },
            Details =
            [
                new StructuredRegulatoryReporting5 { ReportingCode = "RC01" },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
