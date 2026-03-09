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
    /// Details about the variable rate.
    /// </summary>
    [IsoId("_hFv8E6x2Eem81-uIvTF5rQ")]
    [DisplayName("Floating")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Floating : InterestRate20Choice_
    #else
    public partial class Floating : InterestRate20Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the reference index for the debt instrument.
        /// </summary>
        [IsoId("_hJxgcax2Eem81-uIvTF5rQ")]
        [DisplayName("Reference Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RefRate")]
        #endif
        [IsoXmlTag("RefRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BenchmarkCurveName10Choice_? ReferenceRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BenchmarkCurveName10Choice_? ReferenceRate { get; init; } 
        #else
        public BenchmarkCurveName10Choice_? ReferenceRate { get; set; } 
        #endif
        
        /// <summary>
        /// Term of the reference rate of the floating rate bond. The term shall be expressed in days, weeks, months or years.
        /// </summary>
        [IsoId("_hJxgc6x2Eem81-uIvTF5rQ")]
        [DisplayName("Term")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Term")]
        #endif
        [IsoXmlTag("Term")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRateContractTerm2? Term { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateContractTerm2? Term { get; init; } 
        #else
        public InterestRateContractTerm2? Term { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to payment frequency.
        /// </summary>
        [IsoId("_hJxgdax2Eem81-uIvTF5rQ")]
        [DisplayName("Payment Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtFrqcy")]
        #endif
        [IsoXmlTag("PmtFrqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRateContractTerm2? PaymentFrequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateContractTerm2? PaymentFrequency { get; init; } 
        #else
        public InterestRateContractTerm2? PaymentFrequency { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to reset of payment frequency.
        /// </summary>
        [IsoId("_hJxgd6x2Eem81-uIvTF5rQ")]
        [DisplayName("Reset Frequency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RstFrqcy")]
        #endif
        [IsoXmlTag("RstFrqcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRateContractTerm2? ResetFrequency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRateContractTerm2? ResetFrequency { get; init; } 
        #else
        public InterestRateContractTerm2? ResetFrequency { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the number of basis points added to (if positive) or deducted from (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
        /// </summary>
        [IsoId("_hJxgeax2Eem81-uIvTF5rQ")]
        [DisplayName("Basis Point Spread")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BsisPtSprd")]
        #endif
        [IsoXmlTag("BsisPtSprd")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoDecimalNumber? BasisPointSpread { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? BasisPointSpread { get; init; } 
        #else
        public System.UInt64? BasisPointSpread { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the rate adjustments as determined by the rate schedule.
        /// </summary>
        [IsoId("_wWAosctEEemlLfTG-WCXxw")]
        [DisplayName("Rate Adjustment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RateAdjstmnt")]
        #endif
        [IsoXmlTag("RateAdjstmnt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public RateAdjustment1? RateAdjustment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RateAdjustment1? RateAdjustment { get; init; } 
        #else
        public RateAdjustment1? RateAdjustment { get; set; } 
        #endif
        
        /// <summary>
        /// Method for calculating the accrued interest on the principal amount for a fixed rate.
        /// </summary>
        [IsoId("_hJxge6x2Eem81-uIvTF5rQ")]
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
