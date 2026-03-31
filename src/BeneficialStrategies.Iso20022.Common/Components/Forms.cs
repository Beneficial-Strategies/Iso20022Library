// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Processing characteristics linked to the instrument, ie, not to the market.
/// </summary>
[IsoId("_UBYIxdp-Ed-ak6NoX_4Aeg_-1907682961")]
[DisplayName("Forms")]
public record Forms
{
    /// <summary>
    /// Physical application form is required.
    /// </summary>
    [IsoId("_UBYIxtp-Ed-ak6NoX_4Aeg_-1148549428")]
    [DisplayName("Application Form")]
    [IsoXmlTag("ApplForm")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ApplicationForm { get; init; }

    /// <summary>
    /// Type of signature.
    /// </summary>
    [IsoId("_UBYIx9p-Ed-ak6NoX_4Aeg_-790353691")]
    [DisplayName("Signature Type")]
    [IsoXmlTag("SgntrTp")]
    public required SignatureType1Code SignatureType { get; init; }
}
