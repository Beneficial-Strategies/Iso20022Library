// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of a new trade transaction report.
/// </summary>
[IsoId("_VrZzEw1KEeqV4s5SpzR1dQ")]
[DisplayName("Trade New Transaction")]
public record TradeNewTransaction10
{
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_VsJZ4Q1KEeqV4s5SpzR1dQ")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CounterpartySpecificData24> CounterpartySpecificData { get; init; } = [];

    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    [IsoId("_VsJZ4w1KEeqV4s5SpzR1dQ")]
    [DisplayName("Common Trade Data")]
    [IsoXmlTag("CmonTradData")]
    public required CommonTradeDataReport38 CommonTradeData { get; init; }

    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    [IsoId("_VsJZ5Q1KEeqV4s5SpzR1dQ")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public TechnicalAttributes1? TechnicalAttributes { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_VsJZ5w1KEeqV4s5SpzR1dQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
