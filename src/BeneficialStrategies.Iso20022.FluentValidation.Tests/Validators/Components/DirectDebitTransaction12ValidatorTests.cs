// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DirectDebitTransaction12ValidatorTests
{
    private readonly DirectDebitTransaction12Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new DirectDebitTransaction12()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new DirectDebitTransaction12
        {
            CreditorSchemeIdentification = new PartyIdentification272 { Name = "Creditor Scheme Co" },
            MandateRelatedInformation = new MandateRelatedInformation16(),
            PreNotificationDate = new DateOnly(2026, 1, 1),
            PreNotificationIdentification = "PRENOTIF-001",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
