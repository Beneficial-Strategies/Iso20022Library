// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the charge basis.
/// </summary>
[IsoId("_VMLvAtp-Ed-ak6NoX_4Aeg_-1276327629")]
[DisplayName("Calculation Basis")]
public record CalculationBasis1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VMLvA9p-Ed-ak6NoX_4Aeg_-1188591322")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required CalculationBasis1Code Structured { get; init; }

    /// <summary>
    /// Additional information about the calculation basis.
    /// </summary>
    [IsoId("_VMLvBNp-Ed-ak6NoX_4Aeg_-1188591227")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
