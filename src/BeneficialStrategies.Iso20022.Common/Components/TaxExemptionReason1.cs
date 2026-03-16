// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the tax exemption reason.
/// </summary>
[IsoId("_VSvC-9p-Ed-ak6NoX_4Aeg_1927276750")]
[DisplayName("Tax Exemption Reason")]
public record TaxExemptionReason1
{
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VSvC_Np-Ed-ak6NoX_4Aeg_1975300897")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TaxExemptReason2Code Structured { get; init; }

    /// <summary>
    /// Additional information about the type of tax.
    /// </summary>
    [IsoId("_VSvC_dp-Ed-ak6NoX_4Aeg_1975301750")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
