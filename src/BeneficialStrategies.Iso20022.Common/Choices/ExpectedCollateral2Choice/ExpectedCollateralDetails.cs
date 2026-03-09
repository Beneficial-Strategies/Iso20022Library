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
namespace BeneficialStrategies.Iso20022.Choices.ExpectedCollateral2Choice
{
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_-sdWMYLZEeWrrO9HojbPQA")]
    [DisplayName("Expected Collateral Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ExpectedCollateralDetails : ExpectedCollateral2Choice_
    #else
    public partial class ExpectedCollateralDetails : ExpectedCollateral2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ExpectedCollateralDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ExpectedCollateralDetails( ExpectedCollateralMovement2 reqVariationMargin )
        {
            VariationMargin = reqVariationMargin;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the expected collateral type and direction for the variation margin.
        /// </summary>
        [IsoId("__DOQYYLZEeWrrO9HojbPQA")]
        [DisplayName("Variation Margin")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VartnMrgn")]
        #endif
        [IsoXmlTag("VartnMrgn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExpectedCollateralMovement2 VariationMargin { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExpectedCollateralMovement2 VariationMargin { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExpectedCollateralMovement2 VariationMargin { get; init; } 
        #else
        public ExpectedCollateralMovement2 VariationMargin { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the expected collateral type and direction for the segregated independent amount.
        /// </summary>
        [IsoId("__DOQY4LZEeWrrO9HojbPQA")]
        [DisplayName("Segregated Independent Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgrtdIndpdntAmt")]
        #endif
        [IsoXmlTag("SgrtdIndpdntAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExpectedCollateralMovement2? SegregatedIndependentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExpectedCollateralMovement2? SegregatedIndependentAmount { get; init; } 
        #else
        public ExpectedCollateralMovement2? SegregatedIndependentAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
