// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a valuation update report on a trade position.
/// </summary>
[IsoId("_iertsQ1JEeqV4s5SpzR1dQ")]
[DisplayName("Trade Position Valuation Update")]
public record TradePositionValuationUpdate5
{
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_ifb7oQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartySpecificData23> CounterpartySpecificData { get; init; } = [];

    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    [IsoId("_ifb7ow1JEeqV4s5SpzR1dQ")]
    [DisplayName("Common Trade Data")]
    [IsoXmlTag("CmonTradData")]
    public CommonTradeDataReport36? CommonTradeData { get; init; }

    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_ifb7pQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes1? TechnicalAttributes { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ifb7pw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
