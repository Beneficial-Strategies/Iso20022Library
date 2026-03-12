// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal4Choice
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_xv754YFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Proposal Details")]
    public partial record CollateralProposalDetails : CollateralProposal4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides details about the proposal for the variation margin.
        /// </summary>
        [IsoId("_z0NewYFvEeWtPe6Crjmeug")]
        [DisplayName("Variation Margin")]
        [IsoXmlTag("VartnMrgn")]
        public required CollateralMovement7 VariationMargin { get; init; } 
        
        /// <summary>
        /// Provides details about the proposal for the segregated independent amount.
        /// </summary>
        [IsoId("_z0New4FvEeWtPe6Crjmeug")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public CollateralMovement7? SegregatedIndependentAmount { get; init; } 
        
        
        #nullable disable
        
    }
}
