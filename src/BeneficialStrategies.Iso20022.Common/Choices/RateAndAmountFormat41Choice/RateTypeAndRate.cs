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
namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat41Choice
{
    /// <summary>
    /// Value is expressed as a rate type and a percentage rate.
    /// </summary>
    [IsoId("_ACL0TUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Type And Rate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RateTypeAndRate : RateAndAmountFormat41Choice_
    #else
    public partial class RateTypeAndRate : RateAndAmountFormat41Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RateTypeAndRate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RateTypeAndRate( RateType42Choice_ reqRateType,System.Decimal reqRate )
        {
            RateType = reqRateType;
            Rate = reqRate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Value expressed as a rate type.
        /// </summary>
        [IsoId("__c_ccUEIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RateTp")]
        #endif
        [IsoXmlTag("RateTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RateType42Choice_ RateType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RateType42Choice_ RateType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateType42Choice_ RateType { get; init; } 
        #else
        public RateType42Choice_ RateType { get; set; } 
        #endif
        
        /// <summary>
        /// Value expressed as a rate.
        /// </summary>
        [IsoId("__c_cc0EIEeWVgfuHGaKtRQ")]
        [DisplayName("Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rate")]
        #endif
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoPercentageRate Rate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal Rate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal Rate { get; init; } 
        #else
        public System.Decimal Rate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
