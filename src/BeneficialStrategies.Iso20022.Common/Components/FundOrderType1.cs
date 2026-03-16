// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the fund order type.
/// </summary>
[IsoId("_VA2oydp-Ed-ak6NoX_4Aeg_-1845301749")]
[DisplayName("Fund Order Type")]
public record FundOrderType1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VA2oytp-Ed-ak6NoX_4Aeg_-1797278533")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required FundOrderType2Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of identification.
    /// </summary>
    [IsoId("_VA2oy9p-Ed-ak6NoX_4Aeg_-1756644789")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
