// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CategoryPurpose1Choice_ValidatorTests
{
    private readonly CategoryPurpose1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice.Code { Value = ExternalCategoryPurpose1Code.BonusPayment };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice.Proprietary { Value = "MYCAT" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
