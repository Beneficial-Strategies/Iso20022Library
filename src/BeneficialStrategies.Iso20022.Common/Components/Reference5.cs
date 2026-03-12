// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote response.
/// </summary>
[IsoId("_Q_XJRdp-Ed-ak6NoX_4Aeg_-1514589671")]
[DisplayName("Reference")]
public partial record Reference5
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote.
    /// </summary>
    [IsoId("_Q_XJRtp-Ed-ak6NoX_4Aeg_-1441632347")]
    [DisplayName("Quote Identification")]
    [IsoXmlTag("QtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [IsoId("_Q_XJR9p-Ed-ak6NoX_4Aeg_-1422237590")]
    [DisplayName("Quote Request Identification")]
    [IsoXmlTag("QtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? QuoteRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of indication of interest message.
    /// </summary>
    [IsoId("_Q_XJSNp-Ed-ak6NoX_4Aeg_-968835175")]
    [DisplayName("IOI Identification")]
    [IsoXmlTag("IOIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IOIIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier for order as assigned by the buy-side ( institution, broker, intermediary.).
    /// </summary>
    [IsoId("_Q_g6QNp-Ed-ak6NoX_4Aeg_904753611")]
    [DisplayName("Client Order Identification")]
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    
    
    #nullable disable
    
}
