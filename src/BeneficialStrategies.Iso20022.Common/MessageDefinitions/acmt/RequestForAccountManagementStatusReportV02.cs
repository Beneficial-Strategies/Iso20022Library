// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner, for example, an investor or its designated agent, sends the RequestForAccountManagementStatusReport message to the account servicer, for example, a registrar, transfer agent or custodian bank to request the status of an AccountOpeningInstruction or an AccountModificationInstruction.
/// Usage
/// The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction message or AccountModificationInstruction message for which a AccountDetailsConfirmation message has not yet been received.
/// </summary>
[Description(@"Scope|An account owner, for example, an investor or its designated agent, sends the RequestForAccountManagementStatusReport message to the account servicer, for example, a registrar, transfer agent or custodian bank to request the status of an AccountOpeningInstruction or an AccountModificationInstruction.|Usage|The RequestForAccountManagementStatusReport message is used to request the processing status of a previously sent AccountOpeningInstruction message or AccountModificationInstruction message for which a AccountDetailsConfirmation message has not yet been received.")]
[IsoId("_043Mq9E9Ed-BzquC8wXy7w_2127190710")]
[DisplayName("Request For Account Management Status Report V")]
public partial record RequestForAccountManagementStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForAcctMgmtStsRptV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.005.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_043MrNE9Ed-BzquC8wXy7w_-809277134")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Information to identify the account management instruction for which the status is requested.
    /// </summary>
    [IsoId("_043MrdE9Ed-BzquC8wXy7w_2127190736")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required AccountManagementMessageReference1 RequestDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since RequestForAccountManagementStatusReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForAccountManagementStatusReportV02.

