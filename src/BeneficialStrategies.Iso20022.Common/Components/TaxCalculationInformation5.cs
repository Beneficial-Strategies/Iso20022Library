// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information used to calculate the tax.
/// </summary>
[IsoId("_SlvRMNp-Ed-ak6NoX_4Aeg_500717863")]
[DisplayName("Tax Calculation Information")]
public record TaxCalculationInformation5
{
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_SlvRMdp-Ed-ak6NoX_4Aeg_500717881")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public TaxationBasis2Code? Basis { get; init; }

    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_SlvRMtp-Ed-ak6NoX_4Aeg_1085303745")]
    [DisplayName("Extended Basis")]
    [IsoXmlTag("XtndedBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedBasis { get; init; }
}
