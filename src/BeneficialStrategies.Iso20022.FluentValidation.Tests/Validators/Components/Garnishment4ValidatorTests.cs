// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Garnishment4ValidatorTests
{
    private readonly Garnishment4Validator _sut = new();

    private static Garnishment4 ValidMessage() =>
        new()
        {
            Type = new GarnishmentType1
            {
                CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice.Proprietary
                {
                    Value = "MYGARNISHMENT",
                },
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Date = new DateOnly(2026, 1, 1),
            EmployeeTerminationIndicator = false,
            FamilyMedicalInsuranceIndicator = true,
            Garnishee = new PartyIdentification272 { Name = "Garnishee Co" },
            GarnishmentAdministrator = new PartyIdentification272 { Name = "Admin Co" },
            ReferenceNumber = "REF-001",
            RemittedAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
