// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// New trading system related data report.
/// </summary>
[IsoId("_dVjE0GFdEfC-1NkZ9TkdKA")]
[DisplayName("Trading System Report1")]
public record TradingSystemReport1
{
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_hdvCMGFdEfC-1NkZ9TkdKA")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public IsoMax140Text? ReportIdentification { get; init; }

    /// <summary>
    /// Information about the status of a trading system.
    /// </summary>
    [IsoId("_jguNoGFdEfC-1NkZ9TkdKA")]
    [DisplayName("Trading System")]
    [IsoXmlTag("TradgSys")]
    [MinLength(1)]
    public ValueList<TradingSystemData1> TradingSystem { get; init; } = [];
}
