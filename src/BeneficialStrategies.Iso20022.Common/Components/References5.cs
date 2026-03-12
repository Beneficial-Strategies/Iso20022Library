// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements for the identification of the message and related references.
/// </summary>
[IsoId("_QoQ359p-Ed-ak6NoX_4Aeg_823875605")]
[DisplayName("References")]
public partial record References5
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of acknowledged request.
    /// </summary>
    [IsoId("_QoQ36Np-Ed-ak6NoX_4Aeg_1346590787")]
    [DisplayName("Request Type")]
    [IsoXmlTag("ReqTp")]
    public required UseCases1Code RequestType { get; init; } 
    
    /// <summary>
    /// Identifies a message by a unique identifier and the date and time when the message was created by the sender.
    /// </summary>
    [IsoId("_Qoao4Np-Ed-ak6NoX_4Aeg_-1175229632")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Identifies a process by a unique identifier and the date and time when the first message belonging to the process was created by the sender. The process identification remains the same in all messages belonging to the same process, from the initial request message to the final account report closing the process.
    /// </summary>
    [IsoId("_Qoao4dp-Ed-ak6NoX_4Aeg_-790121373")]
    [DisplayName("Process Identification")]
    [IsoXmlTag("PrcId")]
    public required MessageIdentification1 ProcessIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the message that is acknowledged.
    /// </summary>
    [IsoId("_Qoao4tp-Ed-ak6NoX_4Aeg_-1789477840")]
    [DisplayName("Acknowledged Message Identification")]
    [IsoXmlTag("AckdMsgId")]
    public MessageIdentification1? AcknowledgedMessageIdentification { get; init; } 
    
    /// <summary>
    /// Status of the request.
    /// </summary>
    [IsoId("_Qoao49p-Ed-ak6NoX_4Aeg_-17664747")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Status { get; init; } 
    
    /// <summary>
    /// File name of a document logically related to the request.
    /// </summary>
    [IsoId("_Qoao5Np-Ed-ak6NoX_4Aeg_186950521")]
    [DisplayName("Attached Document Name")]
    [IsoXmlTag("AttchdDocNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AttachedDocumentName { get; init; } 
    
    
    #nullable disable
    
}
