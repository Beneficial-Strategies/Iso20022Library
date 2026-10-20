// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupInformation27ValidatorTests
{
    private readonly OriginalGroupInformation27Validator _sut = new();

    private static IOriginalGroupInformation27 ValidMessage() =>
        IsoDataFactory.Make<IOriginalGroupInformation27>(b => b
            .Set(x => x.OriginalMessageIdentification).To("MSG-001")
            .Set(x => x.OriginalMessageNameIdentification).To("pacs.008.001.08"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFieldsPresent_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalCreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.OriginalNumberOfTransactions).To("1")
            .Set(x => x.OriginalControlSum).To(100.00m));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
