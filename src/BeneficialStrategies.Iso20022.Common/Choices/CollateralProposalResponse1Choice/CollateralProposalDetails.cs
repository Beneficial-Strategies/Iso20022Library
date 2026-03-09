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
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse1Choice
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_QmU-Ntp-Ed-ak6NoX_4Aeg_-930993796")]
    [DisplayName("Collateral Proposal Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CollateralProposalDetails : CollateralProposalResponse1Choice_
    #else
    public partial class CollateralProposalDetails : CollateralProposalResponse1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CollateralProposalDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CollateralProposalDetails( CollateralProposalResponseType1 reqVariationMargin )
        {
            VariationMargin = reqVariationMargin;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the collateral proposal response for the variation margin.
        /// </summary>
        [IsoId("_Un-OsNp-Ed-ak6NoX_4Aeg_1523875178")]
        [DisplayName("Variation Margin")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VartnMrgn")]
        #endif
        [IsoXmlTag("VartnMrgn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CollateralProposalResponseType1 VariationMargin { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CollateralProposalResponseType1 VariationMargin { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralProposalResponseType1 VariationMargin { get; init; } 
        #else
        public CollateralProposalResponseType1 VariationMargin { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the collateral proposal response for the segregated independent amount.
        /// </summary>
        [IsoId("_Un-Osdp-Ed-ak6NoX_4Aeg_495998961")]
        [DisplayName("Segregated Independent Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgrtdIndpdntAmt")]
        #endif
        [IsoXmlTag("SgrtdIndpdntAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralProposalResponseType1? SegregatedIndependentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralProposalResponseType1? SegregatedIndependentAmount { get; init; } 
        #else
        public CollateralProposalResponseType1? SegregatedIndependentAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
