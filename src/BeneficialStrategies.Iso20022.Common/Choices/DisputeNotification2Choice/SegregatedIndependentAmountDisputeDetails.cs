// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DisputeNotification2Choice
{
    /// <summary>
    /// Provides the dispute notification details for the segregated independent amount only.
    /// </summary>
    [IsoId("_KkjLoytOEeyOa655cLd-DQ")]
    [DisplayName("Segregated Independent Amount Dispute Details")]
    [IsoXmlTag("SgrtdIndpdntAmtDsptDtls")]
    public record SegregatedIndependentAmountDisputeDetails : DisputeNotification2Choice_
    {
        /// <summary>
        /// Details of the disputed instruction.
        /// </summary>
        [IsoId("_da94AStOEeyOa655cLd-DQ")]
        [DisplayName("Dispute Details")]
        [IsoXmlTag("DsptDtls")]
        public required Dispute1 DisputeDetails { get; init; }

        /// <summary>
        /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
        /// </summary>
        [IsoId("_da94AytOEeyOa655cLd-DQ")]
        [DisplayName("Dispute Resolution Type 1 Choice")]
        [IsoXmlTag("DsptRsltnTp1Chc")]
        public DisputeResolutionType1Choice_? DisputeResolutionType1Choice { get; init; }
    }
}
