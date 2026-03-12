// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide information on static data maintained by the transaction administrator and related to currency exchange details as maintained for system operations by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError3Choice.CurrencyExchangeReport))]
    [KnownType(typeof(ExchangeRateReportOrError3Choice.OperationalError))]
    [JsonDerivedType(typeof(ExchangeRateReportOrError3Choice.CurrencyExchangeReport),nameof(ExchangeRateReportOrError3Choice.CurrencyExchangeReport))]
    [JsonDerivedType(typeof(ExchangeRateReportOrError3Choice.OperationalError),nameof(ExchangeRateReportOrError3Choice.OperationalError))]
    [IsoId("_MkkyYNfiEeqoweZZxm4TPQ")]
    [DisplayName("Exchange Rate Report Or Error 3 Choice")]
    public abstract partial record ExchangeRateReportOrError3Choice_
    {
    }
}
