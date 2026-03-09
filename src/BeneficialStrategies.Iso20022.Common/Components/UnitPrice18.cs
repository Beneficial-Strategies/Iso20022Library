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
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_ClxUsRrbEeOVR9VN6fAMUg")]
[DisplayName("Unit Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnitPrice18
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnitPrice18 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnitPrice18( UnitOfMeasure3Choice_ reqUnitPrice,CurrencyAndAmount reqAmount )
    {
        UnitPrice = reqUnitPrice;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the unit price.
    /// </summary>
    [IsoId("_ITS4MBrbEeOVR9VN6fAMUg")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOfMeasure3Choice_ UnitPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOfMeasure3Choice_ UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure3Choice_ UnitPrice { get; init; } 
    #else
    public UnitOfMeasure3Choice_ UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_C9KhBxrbEeOVR9VN6fAMUg")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
    /// </summary>
    [IsoId("_C9KhCRrbEeOVR9VN6fAMUg")]
    [DisplayName("Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctr")]
    #endif
    [IsoXmlTag("Fctr")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? Factor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Factor { get; init; } 
    #else
    public System.String? Factor { get; set; } 
    #endif
    
    
    #nullable disable
    
}
