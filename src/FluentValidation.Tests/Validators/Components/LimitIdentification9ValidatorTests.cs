// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class LimitIdentification9ValidatorTests
{
    private readonly LimitIdentification9Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.ILimitType1Choice ValidType() =>
        IsoDataFactory.Make<Choices.LimitType1Choice.ICode>(b => b
            .Set(x => x.Value).To(LimitType3Code.Bilateral));

    private static ILimitIdentification9 ValidMessage() => IsoDataFactory.Make<ILimitIdentification9>(b => b
        .Set(x => x.Type).To(ValidType()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountIdentification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000")))
            .Set(x => x.AccountOwner).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.SystemIdentification).To(IsoDataFactory.Make<Choices.SystemIdentification2Choice.ICountry>(b2 => b2
                .Set(x2 => x2.Value).To("DE"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
