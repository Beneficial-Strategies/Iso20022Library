// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Charges16ValidatorTests
{
    private readonly Charges16Validator _sut = new();

    private static ICharges16 ValidMessage() =>
        IsoDataFactory.Make<ICharges16>(b => b
            .Set(x => x.Agent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m }));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.ChargeType3Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Identification).To("CHG-001"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
