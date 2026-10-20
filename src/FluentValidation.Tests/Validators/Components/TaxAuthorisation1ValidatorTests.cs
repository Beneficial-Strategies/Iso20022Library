// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxAuthorisation1ValidatorTests
{
    private readonly TaxAuthorisation1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ITaxAuthorisation1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ITaxAuthorisation1>(b => b
            .Set(x => x.Title).To("Mr")
            .Set(x => x.Name).To("John Doe"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
