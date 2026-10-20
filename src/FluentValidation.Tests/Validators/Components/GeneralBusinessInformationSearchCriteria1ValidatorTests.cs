// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GeneralBusinessInformationSearchCriteria1ValidatorTests
{
    private readonly GeneralBusinessInformationSearchCriteria1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IGeneralBusinessInformationSearchCriteria1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IGeneralBusinessInformationSearchCriteria1>(b => b
            .Set(x => x.Reference).To(["REF-001"])
            .Set(x => x.Subject).To([IsoDataFactory.Make<Choices.CharacterSearch1Choice.IEqual>(b2 => b2
                .Set(x2 => x2.Value).To("SUBJECT"))])
            .Set(x => x.Qualifier).To([IsoDataFactory.Make<IInformationQualifierType1>(b2 => b2
                .Set(x2 => x2.IsFormatted).To(true)
                .Set(x2 => x2.Priority).To(Priority1Code.High))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
