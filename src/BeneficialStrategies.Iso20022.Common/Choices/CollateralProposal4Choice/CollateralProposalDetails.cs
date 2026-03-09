// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal4Choice
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_xv754YFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Proposal Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CollateralProposalDetails : CollateralProposal4Choice_
    #else
    public partial class CollateralProposalDetails : CollateralProposal4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CollateralProposalDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CollateralProposalDetails( CollateralMovement7 reqVariationMargin )
        {
            VariationMargin = reqVariationMargin;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides details about the proposal for the variation margin.
        /// </summary>
        [IsoId("_z0NewYFvEeWtPe6Crjmeug")]
        [DisplayName("Variation Margin")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VartnMrgn")]
        #endif
        [IsoXmlTag("VartnMrgn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CollateralMovement7 VariationMargin { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CollateralMovement7 VariationMargin { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralMovement7 VariationMargin { get; init; } 
        #else
        public CollateralMovement7 VariationMargin { get; set; } 
        #endif
        
        /// <summary>
        /// Provides details about the proposal for the segregated independent amount.
        /// </summary>
        [IsoId("_z0New4FvEeWtPe6Crjmeug")]
        [DisplayName("Segregated Independent Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgrtdIndpdntAmt")]
        #endif
        [IsoXmlTag("SgrtdIndpdntAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralMovement7? SegregatedIndependentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralMovement7? SegregatedIndependentAmount { get; init; } 
        #else
        public CollateralMovement7? SegregatedIndependentAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
