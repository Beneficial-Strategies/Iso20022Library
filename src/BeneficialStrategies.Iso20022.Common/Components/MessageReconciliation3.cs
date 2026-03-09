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
/// Contains message reconciliation data.
/// </summary>
[IsoId("_LngKISFNEey8XKHwKquEQw")]
[DisplayName("Message Reconciliation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageReconciliation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageReconciliation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageReconciliation3( ReconciliationMessageType2Code reqType,System.UInt64 reqCount )
    {
        Type = reqType;
        Count = reqCount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the reconciliation message type.
    /// </summary>
    [IsoId("_LuaDYSFNEey8XKHwKquEQw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationMessageType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationMessageType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationMessageType2Code Type { get; init; } 
    #else
    public ReconciliationMessageType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other reconciliation message type defined at national or private level.
    /// </summary>
    [IsoId("_LuaDYyFNEey8XKHwKquEQw")]
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
    /// Number of transactions.
    /// </summary>
    [IsoId("_LuaDZSFNEey8XKHwKquEQw")]
    [DisplayName("Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnt")]
    #endif
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Count { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Count { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Count { get; init; } 
    #else
    public System.UInt64 Count { get; set; } 
    #endif
    
    
    #nullable disable
    
}
