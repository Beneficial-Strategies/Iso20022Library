// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a valuation update report on a trade transaction.
/// </summary>
[IsoId("_HDsGQQ1LEeqV4s5SpzR1dQ")]
[DisplayName("Trade Transaction Valuation Update")]
public record TradeTransactionValuationUpdate5
{
    /// <summary>
    /// Trade transaction data details.
    /// </summary>
    [IsoId("_HEbGEQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartySpecificData23> CounterpartySpecificData { get; init; } = [];

    /// <summary>
    /// Trade transaction data details.
    /// </summary>
    [IsoId("_HEbGEw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Common Trade Data")]
    [IsoXmlTag("CmonTradData")]
    public CommonTradeDataReport36? CommonTradeData { get; init; }

    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_HEbGFQ1LEeqV4s5SpzR1dQ")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes1? TechnicalAttributes { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_HEbGFw1LEeqV4s5SpzR1dQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
