// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InvestigationRejectionJustification1ValidatorTests
{
    private readonly InvestigationRejectionJustification1Validator _sut = new();

    private static InvestigationRejectionJustification1 ValidMessage() =>
        new() { RejectionReason = InvestigationRejection1Code.UnderlyingPaymentNotFound };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
