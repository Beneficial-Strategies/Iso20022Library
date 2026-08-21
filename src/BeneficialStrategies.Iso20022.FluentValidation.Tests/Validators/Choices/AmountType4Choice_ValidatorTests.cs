// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AmountType4Choice_ValidatorTests
{
    private readonly AmountType4Choice_Validator _sut = new();

    [Fact]
    public void InstructedAmountVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.InstructedAmount
        {
            Currency = "USD",
            Amount = 100m,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EquivalentAmountVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.EquivalentAmount
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            CurrencyOfTransfer = "EUR",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EquivalentAmountVariant_PopulatedRegistry_RejectsCurrencyOfTransferNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ActiveOrHistoricCurrencyCode>();
        registry.Add("EUR");
        var sut = new AmountType4Choice_Validator(new ActiveOrHistoricCurrencyCodeValidator(registry));

        var value = new BeneficialStrategies.Iso20022.Choices.AmountType4Choice.EquivalentAmount
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            CurrencyOfTransfer = "ZZZ",
        };
        var result = sut.Validate(value);
        Assert.False(result.IsValid);
    }
}
