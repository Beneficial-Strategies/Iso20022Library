// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class FinancialInstitutionIdentification23ValidatorTests
{
    private readonly FinancialInstitutionIdentification23Validator _sut = new();

    private static IFinancialInstitutionIdentification23 ValidMessage() => IsoDataFactory.Make<IFinancialInstitutionIdentification23>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ClearingSystemMemberIdentification).To(IsoDataFactory.Make<IClearingSystemMemberIdentification2>(b2 => b2
                .Set(x2 => x2.MemberIdentification).To("MEMBER-001")))
            .Set(x => x.Other).To(IsoDataFactory.Make<IGenericFinancialIdentification1>(b2 => b2
                .Set(x2 => x2.Identification).To("ID-001")))
            .Set(x => x.PostalAddress).To(IsoDataFactory.Make<IPostalAddress27>(b2 => b2
                .Set(x2 => x2.TownName).To("Springfield"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
