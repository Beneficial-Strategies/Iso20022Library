// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the number of voting rights cast to a resolution.
/// </summary>
[IsoId("_T5VABdp-Ed-ak6NoX_4Aeg_-129713306")]
[DisplayName("Vote")]
public record Vote5
{
    /// <summary>
    /// Numbering of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_T5VABtp-Ed-ak6NoX_4Aeg_-129712899")]
    [DisplayName("Issuer Label")]
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text IssuerLabel { get; init; }

    /// <summary>
    /// Specifies whether a resolution is accepted or not.
    /// </summary>
    [IsoId("_T5VAB9p-Ed-ak6NoX_4Aeg_-129712548")]
    [DisplayName("Accepted")]
    [IsoXmlTag("Accptd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Accepted { get; init; }

    /// <summary>
    /// Number of votes in favour of one resolution.
    /// </summary>
    [IsoId("_T5VACNp-Ed-ak6NoX_4Aeg_-129712633")]
    [DisplayName("For")]
    [IsoXmlTag("For")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? For { get; init; }

    /// <summary>
    /// Number of votes against one resolution.
    /// </summary>
    [IsoId("_T5VACdp-Ed-ak6NoX_4Aeg_-129712608")]
    [DisplayName("Against")]
    [IsoXmlTag("Agnst")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Against { get; init; }

    /// <summary>
    /// Number of votes expressed as abstain.
    /// </summary>
    [IsoId("_T5VACtp-Ed-ak6NoX_4Aeg_-129712591")]
    [DisplayName("Abstain")]
    [IsoXmlTag("Abstn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Abstain { get; init; }

    /// <summary>
    /// Total votes withheld, eg in the case where a shareholder wishes not to endorse the election of a board member.
    /// </summary>
    [IsoId("_T5exANp-Ed-ak6NoX_4Aeg_-129712573")]
    [DisplayName("Withhold")]
    [IsoXmlTag("Wthhld")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Withhold { get; init; }

    /// <summary>
    /// Number of votes for which no action has been taken.
    /// </summary>
    [IsoId("_T5exAdp-Ed-ak6NoX_4Aeg_223997005")]
    [DisplayName("No Action")]
    [IsoXmlTag("NoActn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NoAction { get; init; }
}
