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
/// Additional references linked to the order cancel request.
/// </summary>
[IsoId("_Q_qrQ9p-Ed-ak6NoX_4Aeg_213456320")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference9( System.String reqOriginalClientOrderIdentification )
    {
        OriginalClientOrderIdentification = reqOriginalClientOrderIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Client order identification of the previous non-rejected order (not the initial order of the day) when canceling or replacing an order.
    /// </summary>
    [IsoId("_Q_qrRNp-Ed-ak6NoX_4Aeg_731552924")]
    [DisplayName("Original Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlClntOrdrId")]
    #endif
    [IsoXmlTag("OrgnlClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalClientOrderIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalClientOrderIdentification { get; init; } 
    #else
    public System.String OriginalClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of most recent order as assigned by sell-side (broker, exchange.).
    /// </summary>
    [IsoId("_Q_qrRdp-Ed-ak6NoX_4Aeg_1075102845")]
    [DisplayName("Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrId")]
    #endif
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OrderIdentification { get; init; } 
    #else
    public System.String? OrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// TransactionTime of the last state change that occurred to the original order. The original order modification time is provided as an optional field in the order modification request to identify that the state of the order has not changed since the request was issued.
    /// </summary>
    [IsoId("_Q_qrRtp-Ed-ak6NoX_4Aeg_1493832227")]
    [DisplayName("Original Order Modification Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlOrdrModTm")]
    #endif
    [IsoXmlTag("OrgnlOrdrModTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OriginalOrderModificationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OriginalOrderModificationTime { get; init; } 
    #else
    public System.DateTime? OriginalOrderModificationTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
