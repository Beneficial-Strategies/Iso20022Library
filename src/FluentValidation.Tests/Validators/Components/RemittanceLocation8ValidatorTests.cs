// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceLocation8ValidatorTests
{
    private readonly RemittanceLocation8Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IRemittanceLocation8>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IRemittanceLocation8>(b => b
            .Set(x => x.RemittanceIdentification).To("RMT-001")
            .Set(x => x.RemittanceLocationDetails).To([IsoDataFactory.Make<IRemittanceLocationData2>(b2 => b2
                .Set(x2 => x2.Method).To(RemittanceLocationMethod2Code.Fax))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
