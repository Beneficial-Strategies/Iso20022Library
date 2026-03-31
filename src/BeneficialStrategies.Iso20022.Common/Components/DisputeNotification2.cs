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
[IsoId("_NdxbgStOEeyOa655cLd-DQ")]
[DisplayName("Dispute Notification")]
public record DisputeNotification2
{
    /// <summary>
    /// Provides the dispute notification details for the variation margin.
    /// </summary>
    [IsoId("_N2groStOEeyOa655cLd-DQ")]
    [DisplayName("Variation Margin Dispute")]
    [IsoXmlTag("VartnMrgnDspt")]
    public required VariationMarginDispute1 VariationMarginDispute { get; init; }

    /// <summary>
    /// Provides the dispute notification details for the segregated independent amount.
    /// </summary>
    [IsoId("_N2groytOEeyOa655cLd-DQ")]
    [DisplayName("Segregated Independent Amount Dispute")]
    [IsoXmlTag("SgrtdIndpdntAmtDspt")]
    public SegregatedIndependentAmountDispute2? SegregatedIndependentAmountDispute { get; init; }
}
