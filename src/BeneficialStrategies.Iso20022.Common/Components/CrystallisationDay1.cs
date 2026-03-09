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
/// Fix of the penultimate accrual date of the transaction to the final (repurchase) date. Crystallizing the penultimate fixing into a fixed rate for the final business day. This will allow for parties to send timely settlement instructions for the repurchase leg of the transaction. Default value is 1 day.
/// </summary>
[IsoId("_SBqscOhlEeqspItL-MF5VQ")]
[DisplayName("Crystallisation Day")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CrystallisationDay1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CrystallisationDay1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CrystallisationDay1( System.String reqDay )
    {
        Day = reqDay;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Fix of the penultimate accrual date of the transaction to the final (repurchase) date. Crystallizing the penultimate fixing into a fixed rate for the final business day. This will allow for parties to send timely settlement instructions for the repurchase leg of the transaction. Default value is 1 day. If not 1 then crystallization period must be used.
    /// </summary>
    [IsoId("_bB3hoehlEeqspItL-MF5VQ")]
    [DisplayName("Day")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Day")]
    #endif
    [IsoXmlTag("Day")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Day { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Day { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Day { get; init; } 
    #else
    public System.String Day { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days prior to the accrual date of the transaction to the final (repurchase) date. 
    /// </summary>
    [IsoId("_gxCq8ehlEeqspItL-MF5VQ")]
    [DisplayName("Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prd")]
    #endif
    [IsoXmlTag("Prd")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? Period { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Period { get; init; } 
    #else
    public System.String? Period { get; set; } 
    #endif
    
    
    #nullable disable
    
}
