// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxAuthorisation1ValidatorTests
{
    private readonly TaxAuthorisation1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new TaxAuthorisation1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new TaxAuthorisation1 { Title = "Mr", Name = "John Doe" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
