// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the identification type.
/// </summary>
[IsoId("_Uu1EoNp-Ed-ak6NoX_4Aeg_616925675")]
[DisplayName("Identification Type")]
public record IdentificationType1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_Uu1Eodp-Ed-ak6NoX_4Aeg_668645812")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required PersonIdentificationType1Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of identification.
    /// </summary>
    [IsoId("_Uu1Eotp-Ed-ak6NoX_4Aeg_675108040")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
