// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the dispute notification details for the variation margin and optionaly the segregated independent amount.
/// </summary>
[IsoId("_UllpFNp-Ed-ak6NoX_4Aeg_203292187")]
[DisplayName("Dispute Notification")]
public record DisputeNotification1
{
    /// <summary>
    /// Provides the dispute notification details for the variation margin.
    /// </summary>
    [IsoId("_UllpFdp-Ed-ak6NoX_4Aeg_-641718307")]
    [DisplayName("Variation Margin Dispute")]
    [IsoXmlTag("VartnMrgnDspt")]
    public required VariationMarginDispute1 VariationMarginDispute { get; init; }

    /// <summary>
    /// Provides the dispute notification details for the segregated independent amount.
    /// </summary>
    [IsoId("_UllpFtp-Ed-ak6NoX_4Aeg_1091176533")]
    [DisplayName("Segregated Independent Amount Dispute")]
    [IsoXmlTag("SgrtdIndpdntAmtDspt")]
    public SegregatedIndependentAmountDispute1? SegregatedIndependentAmountDispute { get; init; }
}
