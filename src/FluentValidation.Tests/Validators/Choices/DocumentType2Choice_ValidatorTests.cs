// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DocumentType2Choice_ValidatorTests
{
    private readonly DocumentType2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IDocumentType2Choice choice =
            IsoDataFactory.Make<Choices.DocumentType2Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalDocumentType1Code.CommercialInvoice));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IDocumentType2Choice choice =
            IsoDataFactory.Make<Choices.DocumentType2Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYDOCTYPE"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
