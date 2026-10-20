// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxParty1ValidatorTests
{
    private readonly TaxParty1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ITaxParty1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ITaxParty1>(b => b
            .Set(x => x.TaxIdentification).To("TAX-001")
            .Set(x => x.RegistrationIdentification).To("REG-001")
            .Set(x => x.TaxType).To("VAT"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
