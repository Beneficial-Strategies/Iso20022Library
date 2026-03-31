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
[IsoId("_SvV_8gEcEeCQm6a_G2yO_w_2088147903")]
[DisplayName("Trade Data")]
public record TradeData3
{
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    [IsoId("_SvV_8wEcEeCQm6a_G2yO_w_1091075550")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; }

    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    [IsoId("_SvV_9AEcEeCQm6a_G2yO_w_-206207174")]
    [DisplayName("Matching System Matching Reference")]
    [IsoXmlTag("MtchgSysMtchgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; }

    /// <summary>
    /// Party that assigned the status to the trade.
    /// </summary>
    [IsoId("_SvV_9QEcEeCQm6a_G2yO_w_977236484")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the new status of the trade.
    /// </summary>
    [IsoId("_SvV_9gEcEeCQm6a_G2yO_w_-499046731")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required Status5Choice_ CurrentStatus { get; init; }

    /// <summary>
    /// Additional information about the current status of the trade.
    /// </summary>
    [IsoId("_SvV_9wEcEeCQm6a_G2yO_w_-1016908222")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Specifies the date and time at which the current status was assigned.
    /// </summary>
    [IsoId("_SvV_-AEcEeCQm6a_G2yO_w_-2013980575")]
    [DisplayName("Current Status Date Time")]
    [IsoXmlTag("CurStsDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CurrentStatusDateTime { get; init; }

    /// <summary>
    /// Specifies the previous status of the trade.
    /// </summary>
    [IsoId("_SvV_-QEcEeCQm6a_G2yO_w_-1473318800")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public Status5Choice_? PreviousStatus { get; init; }

    /// <summary>
    /// Specifies whether a trade is alleged or not.
    /// </summary>
    [IsoId("_SvV_-gEcEeCQm6a_G2yO_w_-633353166")]
    [DisplayName("Alleged Trade")]
    [IsoXmlTag("AllgdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AllegedTrade { get; init; }

    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_SvV_-wEcEeCQm6a_G2yO_w_-1846645819")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PreviousStatusSubType { get; init; }
}
