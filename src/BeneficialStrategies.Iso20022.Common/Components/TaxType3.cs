// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the tax type.
/// </summary>
[IsoId("_VR_cE9p-Ed-ak6NoX_4Aeg_-1494522709")]
[DisplayName("Tax Type")]
public record TaxType3
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VR_cFNp-Ed-ak6NoX_4Aeg_-1446498286")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TaxType6Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VR_cFdp-Ed-ak6NoX_4Aeg_-1446498269")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
