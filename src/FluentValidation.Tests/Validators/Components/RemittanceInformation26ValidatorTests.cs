// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceInformation26ValidatorTests
{
    private readonly RemittanceInformation26Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IRemittanceInformation26>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IRemittanceInformation26>(b => b
            .Set(x => x.Unstructured).To(["Payment for invoice 123"])
            .Set(x => x.Structured).To([IsoDataFactory.Make<IStructuredRemittanceInformation22>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
