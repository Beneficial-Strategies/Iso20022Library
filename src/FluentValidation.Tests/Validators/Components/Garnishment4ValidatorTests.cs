// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Garnishment4ValidatorTests
{
    private readonly Garnishment4Validator _sut = new();

    private static IGarnishment4 ValidMessage() =>
        IsoDataFactory.Make<IGarnishment4>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<IGarnishmentType1>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.GarnishmentType1Choice.IProprietary>(b3 => b3
                    .Set(x3 => x3.Value).To("MYGARNISHMENT"))))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Date).To(new DateOnly(2026, 1, 1))
            .Set(x => x.EmployeeTerminationIndicator).To(false)
            .Set(x => x.FamilyMedicalInsuranceIndicator).To(true)
            .Set(x => x.Garnishee).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Garnishee Co")))
            .Set(x => x.GarnishmentAdministrator).To(IsoDataFactory.Make<IPartyIdentification272>(b2 => b2
                .Set(x2 => x2.Name).To("Admin Co")))
            .Set(x => x.ReferenceNumber).To("REF-001")
            .Set(x => x.RemittedAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m }));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
