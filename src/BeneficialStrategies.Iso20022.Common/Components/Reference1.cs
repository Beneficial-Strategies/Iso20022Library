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
/// Additional references linked to the quote request.
/// </summary>
[IsoId("_Q_N_Udp-Ed-ak6NoX_4Aeg_1242651214")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned by a sending party to unambiguously identify the request for quote.
    /// </summary>
    [IsoId("_Q_N_Utp-Ed-ak6NoX_4Aeg_1327614016")]
    [DisplayName("Request For Quote Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqForQtReqId")]
    #endif
    [IsoXmlTag("ReqForQtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RequestForQuoteRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestForQuoteRequestIdentification { get; init; } 
    #else
    public System.String? RequestForQuoteRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the order as assigned by institution or by the intermediary with closest association with the investor.
    /// </summary>
    [IsoId("_Q_N_U9p-Ed-ak6NoX_4Aeg_-1757819747")]
    [DisplayName("Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntOrdrId")]
    #endif
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientOrderIdentification { get; init; } 
    #else
    public System.String? ClientOrderIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
