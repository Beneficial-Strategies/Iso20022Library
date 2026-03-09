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
namespace BeneficialStrategies.Iso20022.Choices.InterestRate27Choice
{
    /// <summary>
    /// Details about the variable rate.
    /// </summary>
    [IsoId("_Z-T6U8g6Eeu4ecZgAYuz5w")]
    [DisplayName("Floating")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Floating : InterestRate27Choice_
    #else
    public partial class Floating : InterestRate27Choice_
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
        [IsoId("_Z_09Q8g6Eeu4ecZgAYuz5w")]
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
        [IsoId("_Z_09Rcg6Eeu4ecZgAYuz5w")]
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
        [IsoId("_Z_09R8g6Eeu4ecZgAYuz5w")]
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
        /// Information related to the reset of payment frequency.
        /// </summary>
        [IsoId("_Z_09Scg6Eeu4ecZgAYuz5w")]
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
        /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
        /// </summary>
        [IsoId("_Z_09S8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Spread")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sprd")]
        #endif
        [IsoXmlTag("Sprd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesTransactionPrice18Choice_? Spread { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionPrice18Choice_? Spread { get; init; } 
        #else
        public SecuritiesTransactionPrice18Choice_? Spread { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the rate adjustments as determined by the rate schedule.
        /// </summary>
        [IsoId("_Z_09Tcg6Eeu4ecZgAYuz5w")]
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
        [IsoId("_Z_09T8g6Eeu4ecZgAYuz5w")]
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
