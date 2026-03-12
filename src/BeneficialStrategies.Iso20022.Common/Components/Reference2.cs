// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote request reject.
/// </summary>
[IsoId("_Q_N_VNp-Ed-ak6NoX_4Aeg_-24093044")]
[DisplayName("Reference")]
public partial record Reference2
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_N_Vdp-Ed-ak6NoX_4Aeg_50714865")]
    [DisplayName("Quote Request Identification")]
    [IsoXmlTag("QtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text QuoteRequestIdentification { get; init; } 
    
    /// <summary>
    /// Identifier used to identify a request for quote request.
    /// </summary>
    [IsoId("_Q_N_Vtp-Ed-ak6NoX_4Aeg_68261212")]
    [DisplayName("Request For Quote Request Identification")]
    [IsoXmlTag("ReqForQtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RequestForQuoteRequestIdentification { get; init; } 
    
    
    #nullable disable
    
}
