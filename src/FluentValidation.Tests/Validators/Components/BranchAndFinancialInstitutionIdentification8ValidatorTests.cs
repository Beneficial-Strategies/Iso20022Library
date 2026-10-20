// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class BranchAndFinancialInstitutionIdentification8ValidatorTests
{
    private readonly BranchAndFinancialInstitutionIdentification8Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidMessage() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void BranchIdentification_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.BranchIdentification).To(IsoDataFactory.Make<IBranchData5>(b2 => b2
            .Set(x2 => x2.Name).To("Main Branch"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
