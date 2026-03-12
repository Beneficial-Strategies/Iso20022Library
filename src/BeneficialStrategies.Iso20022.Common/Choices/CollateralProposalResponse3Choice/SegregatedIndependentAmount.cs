// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse3Choice
{
    /// <summary>
    /// Provides the collateral proposal response for the segregated independent amount only.
    /// </summary>
    [IsoId("_sc8-04pDEeaNTaanBSMWmg")]
    [DisplayName("Segregated Independent Amount")]
    public partial record SegregatedIndependentAmount : CollateralProposalResponse3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identifier for a collateral proposal.
        /// </summary>
        [IsoId("_s62bwYpDEeaNTaanBSMWmg")]
        [DisplayName("Collateral Proposal Identification")]
        [IsoXmlTag("CollPrpslId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text CollateralProposalIdentification { get; init; } 
        
        /// <summary>
        /// Indicates whether the collateral proposal is an initial or a counter proposal.
        /// </summary>
        [IsoId("_s62bw4pDEeaNTaanBSMWmg")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required CollateralProposalResponse1Code Type { get; init; } 
        
        /// <summary>
        /// Provides response details for each of the proposed collateral pieces.
        /// </summary>
        [IsoId("_s62bxYpDEeaNTaanBSMWmg")]
        [DisplayName("Response")]
        [IsoXmlTag("Rspn")]
        public required CollateralResponse2 Response { get; init; } 
        
        
        #nullable disable
        
    }
}
