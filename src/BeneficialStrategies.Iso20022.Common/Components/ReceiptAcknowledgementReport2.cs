// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original request. Identifies the message being acknowledged and its status
/// </summary>
[IsoId("_WhpTYZb4Eee4htziCyV8eA")]
[DisplayName("Receipt Acknowledgement Report")]
public partial record ReceiptAcknowledgementReport2
{
    #nullable enable
    
    /// <summary>
    /// Reference of the request.
    /// </summary>
    [IsoId("_Wrd9wZb4Eee4htziCyV8eA")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required MessageReference1 RelatedReference { get; init; } 
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_Wrd9w5b4Eee4htziCyV8eA")]
    [DisplayName("Request Handling")]
    [IsoXmlTag("ReqHdlg")]
    public required RequestHandling2 RequestHandling { get; init; } 
    
    
    #nullable disable
    
}
