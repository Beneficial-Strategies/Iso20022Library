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
namespace BeneficialStrategies.Iso20022.Choices.InterestRate21Choice
{
    /// <summary>
    /// Attributes related specifically to fixed rate of an interest rate contract.
    /// </summary>
    [IsoId("_GPqvsQ1IEeqV4s5SpzR1dQ")]
    [DisplayName("Fixed")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Fixed : InterestRate21Choice_
    #else
    public partial class Fixed : InterestRate21Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// An indication of the fixed rate used.
        /// </summary>
        [IsoId("_mY0Z4_OFEeaS7fYULSI4_Q")]
        [DisplayName("Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rate")]
        #endif
        [IsoXmlTag("Rate")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPercentageRate? Rate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? Rate { get; init; } 
        #else
        public System.Decimal? Rate { get; set; } 
        #endif
        
        /// <summary>
        /// Actual number of days in the relevant fixed rate calculation period.
        /// </summary>
        [IsoId("_mY0Z5fOFEeaS7fYULSI4_Q")]
        [DisplayName("Day Count")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DayCnt")]
        #endif
        [IsoXmlTag("DayCnt")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? DayCount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DayCount { get; init; } 
        #else
        public System.String? DayCount { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to payment frequency.
        /// </summary>
        [IsoId("_mY0Z5_OFEeaS7fYULSI4_Q")]
        [DisplayName("Payment Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtFrqcy")]
        #endif
        [IsoXmlTag("PmtFrqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRateFrequency2Choice_? PaymentFrequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateFrequency2Choice_? PaymentFrequency { get; init; } 
        #else
        public InterestRateFrequency2Choice_? PaymentFrequency { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
