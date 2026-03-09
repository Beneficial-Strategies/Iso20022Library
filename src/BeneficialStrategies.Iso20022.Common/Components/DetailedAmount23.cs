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
/// Breakdown of the transaction amount.
/// </summary>
[IsoId("_5bTz0ZMgEeuleeHpFMMhmQ")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedAmount23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedAmount23( DetailAmount2Code reqType,Amount16 reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_5iOUIZMgEeuleeHpFMMhmQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DetailAmount2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DetailAmount2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailAmount2Code Type { get; init; } 
    #else
    public DetailAmount2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_5iOUI5MgEeuleeHpFMMhmQ")]
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
    [IsoId("_5iOUJZMgEeuleeHpFMMhmQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount16 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount16 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount16 Amount { get; init; } 
    #else
    public Amount16 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    [IsoId("_5iOUJ5MgEeuleeHpFMMhmQ")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
