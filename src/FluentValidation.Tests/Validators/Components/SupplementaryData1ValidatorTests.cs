// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SupplementaryData1ValidatorTests
{
    private readonly SupplementaryData1Validator _sut = new();

    private static ISupplementaryData1 ValidMessage() =>
        IsoDataFactory.Make<ISupplementaryData1>(b => b
            .Set(x => x.Envelope).To(new SupplementaryDataEnvelope1()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PlaceAndName_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PlaceAndName).To("/Document/Xpath"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
