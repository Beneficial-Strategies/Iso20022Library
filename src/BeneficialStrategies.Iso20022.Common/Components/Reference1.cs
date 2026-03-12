// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote request.
/// </summary>
[IsoId("_Q_N_Udp-Ed-ak6NoX_4Aeg_1242651214")]
[DisplayName("Reference")]
public partial record Reference1
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by a sending party to unambiguously identify the request for quote.
    /// </summary>
    [IsoId("_Q_N_Utp-Ed-ak6NoX_4Aeg_1327614016")]
    [DisplayName("Request For Quote Request Identification")]
    [IsoXmlTag("ReqForQtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RequestForQuoteRequestIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of the order as assigned by institution or by the intermediary with closest association with the investor.
    /// </summary>
    [IsoId("_Q_N_U9p-Ed-ak6NoX_4Aeg_-1757819747")]
    [DisplayName("Client Order Identification")]
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    
    
    #nullable disable
    
}
