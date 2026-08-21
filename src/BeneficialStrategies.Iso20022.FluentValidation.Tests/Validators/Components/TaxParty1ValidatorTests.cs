// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxParty1ValidatorTests
{
    private readonly TaxParty1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new TaxParty1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new TaxParty1
        {
            TaxIdentification = "TAX-001",
            RegistrationIdentification = "REG-001",
            TaxType = "VAT",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
