// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Data43.
/// </summary>
[IsoId("_8sF6YY-REe6Ojt1b3tfu9Q")]
[DisplayName("Trade Data43")]
public record TradeData43
{
    /// <summary>
    /// Common Trade Data.
    /// </summary>
    [DisplayName("Common Trade Data")]
    [IsoXmlTag("CmonTradData")]
    public required CommonTradeDataReport71 CommonTradeData { get; init; }

    /// <summary>
    /// Counterparty Specific Data.
    /// </summary>
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    public required CounterpartySpecificData36 CounterpartySpecificData { get; init; }

    /// <summary>
    /// Level.
    /// </summary>
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public ModificationLevel1Code? Level { get; init; }

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
