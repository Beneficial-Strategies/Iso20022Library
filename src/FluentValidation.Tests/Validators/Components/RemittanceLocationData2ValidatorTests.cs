// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceLocationData2ValidatorTests
{
    private readonly RemittanceLocationData2Validator _sut = new();

    private static IRemittanceLocationData2 ValidMessage() =>
        IsoDataFactory.Make<IRemittanceLocationData2>(b => b
            .Set(x => x.Method).To(RemittanceLocationMethod2Code.Fax));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ElectronicAddress).To("remit@example.com")
            .Set(x => x.PostalAddress).To(IsoDataFactory.Make<INameAndAddress18>(b2 => b2
                .Set(x2 => x2.Name).To("Remit Co")
                .Set(x2 => x2.Address).To(IsoDataFactory.Make<IPostalAddress27>()))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
