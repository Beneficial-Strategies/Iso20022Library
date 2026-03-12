// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the original request. Identifies the message being acknowledged and its status.
/// </summary>
[IsoId("_jHt69O5NEeCisYr99QEiWA_-1586267634")]
[DisplayName("Receipt Acknowledgement Report")]
public partial record ReceiptAcknowledgementReport1
{
    #nullable enable
    
    /// <summary>
    /// Reference of the request.
    /// </summary>
    [IsoId("_jH3E4O5NEeCisYr99QEiWA_-1954136940")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReferences RelatedReference { get; init; } 
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_jH3E4e5NEeCisYr99QEiWA_-375245615")]
    [DisplayName("Request Handling")]
    [IsoXmlTag("ReqHdlg")]
    public required RequestHandling1 RequestHandling { get; init; } 
    
    /// <summary>
    /// Identification of the original message for which the acknowledgement is sent.
    /// </summary>
    [IsoId("_jH3E4u5NEeCisYr99QEiWA_-864664947")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public MessageIdentification6? OriginalMessageIdentification { get; init; } 
    
    
    #nullable disable
    
}
