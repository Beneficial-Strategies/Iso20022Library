// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ClearingSystemMemberIdentification2ValidatorTests
{
    private readonly ClearingSystemMemberIdentification2Validator _sut = new();

    private static ClearingSystemMemberIdentification2 ValidMessage() =>
        new() { MemberIdentification = "MEMBER-001" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ClearingSystemIdentification_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ClearingSystemIdentification =
                new BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice.Proprietary
                {
                    Value = "MYCLRSYS",
                },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
