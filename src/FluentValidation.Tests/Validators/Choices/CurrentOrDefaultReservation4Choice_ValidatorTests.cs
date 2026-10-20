// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CurrentOrDefaultReservation4Choice_ValidatorTests
{
    private readonly CurrentOrDefaultReservation4Choice_Validator _sut = new();

    [Fact]
    public void CurrentVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.CurrentOrDefaultReservation4Choice.Valid.Current.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DefaultVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.CurrentOrDefaultReservation4Choice.Valid.Default.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
