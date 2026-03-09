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
/// Additional references linked to the quote status report.
/// </summary>
[IsoId("_Q_g6Q9p-Ed-ak6NoX_4Aeg_-1651336105")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference7( System.String reqQuoteIdentification )
    {
        QuoteIdentification = reqQuoteIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote.
    /// </summary>
    [IsoId("_Q_g6RNp-Ed-ak6NoX_4Aeg_-819243435")]
    [DisplayName("Quote Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtId")]
    #endif
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text QuoteIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QuoteIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QuoteIdentification { get; init; } 
    #else
    public System.String QuoteIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for quote status request.
    /// </summary>
    [IsoId("_Q_g6Rdp-Ed-ak6NoX_4Aeg_-851565939")]
    [DisplayName("Quote Status Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtStsReqId")]
    #endif
    [IsoXmlTag("QtStsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QuoteStatusRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QuoteStatusRequestIdentification { get; init; } 
    #else
    public System.String? QuoteStatusRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_g6Rtp-Ed-ak6NoX_4Aeg_-793383290")]
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
    [IsoId("_Q_g6R9p-Ed-ak6NoX_4Aeg_-769371611")]
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
