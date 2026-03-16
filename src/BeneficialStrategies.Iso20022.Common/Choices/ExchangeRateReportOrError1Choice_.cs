// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide information on static data maintained by the transaction administrator and related to currency exchange details as maintained for system operations by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError1Choice.CurrencyExchangeReport))]
    [KnownType(typeof(ExchangeRateReportOrError1Choice.OperationalError))]
    [JsonDerivedType(
        typeof(ExchangeRateReportOrError1Choice.CurrencyExchangeReport),
        nameof(ExchangeRateReportOrError1Choice.CurrencyExchangeReport)
    )]
    [JsonDerivedType(
        typeof(ExchangeRateReportOrError1Choice.OperationalError),
        nameof(ExchangeRateReportOrError1Choice.OperationalError)
    )]
    [IsoId("_77JeQ6MgEeCJ6YNENx4h-w_1304764556")]
    [DisplayName("Exchange Rate Report Or Error 1 Choice")]
    public abstract record ExchangeRateReportOrError1Choice_ { }
}
