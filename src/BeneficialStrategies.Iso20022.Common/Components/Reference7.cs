// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote status report.
/// </summary>
[IsoId("_Q_g6Q9p-Ed-ak6NoX_4Aeg_-1651336105")]
[DisplayName("Reference")]
public partial record Reference7
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote.
    /// </summary>
    [IsoId("_Q_g6RNp-Ed-ak6NoX_4Aeg_-819243435")]
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text QuoteIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote status request.
    /// </summary>
    [IsoId("_Q_g6Rdp-Ed-ak6NoX_4Aeg_-851565939")]
    [DisplayName("Quote Status Request Identification")]
    [IsoXmlTag("QtStsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteStatusRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_g6Rtp-Ed-ak6NoX_4Aeg_-793383290")]
    [DisplayName("Quote Request Identification")]
    [IsoXmlTag("QtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote response.
    /// </summary>
    [IsoId("_Q_g6R9p-Ed-ak6NoX_4Aeg_-769371611")]
    [DisplayName("Quote Response Identification")]
    [IsoXmlTag("QtRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteResponseIdentification { get; init; } 
    
    
    #nullable disable
    
}
