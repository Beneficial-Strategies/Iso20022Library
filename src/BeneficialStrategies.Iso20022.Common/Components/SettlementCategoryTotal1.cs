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
/// Settlement totals
/// </summary>
[IsoId("_Dvqc4FdDEeeFltjJxERUxw")]
[DisplayName("Settlement Category Total")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementCategoryTotal1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementCategoryTotal1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementCategoryTotal1( Amount14 reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of transactions.
    /// </summary>
    [IsoId("_RhhqQFdDEeeFltjJxERUxw")]
    [DisplayName("Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnt")]
    #endif
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Count { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Count { get; init; } 
    #else
    public System.UInt64? Count { get; set; } 
    #endif
    
    /// <summary>
    /// Gross amount.
    /// </summary>
    [IsoId("_pDwlgFdDEeeFltjJxERUxw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount14 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount14 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount14 Amount { get; init; } 
    #else
    public Amount14 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Interchange fee amount.
    /// </summary>
    [IsoId("_clMWkFdEEeeFltjJxERUxw")]
    [DisplayName("Interchange Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrchngFee")]
    #endif
    [IsoXmlTag("IntrchngFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount14? InterchangeFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount14? InterchangeFee { get; init; } 
    #else
    public Amount14? InterchangeFee { get; set; } 
    #endif
    
    /// <summary>
    /// Processing fee.
    /// </summary>
    [IsoId("_iVT7EFdEEeeFltjJxERUxw")]
    [DisplayName("Processing Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgFee")]
    #endif
    [IsoXmlTag("PrcgFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount14? ProcessingFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount14? ProcessingFee { get; init; } 
    #else
    public Amount14? ProcessingFee { get; set; } 
    #endif
    
    
    #nullable disable
    
}
