// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxParty2ValidatorTests
{
    private readonly TaxParty2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new TaxParty2()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new TaxParty2
        {
            TaxIdentification = "TAX-001",
            RegistrationIdentification = "REG-001",
            TaxType = "VAT",
            Authorisation = new TaxAuthorisation1 { Name = "John Doe" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
