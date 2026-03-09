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
/// Indicates the unadjusted effective and end date of the schedule.
/// </summary>
[IsoId("_xBNIoQbKEeqrW7Meu5r3kQ")]
[DisplayName("Schedule")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Schedule3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Schedule3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Schedule3( System.DateOnly reqUnadjustedEffectiveDate,AmountAndDirection106 reqAmount )
    {
        UnadjustedEffectiveDate = reqUnadjustedEffectiveDate;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    [IsoId("_xJjMUQbKEeqrW7Meu5r3kQ")]
    [DisplayName("Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UadjstdFctvDt")]
    #endif
    [IsoXmlTag("UadjstdFctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate UnadjustedEffectiveDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly UnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly UnadjustedEffectiveDate { get; init; } 
    #else
    public System.DateOnly UnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    [IsoId("_xJjMUwbKEeqrW7Meu5r3kQ")]
    [DisplayName("Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UadjstdEndDt")]
    #endif
    [IsoXmlTag("UadjstdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? UnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? UnadjustedEndDate { get; init; } 
    #else
    public System.DateOnly? UnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_xJjMVQbKEeqrW7Meu5r3kQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection106 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection106 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection106 Amount { get; init; } 
    #else
    public AmountAndDirection106 Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
