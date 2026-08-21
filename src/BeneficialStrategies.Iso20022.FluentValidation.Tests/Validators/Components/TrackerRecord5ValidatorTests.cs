// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TrackerRecord5ValidatorTests
{
    private readonly TrackerRecord5Validator _sut = new();

    private static TrackerRecord5 ValidMessage() =>
        new()
        {
            Agent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
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
            ChargeBearer = ChargeBearerType1Code.BorneByDebtor,
            ChargesAmount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m },
            ExchangeRateData = new CurrencyExchange13
            {
                SourceCurrency = "USD",
                TargetCurrency = "EUR",
                ExchangeRate = 0.9m,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
