// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies target and actual dates dates related to account opening and closing.
/// </summary>
[IsoId("_UkPlQ9p-Ed-ak6NoX_4Aeg_1731275671")]
[DisplayName("Account Contract")]
public record AccountContract3
{
    /// <summary>
    /// Date on which the account and related basic services are expected to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlRNp-Ed-ak6NoX_4Aeg_1617436605")]
    [DisplayName("Target Go Live Date")]
    [IsoXmlTag("TrgtGoLiveDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TargetGoLiveDate { get; init; }

    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlRdp-Ed-ak6NoX_4Aeg_912321990")]
    [DisplayName("Target Closing Date")]
    [IsoXmlTag("TrgtClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TargetClosingDate { get; init; }

    /// <summary>
    /// Date on which the account and related basic services are effectively operational for the account owner.
    /// </summary>
    [IsoId("_UkPlRtp-Ed-ak6NoX_4Aeg_-1950335857")]
    [DisplayName("Go Live Date")]
    [IsoXmlTag("GoLiveDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? GoLiveDate { get; init; }

    /// <summary>
    /// Date on which the account and related services cease effectively to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlR9p-Ed-ak6NoX_4Aeg_-1886056251")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ClosingDate { get; init; }

    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    [IsoId("_UkZWQNp-Ed-ak6NoX_4Aeg_1233720020")]
    [DisplayName("Urgency Flag")]
    [IsoXmlTag("UrgcyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? UrgencyFlag { get; init; }

    /// <summary>
    /// Indicates removal of the account. After removal, an account will not appear anymore in reports.
    /// </summary>
    [IsoId("_UkZWQdp-Ed-ak6NoX_4Aeg_-1501580453")]
    [DisplayName("Removal Indicator")]
    [IsoXmlTag("RmvlInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RemovalIndicator { get; init; }
}
