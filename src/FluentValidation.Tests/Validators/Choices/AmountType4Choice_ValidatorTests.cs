// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AmountType4Choice_ValidatorTests
{
    private readonly AmountType4Choice_Validator _sut = new();

    [Fact]
    public void InstructedAmountVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.AmountType4Choice.Valid.InstructedAmount.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EquivalentAmountVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.AmountType4Choice.Valid.EquivalentAmount.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EquivalentAmountVariant_PopulatedRegistry_RejectsCurrencyOfTransferNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ActiveOrHistoricCurrencyCode>();
        registry.Add("EUR");
        var sut = new AmountType4Choice_Validator(new ActiveOrHistoricCurrencyCodeValidator(registry));

        var value = BeneficialStrategies.Iso20022.Samples.AmountType4Choice.Valid.EquivalentAmount.Maximal;
        var result = sut.Validate(value);
        Assert.False(result.IsValid);
    }
}
