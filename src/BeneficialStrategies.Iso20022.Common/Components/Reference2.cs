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
/// Additional references linked to the quote request reject.
/// </summary>
[IsoId("_Q_N_VNp-Ed-ak6NoX_4Aeg_-24093044")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference2( System.String reqQuoteRequestIdentification )
    {
        QuoteRequestIdentification = reqQuoteRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_N_Vdp-Ed-ak6NoX_4Aeg_50714865")]
    [DisplayName("Quote Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtReqId")]
    #endif
    [IsoXmlTag("QtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text QuoteRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QuoteRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QuoteRequestIdentification { get; init; } 
    #else
    public System.String QuoteRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier used to identify a request for quote request.
    /// </summary>
    [IsoId("_Q_N_Vtp-Ed-ak6NoX_4Aeg_68261212")]
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
    
    
    #nullable disable
    
}
