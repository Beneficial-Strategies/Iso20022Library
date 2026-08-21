// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ReservationIdentification4ValidatorTests
{
    private readonly ReservationIdentification4Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.ReservationType2Choice_ ValidType() =>
        new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Code
        {
            Value = ExternalReservationType1Code.CashReservation,
        };

    private static ReservationIdentification4 ValidMessage() => new() { Type = ValidType() };

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
            AccountIdentification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
            AccountOwner = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            ReservationIdentification = "RSVN-001",
            SystemIdentification = new BeneficialStrategies.Iso20022.Choices.SystemIdentification2Choice.Country
            {
                Value = "DE",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
