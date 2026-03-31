// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade State Report23.
/// </summary>
[IsoId("_5xXlsZBBEe6Ojt1b3tfu9Q")]
[DisplayName("Trade State Report23")]
public record TradeStateReport23
{
    /// <summary>
    /// Common Trade Data.
    /// </summary>
    [DisplayName("Common Trade Data")]
    [IsoXmlTag("CmonTradData")]
    public required CommonTradeDataReport72 CommonTradeData { get; init; }

    /// <summary>
    /// Counterparty Specific Data.
    /// </summary>
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    public required CounterpartySpecificData36 CounterpartySpecificData { get; init; }

    /// <summary>
    /// Public Dissemination Data.
    /// </summary>
    [DisplayName("Public Dissemination Data")]
    [IsoXmlTag("PblcDssmntnData")]
    public DisseminationData1? PublicDisseminationData { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Technical Attributes.
    /// </summary>
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes5? TechnicalAttributes { get; init; }
}
