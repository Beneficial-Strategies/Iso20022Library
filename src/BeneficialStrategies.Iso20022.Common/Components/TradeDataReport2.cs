// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Data Report2.
/// </summary>
[IsoId("_isOssFvBEe-c2-hex9EchA")]
[DisplayName("Trade Data Report2")]
public record TradeDataReport2
{
    /// <summary>
    /// Linked Report Identification.
    /// </summary>
    [DisplayName("Linked Report Identification")]
    [IsoXmlTag("LkdRptId")]
    public IsoMax35Text? LinkedReportIdentification { get; init; }

    /// <summary>
    /// Trade Data.
    /// </summary>
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public ValueList<TradeData44> TradeData { get; init; } = [];
}
