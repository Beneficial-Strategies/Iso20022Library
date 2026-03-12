// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote.
/// </summary>
[IsoId("_Q_N_V9p-Ed-ak6NoX_4Aeg_1962550066")]
[DisplayName("Reference")]
public partial record Reference3
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_XJQNp-Ed-ak6NoX_4Aeg_-2072905893")]
    [DisplayName("Quote Request Identification")]
    [IsoXmlTag("QtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote response.
    /// </summary>
    [IsoId("_Q_XJQdp-Ed-ak6NoX_4Aeg_-642371821")]
    [DisplayName("Quote Response Identification")]
    [IsoXmlTag("QtRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteResponseIdentification { get; init; } 
    
    
    #nullable disable
    
}
