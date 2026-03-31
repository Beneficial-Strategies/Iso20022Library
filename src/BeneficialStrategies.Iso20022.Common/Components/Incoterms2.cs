// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the applicable Incoterm and associated location.
/// </summary>
[IsoId("_Sr_qOdp-Ed-ak6NoX_4Aeg_-76606103")]
[DisplayName("Incoterms")]
public record Incoterms2
{
    /// <summary>
    /// Specifies the applicable Incoterm by means of a code.
    /// </summary>
    [IsoId("_Sr_qOtp-Ed-ak6NoX_4Aeg_-33745991")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required Incoterms1Code Code { get; init; }

    /// <summary>
    /// Specifies Incoterm not present in code list.
    /// </summary>
    [IsoId("_Sr_qO9p-Ed-ak6NoX_4Aeg_-33745913")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Other { get; init; }

    /// <summary>
    /// Location where the Incoterms are actioned.
    /// </summary>
    [IsoId("_SsJbMNp-Ed-ak6NoX_4Aeg_-47973709")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Location { get; init; }
}
