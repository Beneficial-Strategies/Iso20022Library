// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BranchData5ValidatorTests
{
    private readonly BranchData5Validator _sut = new();

    private static IBranchData5 ValidMessage() => IsoDataFactory.Make<IBranchData5>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PostalAddress_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PostalAddress).To(IsoDataFactory.Make<IPostalAddress27>(b2 => b2
            .Set(x2 => x2.TownName).To("Springfield"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
