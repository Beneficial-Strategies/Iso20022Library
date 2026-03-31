// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the collateral against variation margin and optionally the segregated independent amount.
/// </summary>
[IsoId("_UoRJqtp-Ed-ak6NoX_4Aeg_1673012479")]
[DisplayName("Collateral")]
public record Collateral1
{
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the variation margin.
    /// </summary>
    [IsoId("_Uoa6oNp-Ed-ak6NoX_4Aeg_117230825")]
    [DisplayName("Variation Margin")]
    [IsoXmlTag("VartnMrgn")]
    public required MarginCollateral1 VariationMargin { get; init; }

    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the segregated independent amount.
    /// </summary>
    [IsoId("_Uoa6odp-Ed-ak6NoX_4Aeg_-2144467240")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public MarginCollateral1? SegregatedIndependentAmount { get; init; }
}
