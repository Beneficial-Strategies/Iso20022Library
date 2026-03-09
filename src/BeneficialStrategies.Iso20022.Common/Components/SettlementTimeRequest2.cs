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
/// Provides information on the requested settlement time(s) of the payment instruction.
/// </summary>
[IsoId("_QIrY6dp-Ed-ak6NoX_4Aeg_2050617089")]
[DisplayName("Settlement Time Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementTimeRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Time by which the amount of money must be credited, with confirmation, to the CLS Bank&apos;s account at the central bank.|Usage: Time must be expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QIrY6tp-Ed-ak6NoX_4Aeg_2050617120")]
    [DisplayName("CLS Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CLSTm")]
    #endif
    [IsoXmlTag("CLSTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? CLSTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? CLSTime { get; init; } 
    #else
    public System.TimeOnly? CLSTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time until when the payment may be settled.
    /// </summary>
    [IsoId("_QIrY69p-Ed-ak6NoX_4Aeg_2142970270")]
    [DisplayName("Till Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TillTm")]
    #endif
    [IsoXmlTag("TillTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? TillTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? TillTime { get; init; } 
    #else
    public System.TimeOnly? TillTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time as from when the payment may be settled.
    /// </summary>
    [IsoId("_QIrY7Np-Ed-ak6NoX_4Aeg_2123575201")]
    [DisplayName("From Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrTm")]
    #endif
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? FromTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? FromTime { get; init; } 
    #else
    public System.TimeOnly? FromTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time by when the payment must be settled to avoid rejection.
    /// </summary>
    [IsoId("_QI1J4Np-Ed-ak6NoX_4Aeg_2138351566")]
    [DisplayName("Reject Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctTm")]
    #endif
    [IsoXmlTag("RjctTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? RejectTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? RejectTime { get; init; } 
    #else
    public System.TimeOnly? RejectTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
