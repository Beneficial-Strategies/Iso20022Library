// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceInformation22ValidatorTests
{
    private readonly RemittanceInformation22Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IRemittanceInformation22>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IRemittanceInformation22>(b => b
            .Set(x => x.Unstructured).To(["Payment for invoice 123"])
            .Set(x => x.Structured).To([IsoDataFactory.Make<IStructuredRemittanceInformation18>()]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
