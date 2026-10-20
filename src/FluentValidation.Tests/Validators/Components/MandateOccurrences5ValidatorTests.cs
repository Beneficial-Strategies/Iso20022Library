// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateOccurrences5ValidatorTests
{
    private readonly MandateOccurrences5Validator _sut = new();

    private static MandateOccurrences5 ValidMessage() => new() { SequenceType = SequenceType2Code.Recurring };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Frequency = new BeneficialStrategies.Iso20022.Choices.Frequency36Choice.Type
            {
                Value = Frequency6Code.Monthly,
            },
            Duration = new DatePeriod3 { FromDate = new DateOnly(2026, 1, 1) },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
