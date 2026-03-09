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
    /// Attributes related specifically to floating rate of an interest rate contract.
    /// </summary>
    [IsoId("_GPqvsw1IEeqV4s5SpzR1dQ")]
    [DisplayName("Floating")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Floating : InterestRate21Choice_
    #else
    public partial class Floating : InterestRate21Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Indication of the floating rate used.
        /// </summary>
        [IsoId("_GQZvgw1IEeqV4s5SpzR1dQ")]
        [DisplayName("Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rate")]
        #endif
        [IsoXmlTag("Rate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FloatingRateIdentification3Choice_? Rate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FloatingRateIdentification3Choice_? Rate { get; init; } 
        #else
        public FloatingRateIdentification3Choice_? Rate { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to reference period.
        /// </summary>
        [IsoId("_GQZvhQ1IEeqV4s5SpzR1dQ")]
        [DisplayName("Reference Period")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RefPrd")]
        #endif
        [IsoXmlTag("RefPrd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRateContractTerm3? ReferencePeriod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateContractTerm3? ReferencePeriod { get; init; } 
        #else
        public InterestRateContractTerm3? ReferencePeriod { get; set; } 
        #endif
        
        /// <summary>
        /// Spread expressed as a rate.
        /// </summary>
        [IsoId("_GQZvhw1IEeqV4s5SpzR1dQ")]
        [DisplayName("Spread")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sprd")]
        #endif
        [IsoXmlTag("Sprd")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPercentageRate? Spread { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? Spread { get; init; } 
        #else
        public System.Decimal? Spread { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to payment frequency.
        /// </summary>
        [IsoId("_GQZviQ1IEeqV4s5SpzR1dQ")]
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
        
        /// <summary>
        /// Information related to reset of payment frequency.
        /// </summary>
        [IsoId("_GQZviw1IEeqV4s5SpzR1dQ")]
        [DisplayName("Reset Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RstFrqcy")]
        #endif
        [IsoXmlTag("RstFrqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRateFrequency2Choice_? ResetFrequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateFrequency2Choice_? ResetFrequency { get; init; } 
        #else
        public InterestRateFrequency2Choice_? ResetFrequency { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
