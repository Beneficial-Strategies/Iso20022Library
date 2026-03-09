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
namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative4Choice
{
    /// <summary>
    /// A credit default swap derivative on an index.
    /// </summary>
    [IsoId("_xSzjVye0Eei12pGEsJIAeQ")]
    [DisplayName("Credit Default Swap Index Derivative")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CreditDefaultSwapIndexDerivative : CreditDefaultSwapsDerivative4Choice_
    #else
    public partial class CreditDefaultSwapIndexDerivative : CreditDefaultSwapsDerivative4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CreditDefaultSwapIndexDerivative instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CreditDefaultSwapIndexDerivative( CreditDefaultSwapIndex3 reqUnderlyingCreditDefaultSwapIndex )
        {
            UnderlyingCreditDefaultSwapIndex = reqUnderlyingCreditDefaultSwapIndex;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Derivative on a credit default swap with the ISIN code of the underlying swap.
        /// </summary>
        [IsoId("__ZOEYie0Eei12pGEsJIAeQ")]
        [DisplayName("Underlying Credit Default Swap Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygCdtDfltSwpId")]
        #endif
        [IsoXmlTag("UndrlygCdtDfltSwpId")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISINOct2015Identifier? UnderlyingCreditDefaultSwapIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UnderlyingCreditDefaultSwapIdentification { get; init; } 
        #else
        public System.String? UnderlyingCreditDefaultSwapIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Describes the Credit Default Swap Index specific details the derivative is being made on.
        /// </summary>
        [IsoId("_xczM1Se0Eei12pGEsJIAeQ")]
        [DisplayName("Underlying Credit Default Swap Index")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygCdtDfltSwpIndx")]
        #endif
        [IsoXmlTag("UndrlygCdtDfltSwpIndx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
        #else
        public CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
