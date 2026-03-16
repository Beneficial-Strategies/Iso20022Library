// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the price type.
/// </summary>
[IsoId("_Vbrjltp-Ed-ak6NoX_4Aeg_931175430")]
[DisplayName("Price Type")]
public record PriceType1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_Vbrjl9p-Ed-ak6NoX_4Aeg_969961407")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TypeOfPrice7Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of charge.
    /// </summary>
    [IsoId("_VbrjmNp-Ed-ak6NoX_4Aeg_969961408")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
