// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxParty2ValidatorTests
{
    private readonly TaxParty2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ITaxParty2>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ITaxParty2>(b => b
            .Set(x => x.TaxIdentification).To("TAX-001")
            .Set(x => x.RegistrationIdentification).To("REG-001")
            .Set(x => x.TaxType).To("VAT")
            .Set(x => x.Authorisation).To(IsoDataFactory.Make<ITaxAuthorisation1>(b2 => b2
                .Set(x2 => x2.Name).To("John Doe"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
