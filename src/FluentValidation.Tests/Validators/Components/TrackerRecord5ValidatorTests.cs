// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TrackerRecord5ValidatorTests
{
    private readonly TrackerRecord5Validator _sut = new();

    private static ITrackerRecord5 ValidMessage() =>
        IsoDataFactory.Make<ITrackerRecord5>(b => b
            .Set(x => x.Agent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargeBearer).To(ChargeBearerType1Code.BorneByDebtor)
            .Set(x => x.ChargesAmount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m })
            .Set(x => x.ExchangeRateData).To(IsoDataFactory.Make<ICurrencyExchange13>(b2 => b2
                .Set(x2 => x2.SourceCurrency).To("USD")
                .Set(x2 => x2.TargetCurrency).To("EUR")
                .Set(x2 => x2.ExchangeRate).To(0.9m))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
