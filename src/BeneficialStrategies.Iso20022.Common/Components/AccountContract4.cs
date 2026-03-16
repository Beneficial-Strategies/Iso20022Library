// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies target dates dates related to account opening and closing.
/// </summary>
[IsoId("_UkGbYdp-Ed-ak6NoX_4Aeg_197946061")]
[DisplayName("Account Contract")]
public record AccountContract4
{
    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlQNp-Ed-ak6NoX_4Aeg_-621007620")]
    [DisplayName("Target Closing Date")]
    [IsoXmlTag("TrgtClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TargetClosingDate { get; init; }

    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    [IsoId("_UkPlQdp-Ed-ak6NoX_4Aeg_-1796198645")]
    [DisplayName("Urgency Flag")]
    [IsoXmlTag("UrgcyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? UrgencyFlag { get; init; }

    /// <summary>
    /// Indicates removal of the account. After removal, an account will not appear anymore in reports.
    /// </summary>
    [IsoId("_UkPlQtp-Ed-ak6NoX_4Aeg_-1964414832")]
    [DisplayName("Removal Indicator")]
    [IsoXmlTag("RmvlInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RemovalIndicator { get; init; }
}
