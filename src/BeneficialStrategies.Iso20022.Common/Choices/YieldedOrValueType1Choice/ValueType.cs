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
namespace BeneficialStrategies.Iso20022.Choices.YieldedOrValueType1Choice
{
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    [IsoId("_RdBVqNp-Ed-ak6NoX_4Aeg_599544875")]
    [DisplayName("Value Type")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ValueType : YieldedOrValueType1Choice_
    #else
    public partial class ValueType : YieldedOrValueType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ValueType instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ValueType( PriceValueType1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of value of the price.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ValTp")]
        #endif
        [IsoXmlTag("ValTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PriceValueType1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PriceValueType1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PriceValueType1Code Value { get; init; } 
        #else
        public PriceValueType1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
