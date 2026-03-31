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
[IsoId("_kT3MEaAhEea9x5aZm6UTkw")]
[DisplayName("Trade Data")]
public record TradeData16
{
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_kgrgE6AhEea9x5aZm6UTkw")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; }

    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_kgrgFaAhEea9x5aZm6UTkw")]
    [DisplayName("Matching System Matching Reference")]
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; }

    /// <summary>
    /// Unique reference from the central settlement system that allows the removal of alleged trades once the matched status notification for the matching side has been received.
    /// </summary>
    [IsoId("_kgrgF6AhEea9x5aZm6UTkw")]
    [DisplayName("Matching System Matched Side Reference")]
    [IsoXmlTag("MtchgSysMtchdSdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchedSideReference { get; init; }

    /// <summary>
    /// Party that assigned the status to the trade.
    /// </summary>
    [IsoId("_kgrgGaAhEea9x5aZm6UTkw")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the new status of a trade.
    /// </summary>
    [IsoId("_rN_FkaAhEea9x5aZm6UTkw")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required StatusAndSubStatus2 CurrentStatus { get; init; }

    /// <summary>
    /// Additional information on the current status of a trade in a central system.
    /// </summary>
    [IsoId("_xmI6caAhEea9x5aZm6UTkw")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    public StatusSubType2Code? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    [IsoId("_kgrgH6AhEea9x5aZm6UTkw")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_4RzhMaAhEea9x5aZm6UTkw")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status28Choice_? PreviousStatus { get; init; }

    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("__TrBcaAhEea9x5aZm6UTkw")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    public StatusSubType2Code? PreviousStatusSubType { get; init; }
}
