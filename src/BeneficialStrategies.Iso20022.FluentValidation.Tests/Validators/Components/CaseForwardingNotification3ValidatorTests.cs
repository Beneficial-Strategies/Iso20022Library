// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CaseForwardingNotification3ValidatorTests
{
    private readonly CaseForwardingNotification3Validator _sut = new();

    private static CaseForwardingNotification3 ValidMessage() =>
        new() { Justification = CaseForwardingNotification3Code.FurtherInvestigation };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
