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
/// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
/// </summary>
[IsoId("_88EdAXs1EeSTS7uHCe8FPQ")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedAmount10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedAmount10( TypeOfAmount6Code reqType,CurrencyAndAmount reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_9Jz-EXs1EeSTS7uHCe8FPQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount6Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount6Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount6Code Type { get; init; } 
    #else
    public TypeOfAmount6Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_9Jz-E3s1EeSTS7uHCe8FPQ")]
    [DisplayName("Additional Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTp")]
    #endif
    [IsoXmlTag("AddtlTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalType { get; init; } 
    #else
    public System.String? AdditionalType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_9Jz-FXs1EeSTS7uHCe8FPQ")]
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
    /// Short description of the amount to provide to the cardholder.
    /// </summary>
    [IsoId("_9Jz-GXs1EeSTS7uHCe8FPQ")]
    [DisplayName("Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Labl")]
    #endif
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Label { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Label { get; init; } 
    #else
    public System.String? Label { get; set; } 
    #endif
    
    
    #nullable disable
    
}
