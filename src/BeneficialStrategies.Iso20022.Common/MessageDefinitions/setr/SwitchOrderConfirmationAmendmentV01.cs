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



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.056.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the SwitchOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SwitchOrderConfirmation message.
/// Usage
/// The SwitchOrderConfirmationAmendment message is used to amend a previously sent switch order confirmation.
/// Each order confirmation amendment specified is identified in DealReference. The reference of the original order is specified in OrderReference.
/// The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference. The message identification of the SwitchOrderConfirmation message in which the original switch order confirmation was conveyed may also be quoted in PreviousReference.
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, sends the SwitchOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SwitchOrderConfirmation message.|Usage|The SwitchOrderConfirmationAmendment message is used to amend a previously sent switch order confirmation.|Each order confirmation amendment specified is identified in DealReference. The reference of the original order is specified in OrderReference.|The message identification of the SwitchOrder message in which the switch order was conveyed may also be quoted in RelatedReference. The message identification of the SwitchOrderConfirmation message in which the original switch order confirmation was conveyed may also be quoted in PreviousReference.")]
[IsoId("_6dPGENE7Ed-BzquC8wXy7w_1688953221")]
[DisplayName("Switch Order Confirmation Amendment V")]
public partial record SwitchOrderConfirmationAmendmentV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.056.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConfAmdmntV01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.056.001.01";
    
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
    [IsoId("_6dPGEdE7Ed-BzquC8wXy7w_-633288534")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_6dPGEtE7Ed-BzquC8wXy7w_-634211438")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_6dPGE9E7Ed-BzquC8wXy7w_-634211065")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_6dPGFNE7Ed-BzquC8wXy7w_-634210463")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Information related to a switch execution.
    /// </summary>
    [IsoId("_6dPGFdE7Ed-BzquC8wXy7w_-633289446")]
    [DisplayName("Switch Execution Details")]
    [IsoXmlTag("SwtchExctnDtls")]
    public required SwitchExecution4 SwitchExecutionDetails { get; init; } 
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_6dPGFtE7Ed-BzquC8wXy7w_-633289972")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6dPGF9E7Ed-BzquC8wXy7w_-633289776")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since SwitchOrderConfirmationAmendmentV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderConfirmationAmendmentV01.

