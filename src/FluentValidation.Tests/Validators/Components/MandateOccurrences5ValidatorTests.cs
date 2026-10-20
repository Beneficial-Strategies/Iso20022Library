// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateOccurrences5ValidatorTests
{
    private readonly MandateOccurrences5Validator _sut = new();

    private static IMandateOccurrences5 ValidMessage() => IsoDataFactory.Make<IMandateOccurrences5>(b => b
        .Set(x => x.SequenceType).To(SequenceType2Code.Recurring));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Frequency).To(IsoDataFactory.Make<Choices.Frequency36Choice.IType>(b2 => b2
                .Set(x2 => x2.Value).To(Frequency6Code.Monthly)))
            .Set(x => x.Duration).To(IsoDataFactory.Make<IDatePeriod3>(b2 => b2
                .Set(x2 => x2.FromDate).To(new DateOnly(2026, 1, 1)))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
