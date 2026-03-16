// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status of a trade in a central settlement system.
/// </summary>
[IsoId("_Q7Ma8dp-Ed-ak6NoX_4Aeg_-931990425")]
[DisplayName("Trade Status")]
public record TradeStatus1
{
    /// <summary>
    /// Specifies whether a trade is alleged or not.
    /// </summary>
    [IsoId("_Q7Ma8tp-Ed-ak6NoX_4Aeg_2061891848")]
    [DisplayName("Alleged Trade")]
    [IsoXmlTag("AllgdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AllegedTrade { get; init; }

    /// <summary>
    /// Reference to the unique identification assigned to a trade by a central matching system.
    /// </summary>
    [IsoId("_Q7Ma89p-Ed-ak6NoX_4Aeg_2043342151")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; }

    /// <summary>
    /// Specifies the status of a trade.
    /// </summary>
    [IsoId("_Q7Ma9Np-Ed-ak6NoX_4Aeg_809836093")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public TradeStatus1Code? Status { get; init; }

    /// <summary>
    /// Description of the status of a trade when no coded form is available.
    /// </summary>
    [IsoId("_Q7Ma9dp-Ed-ak6NoX_4Aeg_1685557048")]
    [DisplayName("Extended Status")]
    [IsoXmlTag("XtndedSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedStatus { get; init; }

    /// <summary>
    /// Additional information on the status of a trade in a central system.
    /// </summary>
    [IsoId("_Q7Ma9tp-Ed-ak6NoX_4Aeg_824610615")]
    [DisplayName("Status Sub Type")]
    [IsoXmlTag("StsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? StatusSubType { get; init; }

    /// <summary>
    /// Specifies the time at which a status was assigned.
    /// </summary>
    [IsoId("_Q7Ma99p-Ed-ak6NoX_4Aeg_1765636507")]
    [DisplayName("Status Time")]
    [IsoXmlTag("StsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StatusTime { get; init; }

    /// <summary>
    /// Identifies the party which assigned a status to a treasury trade.
    /// </summary>
    [IsoId("_Q7Ma-Np-Ed-ak6NoX_4Aeg_1712995906")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; }
}
