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
/// Describes an instance of an intraday margin call being made against a margin account.
/// </summary>
[IsoId("_dC8lAEG6EemxGPEh9hU2Xg")]
[DisplayName("Intra Day Margin Call")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraDayMarginCall1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IntraDayMarginCall1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraDayMarginCall1( GenericIdentification165 reqMarginAccountIdentification,ActiveCurrencyAndAmount reqIntraDayCall,System.DateTime reqTimeStamp )
    {
        MarginAccountIdentification = reqMarginAccountIdentification;
        IntraDayCall = reqIntraDayCall;
        TimeStamp = reqTimeStamp;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the margin account against which the intraday margin call is being made.
    /// </summary>
    [IsoId("_rCkhkEG6EemxGPEh9hU2Xg")]
    [DisplayName("Margin Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnAcctId")]
    #endif
    [IsoXmlTag("MrgnAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification165 MarginAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification165 MarginAccountIdentification { get; init; } 
    #else
    public GenericIdentification165 MarginAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the call being made.
    /// </summary>
    [IsoId("_7dvTgEG6EemxGPEh9hU2Xg")]
    [DisplayName("Intra Day Call")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraDayCall")]
    #endif
    [IsoXmlTag("IntraDayCall")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount IntraDayCall { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount IntraDayCall { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount IntraDayCall { get; init; } 
    #else
    public ActiveCurrencyAndAmount IntraDayCall { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the margin call was made.
    /// </summary>
    [IsoId("_AaCOYEG7EemxGPEh9hU2Xg")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TimeStamp { get; init; } 
    #else
    public System.DateTime TimeStamp { get; set; } 
    #endif
    
    
    #nullable disable
    
}
