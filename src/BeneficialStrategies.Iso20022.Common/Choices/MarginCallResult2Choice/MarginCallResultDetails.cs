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
namespace BeneficialStrategies.Iso20022.Choices.MarginCallResult2Choice
{
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_9boCQKMPEeCojJW5vEuTEQ_1384684121")]
    [DisplayName("Margin Call Result Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginCallResultDetails : MarginCallResult2Choice_
    #else
    public partial class MarginCallResultDetails : MarginCallResult2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarginCallResultDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarginCallResultDetails( Result1 reqVariationMarginResult )
        {
            VariationMarginResult = reqVariationMarginResult;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the summation of the call amounts for the variation margin amount only.
        /// </summary>
        [IsoId("_UlvaF9p-Ed-ak6NoX_4Aeg_-1196189794")]
        [DisplayName("Variation Margin Result")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VartnMrgnRslt")]
        #endif
        [IsoXmlTag("VartnMrgnRslt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Result1 VariationMarginResult { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Result1 VariationMarginResult { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Result1 VariationMarginResult { get; init; } 
        #else
        public Result1 VariationMarginResult { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the summation of the call amounts for the segregated independent amount.
        /// </summary>
        [IsoId("_UlvaGNp-Ed-ak6NoX_4Aeg_872246105")]
        [DisplayName("Segregated Independent Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SgrtdIndpdntAmt")]
        #endif
        [IsoXmlTag("SgrtdIndpdntAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Result1? SegregatedIndependentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Result1? SegregatedIndependentAmount { get; init; } 
        #else
        public Result1? SegregatedIndependentAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
