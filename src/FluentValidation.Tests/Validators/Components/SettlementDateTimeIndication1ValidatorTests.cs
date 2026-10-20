// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SettlementDateTimeIndication1ValidatorTests
{
    private readonly SettlementDateTimeIndication1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ISettlementDateTimeIndication1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFieldsPresent_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<ISettlementDateTimeIndication1>(b => b
            .Set(x => x.DebitDateTime).To(new DateTime(2026, 1, 1, 9, 0, 0))
            .Set(x => x.CreditDateTime).To(new DateTime(2026, 1, 1, 9, 5, 0)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
