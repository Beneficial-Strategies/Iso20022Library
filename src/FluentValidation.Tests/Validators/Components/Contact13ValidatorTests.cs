// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Contact13ValidatorTests
{
    private readonly Contact13Validator _sut = new();

    private static IContact13 ValidMessage() => IsoDataFactory.Make<IContact13>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Other_NonEmpty_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Other).To([IsoDataFactory.Make<IOtherContact1>(b2 => b2
            .Set(x2 => x2.ChannelType).To("FAXX"))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
