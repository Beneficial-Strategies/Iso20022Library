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
/// Fixed rate related information.
/// </summary>
[IsoId("_7j19V1fREeqqKf65rDYWYw")]
[DisplayName("Fixed Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FixedRate10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the per annum rate of the fixed leg(s) of an interest rate contract.
    /// </summary>
    [IsoId("_71ixU1fREeqqKf65rDYWYw")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice14Choice_? Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice14Choice_? Rate { get; init; } 
    #else
    public SecuritiesTransactionPrice14Choice_? Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the computation method that determines how interest payments are calculated. It is used to compute the year fraction of the calculation period, and indicates the number of days in the calculation period divided by the number of days in the year.
    /// </summary>
    [IsoId("_71ixVVfREeqqKf65rDYWYw")]
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
    [IsoId("_71ixV1fREeqqKf65rDYWYw")]
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
    
    
    #nullable disable
    
}
