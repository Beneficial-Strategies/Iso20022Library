// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CaseStatus2ValidatorTests
{
    private readonly CaseStatus2Validator _sut = new();

    private static CaseStatus2 ValidMessage() =>
        new() { DateTime = new DateTime(2026, 1, 1), CaseStatus = CaseStatus2Code.Assigned };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Reason_Present_NoValidationError()
    {
        var msg = ValidMessage() with { Reason = "Approved after review" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
