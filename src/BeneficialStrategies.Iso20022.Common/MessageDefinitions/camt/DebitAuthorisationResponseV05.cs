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



namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.036.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The DebitAuthorisationResponse message is sent by an account owner to its account servicing institution. This message is used to approve or reject a debit authorisation request.
/// Usage
/// The DebitAuthorisationResponse message:
/// - is used to reply to a Debit Authorisation Request message;
/// - covers one and only one payment instruction at a time. If an account owner needs to reply to several DebitAuthorisationRequest messages, then multiple DebitAuthorisationResponse messages must be sent;
/// - indicates whether the account owner agrees with the request by means of a code. It also allows further details to be given about the debit authorisation, such as acceptable amount and value date for the debit;
/// - must be used exclusively between the account owner and the account servicing institution. It must not be used in place of a Resolution Of Investigation message between subsequent agents.
/// </summary>
[Description(@"Scope|The DebitAuthorisationResponse message is sent by an account owner to its account servicing institution. This message is used to approve or reject a debit authorisation request.|Usage|The DebitAuthorisationResponse message:|- is used to reply to a Debit Authorisation Request message;|- covers one and only one payment instruction at a time. If an account owner needs to reply to several DebitAuthorisationRequest messages, then multiple DebitAuthorisationResponse messages must be sent;|- indicates whether the account owner agrees with the request by means of a code. It also allows further details to be given about the debit authorisation, such as acceptable amount and value date for the debit;|- must be used exclusively between the account owner and the account servicing institution. It must not be used in place of a Resolution Of Investigation message between subsequent agents.")]
[IsoId("_eYI_H22PEei3KuUgpx7Xcw")]
[DisplayName("Debit Authorisation Response V")]
public partial record DebitAuthorisationResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.036.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DbtAuthstnRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.036.001.05";
    
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
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eYI_IW2PEei3KuUgpx7Xcw")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment5 Assignment { get; init; } 
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eYI_I22PEei3KuUgpx7Xcw")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case5? Case { get; init; } 
    
    /// <summary>
    /// Indicates if the debit authorisation is granted or not.
    /// </summary>
    [IsoId("_eYI_JW2PEei3KuUgpx7Xcw")]
    [DisplayName("Confirmation")]
    [IsoXmlTag("Conf")]
    public required DebitAuthorisationConfirmation2 Confirmation { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eYI_J22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since DebitAuthorisationResponseV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DebitAuthorisationResponseV05.

