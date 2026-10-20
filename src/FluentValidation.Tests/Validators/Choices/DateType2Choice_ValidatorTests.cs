// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DateType2Choice_ValidatorTests
{
    private readonly DateType2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.DateType2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.DateType2Choice.Code { Value = ExternalDateType1Code.InvoiceDate };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.DateType2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.DateType2Choice.Proprietary { Value = "MYDATETYPE" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
