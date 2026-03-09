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
/// Limits and amounts not part of the transaction amount.
/// </summary>
[IsoId("_tSAeoUTEEeiTBYbU3rWV0A")]
[DisplayName("Additional Amounts")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalAmounts2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalAmounts2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalAmounts2( TypeOfAmount17Code reqType,Amount14 reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_td6MoUTEEeiTBYbU3rWV0A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount17Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount17Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount17Code Type { get; init; } 
    #else
    public TypeOfAmount17Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of amount.
    /// </summary>
    [IsoId("_td6Mo0TEEeiTBYbU3rWV0A")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of one occurrence of the breakdown amount.
    /// </summary>
    [IsoId("_td6MpUTEEeiTBYbU3rWV0A")]
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
    /// Short description of the additional amount.
    /// </summary>
    [IsoId("_td6Mp0TEEeiTBYbU3rWV0A")]
    [DisplayName("Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Labl")]
    #endif
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Label { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Label { get; init; } 
    #else
    public System.String? Label { get; set; } 
    #endif
    
    
    #nullable disable
    
}
