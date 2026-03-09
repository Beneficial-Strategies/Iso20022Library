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
/// Provides the references of the underlying trade leg(s) and/or the reference to the related NetPosition report message.
/// </summary>
[IsoId("_Ql4SRdp-Ed-ak6NoX_4Aeg_1999754651")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference allocated by the central counterparty - central counterpatry trade leg reference identification that uniquely identifies the trade.
    /// </summary>
    [IsoId("_Ql4SRtp-Ed-ak6NoX_4Aeg_1904546885")]
    [DisplayName("Trade Leg Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradLegNtfctnId")]
    #endif
    [IsoXmlTag("TradLegNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TradeLegNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeLegNotificationIdentification { get; init; } 
    #else
    public System.String? TradeLegNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// After netting, reference that is common to a net transaction to settle and all its underlying trades.
    /// </summary>
    [IsoId("_Ql4SR9p-Ed-ak6NoX_4Aeg_-321657762")]
    [DisplayName("Net Position Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPosId")]
    #endif
    [IsoXmlTag("NetPosId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NetPositionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NetPositionIdentification { get; init; } 
    #else
    public System.String? NetPositionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
