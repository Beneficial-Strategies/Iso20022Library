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
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_TEzSnQEcEeCQm6a_G2yO_w_-2106105980")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedAmount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedAmount2( TypeOfAmount2Code reqType,ImpliedCurrencyAndAmount reqValue )
    {
        Type = reqType;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    [IsoId("_TE9DkAEcEeCQm6a_G2yO_w_2075022250")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount2Code Type { get; init; } 
    #else
    public TypeOfAmount2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_TE9DkQEcEeCQm6a_G2yO_w_1077949897")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Value { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Value { get; set; } 
    #endif
    
    /// <summary>
    /// Short description of the amount.
    /// </summary>
    [IsoId("_TE9DkgEcEeCQm6a_G2yO_w_80877544")]
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
