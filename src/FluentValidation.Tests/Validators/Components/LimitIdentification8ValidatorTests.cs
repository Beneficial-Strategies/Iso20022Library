// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class LimitIdentification8ValidatorTests
{
    private readonly LimitIdentification8Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.ILimitType1Choice ValidType() =>
        IsoDataFactory.Make<Choices.LimitType1Choice.ICode>(b => b
            .Set(x => x.Value).To(LimitType3Code.Bilateral));

    private static ILimitIdentification8 ValidMessage() => IsoDataFactory.Make<ILimitIdentification8>(b => b
        .Set(x => x.Type).To(ValidType()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var agent = IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountIdentification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000")))
            .Set(x => x.AccountOwner).To(agent)
            .Set(x => x.BilateralLimitCounterpartyIdentification).To(agent)
            .Set(x => x.SystemIdentification).To(IsoDataFactory.Make<Choices.SystemIdentification2Choice.ICountry>(b2 => b2
                .Set(x2 => x2.Value).To("DE"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
