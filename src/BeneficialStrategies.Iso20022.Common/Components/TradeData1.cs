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
[IsoId("_UscfANp-Ed-ak6NoX_4Aeg_1902245509")]
[DisplayName("Trade Data")]
public record TradeData1
{
    /// <summary>
    /// Refers to the identification of a notification.
    /// </summary>
    [IsoId("_UscfAdp-Ed-ak6NoX_4Aeg_1953965551")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; }

    /// <summary>
    /// Reference to the unique identification assigned to a trade by a central matching system.
    /// </summary>
    [IsoId("_UscfAtp-Ed-ak6NoX_4Aeg_1954886301")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; }

    /// <summary>
    /// Identifies the party which assigned a status to a treasury trade.
    /// </summary>
    [IsoId("_UscfA9p-Ed-ak6NoX_4Aeg_502075221")]
    [DisplayName("Status Originator")]
    [IsoXmlTag("StsOrgtr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusOriginator { get; init; }

    /// <summary>
    /// Specifies the new status of a trade.
    /// </summary>
    [IsoId("_UscfBNp-Ed-ak6NoX_4Aeg_1546701058")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required TradeStatus1Code CurrentStatus { get; init; }

    /// <summary>
    /// Description of the status of a trade when no coded form is available.
    /// </summary>
    [IsoId("_UscfBdp-Ed-ak6NoX_4Aeg_2119516029")]
    [DisplayName("Extended Current Status")]
    [IsoXmlTag("XtndedCurSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedCurrentStatus { get; init; }

    /// <summary>
    /// Additional information on the current status of a trade in a central system.
    /// </summary>
    [IsoId("_UscfBtp-Ed-ak6NoX_4Aeg_1103289655")]
    [DisplayName("Current Status Sub Type")]
    [IsoXmlTag("CurStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CurrentStatusSubType { get; init; }

    /// <summary>
    /// Specifies the time at which the current status was assigned.
    /// </summary>
    [IsoId("_UscfB9p-Ed-ak6NoX_4Aeg_1922452873")]
    [DisplayName("Current Status Time")]
    [IsoXmlTag("CurStsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? CurrentStatusTime { get; init; }

    /// <summary>
    /// Specifies the previous status of a trade.
    /// </summary>
    [IsoId("_UscfCNp-Ed-ak6NoX_4Aeg_1145893613")]
    [DisplayName("Previous Status")]
    [IsoXmlTag("PrvsSts")]
    public TradeStatus1Code? PreviousStatus { get; init; }

    /// <summary>
    /// Description of the status of a trade when no coded form is available.
    /// </summary>
    [IsoId("_UscfCdp-Ed-ak6NoX_4Aeg_942747498")]
    [DisplayName("Extended Previous Status")]
    [IsoXmlTag("XtndedPrvsSts")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedPreviousStatus { get; init; }

    /// <summary>
    /// Additional information on the previous status of a trade in a central system.
    /// </summary>
    [IsoId("_Uslo8Np-Ed-ak6NoX_4Aeg_-1628157965")]
    [DisplayName("Previous Status Sub Type")]
    [IsoXmlTag("PrvsStsSubTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? PreviousStatusSubType { get; init; }

    /// <summary>
    /// Specifies the time at which the previous status was assigned.
    /// </summary>
    [IsoId("_Uslo8dp-Ed-ak6NoX_4Aeg_-1473004903")]
    [DisplayName("Previous Status Time")]
    [IsoXmlTag("PrvsStsTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? PreviousStatusTime { get; init; }

    /// <summary>
    /// Specifies the product for which the status of the confirmation is reported.
    /// </summary>
    [IsoId("_Uslo8tp-Ed-ak6NoX_4Aeg_1820316906")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4AlphaNumericText? ProductType { get; init; }
}
