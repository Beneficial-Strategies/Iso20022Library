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
namespace BeneficialStrategies.Iso20022.Choices.InterestRate20Choice
{
    /// <summary>
    /// Details of the fixed rate.
    /// </summary>
    [IsoId("_hFv8Eax2Eem81-uIvTF5rQ")]
    [DisplayName("Fixed")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Fixed : InterestRate20Choice_
    #else
    public partial class Fixed : InterestRate20Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Annualised interest rate on the principal amount of the repurchase transaction in accordance with the day count convention.
        /// </summary>
        [IsoId("_g04ioayDEem81-uIvTF5rQ")]
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
        /// Method for calculating the accrued interest on the principal amount for a fixed rate.
        /// </summary>
        [IsoId("_g04io6yDEem81-uIvTF5rQ")]
        [DisplayName("Day Count Basis")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DayCntBsis")]
        #endif
        [IsoXmlTag("DayCntBsis")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; } 
        #else
        public InterestComputationMethodFormat6Choice_? DayCountBasis { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
