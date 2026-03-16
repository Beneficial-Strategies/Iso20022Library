// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on currency exchange information or on a business error.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError2Choice.BusinessError))]
    [KnownType(typeof(ExchangeRateReportOrError2Choice.CurrencyExchange))]
    [JsonDerivedType(
        typeof(ExchangeRateReportOrError2Choice.BusinessError),
        nameof(ExchangeRateReportOrError2Choice.BusinessError)
    )]
    [JsonDerivedType(
        typeof(ExchangeRateReportOrError2Choice.CurrencyExchange),
        nameof(ExchangeRateReportOrError2Choice.CurrencyExchange)
    )]
    [IsoId("_77TPQaMgEeCJ6YNENx4h-w_315557702")]
    [DisplayName("Exchange Rate Report Or Error 2 Choice")]
    public abstract record ExchangeRateReportOrError2Choice_ { }
}
