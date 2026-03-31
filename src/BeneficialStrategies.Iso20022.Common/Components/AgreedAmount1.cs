// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the agreed amount for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_UmCVAtp-Ed-ak6NoX_4Aeg_-442441347")]
[DisplayName("Agreed Amount")]
public record AgreedAmount1
{
    /// <summary>
    /// Provides details about the agreed amount for the variation margin.
    /// </summary>
    [IsoId("_UmCVA9p-Ed-ak6NoX_4Aeg_-885757742")]
    [DisplayName("Variation Margin Amount")]
    [IsoXmlTag("VartnMrgnAmt")]
    public required Amount1 VariationMarginAmount { get; init; }

    /// <summary>
    /// Provides details about the agreed amount for the segregated independent amount.
    /// </summary>
    [IsoId("_UmCVBNp-Ed-ak6NoX_4Aeg_-223051895")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public Amount1? SegregatedIndependentAmount { get; init; }
}
