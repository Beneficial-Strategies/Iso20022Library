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
/// Fees between acquirer and issuer.
/// </summary>
[IsoId("_YbLAAYKVEeSIRfXNMHH5mQ")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedAmount11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedAmount11( TypeOfAmount7Code reqType,AmountAndDirection41 reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_Trp9AIN-EeSNofOeou9G3A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount7Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount7Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount7Code Type { get; init; } 
    #else
    public TypeOfAmount7Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_YpdTo4KVEeSIRfXNMHH5mQ")]
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
    [IsoId("_YpdTpYKVEeSIRfXNMHH5mQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection41 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection41 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection41 Amount { get; init; } 
    #else
    public AmountAndDirection41 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Original value of the amount.
    /// </summary>
    [IsoId("_YpdTp4KVEeSIRfXNMHH5mQ")]
    [DisplayName("Original Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAmt")]
    #endif
    [IsoXmlTag("OrgnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection41? OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection41? OriginalAmount { get; init; } 
    #else
    public AmountAndDirection41? OriginalAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
