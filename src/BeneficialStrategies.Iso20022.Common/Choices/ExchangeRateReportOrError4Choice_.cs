// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on currency exchange information or on a business error.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError4Choice.BusinessError))]
    [KnownType(typeof(ExchangeRateReportOrError4Choice.CurrencyExchange))]
    [JsonDerivedType(
        typeof(ExchangeRateReportOrError4Choice.BusinessError),
        nameof(ExchangeRateReportOrError4Choice.BusinessError)
    )]
    [JsonDerivedType(
        typeof(ExchangeRateReportOrError4Choice.CurrencyExchange),
        nameof(ExchangeRateReportOrError4Choice.CurrencyExchange)
    )]
    [IsoId("_MobXpdfiEeqoweZZxm4TPQ")]
    [DisplayName("Exchange Rate Report Or Error 4 Choice")]
    public abstract record ExchangeRateReportOrError4Choice_ { }
}
