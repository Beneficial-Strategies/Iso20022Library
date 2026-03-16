// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DisputeNotification1Choice
{
    /// <summary>
    /// Provides the dispute notification details for the segregated independent amount only.
    /// </summary>
    [IsoId("_QmU-NNp-Ed-ak6NoX_4Aeg_-640077576")]
    [DisplayName("Segregated Independent Amount Dispute Details")]
    public record SegregatedIndependentAmountDisputeDetails : DisputeNotification1Choice_
    {
        /// <summary>
        /// Details of the disputed instruction.
        /// </summary>
        [IsoId("_Ulb4FNp-Ed-ak6NoX_4Aeg_-2146942224")]
        [DisplayName("Dispute Details")]
        [IsoXmlTag("DsptDtls")]
        public required Dispute1 DisputeDetails { get; init; }

        /// <summary>
        /// Specifies the type of dispute that is to be resolved regarding the disputed collateral amount.
        /// </summary>
        [IsoId("_Ulb4Fdp-Ed-ak6NoX_4Aeg_-432473842")]
        [DisplayName("Dispute Resolution Type 1 Choice")]
        [IsoXmlTag("DsptRsltnTp1Chc")]
        public DisputeResolutionType1Choice_? DisputeResolutionType1Choice { get; init; }
    }
}
