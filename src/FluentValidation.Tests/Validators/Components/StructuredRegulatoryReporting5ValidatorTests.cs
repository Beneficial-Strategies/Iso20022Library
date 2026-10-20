// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StructuredRegulatoryReporting5ValidatorTests
{
    private readonly StructuredRegulatoryReporting5Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IStructuredRegulatoryReporting5>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IStructuredRegulatoryReporting5>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.RegulatoryReportingType1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYTYPE")))
            .Set(x => x.Date).To(new DateOnly(2026, 1, 1))
            .Set(x => x.Country).To("US")
            .Set(x => x.ReportingCode).To("RC01")
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.Information).To(["Extra info"]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
