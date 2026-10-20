// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CaseStatus2ValidatorTests
{
    private readonly CaseStatus2Validator _sut = new();

    private static ICaseStatus2 ValidMessage() =>
        IsoDataFactory.Make<ICaseStatus2>(b => b
            .Set(x => x.DateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.CaseStatus).To(CaseStatus2Code.Assigned));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Reason_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Reason).To("Approved after review"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
