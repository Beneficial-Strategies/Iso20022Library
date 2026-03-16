// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Trade Data44.
/// </summary>
[IsoId("_GCpiQUjrEe-KhcStGV4xTg")]
[DisplayName("Trade Data44")]
public record TradeData44
{
    /// <summary>
    /// Current Settlement Date.
    /// </summary>
    [DisplayName("Current Settlement Date")]
    [IsoXmlTag("CurSttlmDt")]
    public IsoISODate? CurrentSettlementDate { get; init; }

    /// <summary>
    /// Current Status Date Time.
    /// </summary>
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    public IsoISODateTime? CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Matching System Matched Side Reference.
    /// </summary>
    [DisplayName("Matching System Matched Side Reference")]
    [IsoXmlTag("MtchgSysMtchdSdRef")]
    public IsoMax35Text? MatchingSystemMatchedSideReference { get; init; }

    /// <summary>
    /// Matching System Matching Reference.
    /// </summary>
    [DisplayName("Matching System Matching Reference")]
    [IsoXmlTag("MtchgSysMtchgRef")]
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; }

    /// <summary>
    /// Matching System Unique Reference.
    /// </summary>
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; }

    /// <summary>
    /// New Settlement Date.
    /// </summary>
    [DisplayName("New Settlement Date")]
    [IsoXmlTag("NewSttlmDt")]
    public IsoISODate? NewSettlementDate { get; init; }

    /// <summary>
    /// Originator Reference.
    /// </summary>
    [DisplayName("Originator Reference")]
    [IsoXmlTag("OrgtrRef")]
    public IsoMax35Text? OriginatorReference { get; init; }

    /// <summary>
    /// Product Type.
    /// </summary>
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public IsoMax35Text? ProductType { get; init; }

    /// <summary>
    /// Regulatory Reporting.
    /// </summary>
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting8? RegulatoryReporting { get; init; }

    /// <summary>
    /// Settlement Session Identifier.
    /// </summary>
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; }
}
