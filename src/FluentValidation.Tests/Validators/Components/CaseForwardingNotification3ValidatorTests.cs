// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CaseForwardingNotification3ValidatorTests
{
    private readonly CaseForwardingNotification3Validator _sut = new();

    private static ICaseForwardingNotification3 ValidMessage() =>
        IsoDataFactory.Make<ICaseForwardingNotification3>(b => b
            .Set(x => x.Justification).To(CaseForwardingNotification3Code.FurtherInvestigation));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
