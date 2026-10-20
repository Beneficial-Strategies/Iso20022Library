// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SupplementaryData1ValidatorTests
{
    private readonly SupplementaryData1Validator _sut = new();

    private static SupplementaryData1 ValidMessage() =>
        new() { Envelope = new SupplementaryDataEnvelope1() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PlaceAndName_Present_NoValidationError()
    {
        var msg = ValidMessage() with { PlaceAndName = "/Document/Xpath" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
