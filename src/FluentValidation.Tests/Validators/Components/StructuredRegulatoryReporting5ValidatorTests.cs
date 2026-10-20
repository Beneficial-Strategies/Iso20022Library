// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StructuredRegulatoryReporting5ValidatorTests
{
    private readonly StructuredRegulatoryReporting5Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new StructuredRegulatoryReporting5()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new StructuredRegulatoryReporting5
        {
            Type = new BeneficialStrategies.Iso20022.Choices.RegulatoryReportingType1Choice.Proprietary
            {
                Value = "MYTYPE",
            },
            Date = new DateOnly(2026, 1, 1),
            Country = "US",
            ReportingCode = "RC01",
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            Information = ["Extra info"],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
