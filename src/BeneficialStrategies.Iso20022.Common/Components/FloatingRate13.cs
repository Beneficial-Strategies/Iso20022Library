// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Floating rate related information.
/// </summary>
[IsoId("_WIFf0SJdEe2zWP9pqvmqdw")]
[DisplayName("Floating Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FloatingRate13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of the security subject of the transaction
    /// </summary>
    [IsoId("_WJf1EyJdEe2zWP9pqvmqdw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// The full name of the interest rate as assigned by the index provider.
    /// </summary>
    [IsoId("_WJf1FSJdEe2zWP9pqvmqdw")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the floating rate used.
    /// </summary>
    [IsoId("_WJf1FyJdEe2zWP9pqvmqdw")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FloatingRateIdentification8Choice_? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FloatingRateIdentification8Choice_? Rate { get; init; } 
    #else
    public FloatingRateIdentification8Choice_? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to reference period.
    /// </summary>
    [IsoId("_WJf1GSJdEe2zWP9pqvmqdw")]
    [DisplayName("Reference Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefPrd")]
    #endif
    [IsoXmlTag("RefPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateContractTerm4? ReferencePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateContractTerm4? ReferencePeriod { get; init; } 
    #else
    public InterestRateContractTerm4? ReferencePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
    /// </summary>
    [IsoId("_WJf1GyJdEe2zWP9pqvmqdw")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice20Choice_? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice20Choice_? Spread { get; init; } 
    #else
    public SecuritiesTransactionPrice20Choice_? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the computation method that determines how interest payments are calculated. It is used to compute the year fraction of the calculation period, and indicates the number of days in the calculation period divided by the number of days in the year.
    /// </summary>
    [IsoId("_WJf1HSJdEe2zWP9pqvmqdw")]
    [DisplayName("Day Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCnt")]
    #endif
    [IsoXmlTag("DayCnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat7? DayCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat7? DayCount { get; init; } 
    #else
    public InterestComputationMethodFormat7? DayCount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the time unit associated with the frequency of payments.
    /// </summary>
    [IsoId("_WJf1HyJdEe2zWP9pqvmqdw")]
    [DisplayName("Payment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtFrqcy")]
    #endif
    [IsoXmlTag("PmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateFrequency3Choice_? PaymentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateFrequency3Choice_? PaymentFrequency { get; init; } 
    #else
    public InterestRateFrequency3Choice_? PaymentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to reset of payment frequency.
    /// </summary>
    [IsoId("_WJf1ISJdEe2zWP9pqvmqdw")]
    [DisplayName("Reset Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstFrqcy")]
    #endif
    [IsoXmlTag("RstFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateFrequency3Choice_? ResetFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateFrequency3Choice_? ResetFrequency { get; init; } 
    #else
    public InterestRateFrequency3Choice_? ResetFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the nearest date in the future at which the floating reference rate will be reset.
    /// </summary>
    [IsoId("_WJf1IyJdEe2zWP9pqvmqdw")]
    [DisplayName("Next Floating Reset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtFltgRst")]
    #endif
    [IsoXmlTag("NxtFltgRst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResetDateAndValue1? NextFloatingReset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResetDateAndValue1? NextFloatingReset { get; init; } 
    #else
    public ResetDateAndValue1? NextFloatingReset { get; set; } 
    #endif
    
    /// <summary>
    /// Most recent date and value at which the floating reference rate was reset.
    /// </summary>
    [IsoId("_iXROYCReEe2VuKUpJ7HXPg")]
    [DisplayName("Last Floating Reset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastFltgRst")]
    #endif
    [IsoXmlTag("LastFltgRst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResetDateAndValue1? LastFloatingReset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResetDateAndValue1? LastFloatingReset { get; init; } 
    #else
    public ResetDateAndValue1? LastFloatingReset { get; set; } 
    #endif
    
    
    #nullable disable
    
}
