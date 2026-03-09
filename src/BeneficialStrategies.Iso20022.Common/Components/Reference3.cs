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
/// Additional references linked to the quote.
/// </summary>
[IsoId("_Q_N_V9p-Ed-ak6NoX_4Aeg_1962550066")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_XJQNp-Ed-ak6NoX_4Aeg_-2072905893")]
    [DisplayName("Quote Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtReqId")]
    #endif
    [IsoXmlTag("QtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QuoteRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QuoteRequestIdentification { get; init; } 
    #else
    public System.String? QuoteRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for quote response.
    /// </summary>
    [IsoId("_Q_XJQdp-Ed-ak6NoX_4Aeg_-642371821")]
    [DisplayName("Quote Response Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtRspnId")]
    #endif
    [IsoXmlTag("QtRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QuoteResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QuoteResponseIdentification { get; init; } 
    #else
    public System.String? QuoteResponseIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
