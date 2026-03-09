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
/// Maximum amount allowed over a specific period of time.
/// </summary>
[IsoId("_Qotj09p-Ed-ak6NoX_4Aeg_540897")]
[DisplayName("Maximum Amount By Period")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaximumAmountByPeriod1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaximumAmountByPeriod1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaximumAmountByPeriod1( ActiveCurrencyAndAmount reqMaximumAmount,System.String reqNumberOfDays )
    {
        MaximumAmount = reqMaximumAmount;
        NumberOfDays = reqNumberOfDays;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum amount allowed over a specific period of time.
    /// </summary>
    [IsoId("_Qotj1Np-Ed-ak6NoX_4Aeg_-998319567")]
    [DisplayName("Maximum Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmt")]
    #endif
    [IsoXmlTag("MaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount MaximumAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount MaximumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount MaximumAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount MaximumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Period specified as a number of days.
    /// </summary>
    [IsoId("_Qotj1dp-Ed-ak6NoX_4Aeg_1020263959")]
    [DisplayName("Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDays")]
    #endif
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText NumberOfDays { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfDays { get; init; } 
    #else
    public System.String NumberOfDays { get; set; } 
    #endif
    
    
    #nullable disable
    
}
