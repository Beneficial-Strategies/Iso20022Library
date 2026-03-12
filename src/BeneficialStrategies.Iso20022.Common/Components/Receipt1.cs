// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the request.
/// </summary>
[IsoId("_746ppqMgEeCJ6YNENx4h-w_-1799961692")]
[DisplayName("Receipt")]
public partial record Receipt1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the original request message.
    /// </summary>
    [IsoId("_746pp6MgEeCJ6YNENx4h-w_-1913800758")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_75DzkKMgEeCJ6YNENx4h-w_1497933251")]
    [DisplayName("Request Handling")]
    [IsoXmlTag("ReqHdlg")]
    public RequestHandling? RequestHandling { get; init; } 
    
    
    #nullable disable
    
}
