// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse1Choice
{
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount only.
    /// </summary>
    [IsoId("_QmU-N9p-Ed-ak6NoX_4Aeg_-277145962")]
    [DisplayName("Segregated Independent Amount")]
    public partial record SegregatedIndependentAmount : CollateralProposalResponse1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier for a collateral proposal.
        /// </summary>
        [IsoId("_Un0dstp-Ed-ak6NoX_4Aeg_218527511")]
        [DisplayName("Collateral Proposal Identification")]
        [IsoXmlTag("CollPrpslId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text CollateralProposalIdentification { get; init; } 
        
        /// <summary>
        /// Indicates whether the collateral proposal is an initial or a counter proposal.
        /// </summary>
        [IsoId("_Un0ds9p-Ed-ak6NoX_4Aeg_-14002491")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required CollateralProposalResponse1Code Type { get; init; } 
        
        /// <summary>
        /// Specifies the status of the collateral proposal.
        /// </summary>
        [IsoId("_Un0dtNp-Ed-ak6NoX_4Aeg_901549876")]
        [DisplayName("Response Type")]
        [IsoXmlTag("RspnTp")]
        public required Status4Code ResponseType { get; init; } 
        
        /// <summary>
        /// Specifies the reason why the instruction/cancellation request has a rejected status.
        /// </summary>
        [IsoId("_Un0dtdp-Ed-ak6NoX_4Aeg_-1564918581")]
        [DisplayName("Rejection Reason")]
        [IsoXmlTag("RjctnRsn")]
        public RejectionReasonV021Code? RejectionReason { get; init; } 
        
        /// <summary>
        /// Additional information regarding why the collateral proposal has a rejected status.
        /// </summary>
        [IsoId("_Un0dttp-Ed-ak6NoX_4Aeg_-1917789059")]
        [DisplayName("Rejection Information")]
        [IsoXmlTag("RjctnInf")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? RejectionInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
