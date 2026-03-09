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
/// Choice to define the price of the securities transaction.
/// </summary>
[IsoId("_i7VOgZiuEe2f7NHvXATP5g")]
[DisplayName("Securities Transaction Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesTransactionPrice7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesTransactionPrice7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesTransactionPrice7( AmountAndDirection61 reqMonetaryValue,DigitalTokenAmount2 reqDigitalTokenQuantity )
    {
        MonetaryValue = reqMonetaryValue;
        DigitalTokenQuantity = reqDigitalTokenQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Price expressed as a monetary value.
    /// </summary>
    [IsoId("_i9PTAZiuEe2f7NHvXATP5g")]
    [DisplayName("Monetary Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntryVal")]
    #endif
    [IsoXmlTag("MntryVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection61 MonetaryValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection61 MonetaryValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection61 MonetaryValue { get; init; } 
    #else
    public AmountAndDirection61 MonetaryValue { get; set; } 
    #endif
    
    /// <summary>
    /// Price expressed as a number of digital tokens.
    /// </summary>
    [IsoId("_o26cIJiuEe2f7NHvXATP5g")]
    [DisplayName("Digital Token Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlTknQty")]
    #endif
    [IsoXmlTag("DgtlTknQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DigitalTokenAmount2 DigitalTokenQuantity { get; init; } 
    #else
    public DigitalTokenAmount2 DigitalTokenQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
