// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DisputeNotification2Choice
{
    /// <summary>
    /// Provides the dispute notification details for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_KkjLoStOEeyOa655cLd-DQ")]
    [DisplayName("Dispute Notification Details")]
    public record DisputeNotificationDetails : DisputeNotification2Choice_
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
}
