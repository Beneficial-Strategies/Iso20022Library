// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ClearingSystemMemberIdentification2ValidatorTests
{
    private readonly ClearingSystemMemberIdentification2Validator _sut = new();

    private static IClearingSystemMemberIdentification2 ValidMessage() =>
        IsoDataFactory.Make<IClearingSystemMemberIdentification2>(b => b
            .Set(x => x.MemberIdentification).To("MEMBER-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ClearingSystemIdentification_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ClearingSystemIdentification).To(IsoDataFactory.Make<Choices.ClearingSystemIdentification2Choice.IProprietary>(b2 => b2
                    .Set(x2 => x2.Value).To("MYCLRSYS"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
