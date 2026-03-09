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
namespace BeneficialStrategies.Iso20022.Choices.InterestRateFrequency3Choice
{
    /// <summary>
    /// Frequency expressed in tenor notation.
    /// </summary>
    [IsoId("_7KQYoVfREeqqKf65rDYWYw")]
    [DisplayName("Term")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Term : InterestRateFrequency3Choice_
    #else
    public partial class Term : InterestRateFrequency3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unit for the rate basis.
        /// </summary>
        [IsoId("_7j19U1fREeqqKf65rDYWYw")]
        [DisplayName("Unit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Unit")]
        #endif
        [IsoXmlTag("Unit")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Frequency13Code? Unit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Frequency13Code? Unit { get; init; } 
        #else
        public Frequency13Code? Unit { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the number of time units (as expressed by the payment frequency period) that detemines the frequency at which periodic payment dates occur.
        /// </summary>
        [IsoId("_7j19VVfREeqqKf65rDYWYw")]
        [DisplayName("Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Val")]
        #endif
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.Max3Number)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax3Number? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? Value { get; init; } 
        #else
        public System.UInt64? Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
