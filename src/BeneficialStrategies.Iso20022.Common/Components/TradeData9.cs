// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
[IsoId("_c_2KcR3dEeKXIbeXfdPzuw")]
[DisplayName("Trade Data")]
public record TradeData9
{
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_dLD79R3dEeKXIbeXfdPzuw")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; }

    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_dLD7-R3dEeKXIbeXfdPzuw")]
    [DisplayName("Matching System Matching Reference")]
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; }

    /// <summary>
    /// Unique reference from the central settlement system that allows the removal of alleged trades once the matched status notification for the matching side has been received.
    /// </summary>
    [IsoId("_ZSc515UJEeKShbaq9ixROw")]
    [DisplayName("Matching System Matched Side Reference")]
    [IsoXmlTag("MtchgSysMtchdSdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchedSideReference { get; init; }

    /// <summary>
    /// Party that assigned the status to the trade.
    /// </summary>
    [IsoId("_dLD7_R3dEeKXIbeXfdPzuw")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the new status of the trade.
    /// </summary>
    [IsoId("_dLD8AR3dEeKXIbeXfdPzuw")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required StatusAndSubStatus1 CurrentStatus { get; init; }

    /// <summary>
    /// Additional information about the current status of the trade.
    /// </summary>
    [IsoId("_dLD8BR3dEeKXIbeXfdPzuw")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    public StatusSubType1Code? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    [IsoId("_dLD8CR3dEeKXIbeXfdPzuw")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Specifies the previous status of the trade.
    /// </summary>
    [IsoId("_dLD8DR3dEeKXIbeXfdPzuw")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status5Choice_? PreviousStatus { get; init; }

    /// <summary>
    /// Specifies whether a trade is alleged or not.
    /// </summary>
    [IsoId("_dLD8ER3dEeKXIbeXfdPzuw")]
    [DisplayName("Alleged Trade")]
    [IsoXmlTag("AllgdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AllegedTrade { get; init; }

    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_dLD8FR3dEeKXIbeXfdPzuw")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    public StatusSubType1Code? PreviousStatusSubType { get; init; }
}
