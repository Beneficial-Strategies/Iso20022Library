// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StandingOrderIdentification9ValidatorTests
{
    private readonly StandingOrderIdentification9Validator _sut = new();

    private static ICashAccount40 ValidAccount() =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));

    private static IStandingOrderIdentification9 ValidMessage() => IsoDataFactory.Make<IStandingOrderIdentification9>(b => b
        .Set(x => x.Account).To(ValidAccount()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AccountOwner_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountOwner).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
