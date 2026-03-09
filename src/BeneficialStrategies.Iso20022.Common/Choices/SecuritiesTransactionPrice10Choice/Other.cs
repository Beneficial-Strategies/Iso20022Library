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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice10Choice
{
    /// <summary>
    /// Indicates that price or quantity is expressed in another notation.
    /// </summary>
    [IsoId("_QtVs6f9iEea3W_f2lS_aiw")]
    [DisplayName("Other")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : SecuritiesTransactionPrice10Choice_
    #else
    public partial class Other : SecuritiesTransactionPrice10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Value of the price.
        /// </summary>
        [IsoId("_t14wY_9iEea3W_f2lS_aiw")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLongFraction21DecimalNumber? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Value { get; init; } 
        #else
        public System.UInt64? Value { get; set; } 
        #endif
        
        /// <summary>
        /// Notation of the price.
        /// </summary>
        [IsoId("_t14wZf9iEea3W_f2lS_aiw")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Type { get; init; } 
        #else
        public System.String? Type { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
