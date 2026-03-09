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
namespace BeneficialStrategies.Iso20022.Choices.CreditDefaultSwapsDerivative3Choice
{
    /// <summary>
    /// A credit default swap derivative on an index.
    /// </summary>
    [IsoId("_xfbL135eEea2k7EBUopqxw")]
    [DisplayName("Credit Default Swap Index Derivative")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CreditDefaultSwapIndexDerivative : CreditDefaultSwapsDerivative3Choice_
    #else
    public partial class CreditDefaultSwapIndexDerivative : CreditDefaultSwapsDerivative3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CreditDefaultSwapIndexDerivative instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CreditDefaultSwapIndexDerivative( System.String reqIndexName,CreditDefaultSwapIndex2 reqIndex )
        {
            IndexName = reqIndexName;
            Index = reqIndex;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Derivative on a credit default swap with the ISIN code of the underlying index.
        /// </summary>
        [IsoId("_x6DSUX5eEea2k7EBUopqxw")]
        [DisplayName("Underlying Index Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UndrlygIndxId")]
        #endif
        [IsoXmlTag("UndrlygIndxId")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISINOct2015Identifier? UnderlyingIndexIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UnderlyingIndexIdentification { get; init; } 
        #else
        public System.String? UnderlyingIndexIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// To be populated for derivatives on a CDS index with the standardized name of the index.
        /// </summary>
        [IsoId("_x6DSU35eEea2k7EBUopqxw")]
        [DisplayName("Index Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IndxNm")]
        #endif
        [IsoXmlTag("IndxNm")]
        [IsoSimpleType(IsoSimpleType.Max25Text)]
        [StringLength(maximumLength: 25 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax25Text IndexName { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String IndexName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String IndexName { get; init; } 
        #else
        public System.String IndexName { get; set; } 
        #endif
        
        /// <summary>
        /// Describes the Index specific details the derivative is being made on.
        /// </summary>
        [IsoId("_x6DSVX5eEea2k7EBUopqxw")]
        [DisplayName("Index")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Indx")]
        #endif
        [IsoXmlTag("Indx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CreditDefaultSwapIndex2 Index { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CreditDefaultSwapIndex2 Index { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CreditDefaultSwapIndex2 Index { get; init; } 
        #else
        public CreditDefaultSwapIndex2 Index { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
