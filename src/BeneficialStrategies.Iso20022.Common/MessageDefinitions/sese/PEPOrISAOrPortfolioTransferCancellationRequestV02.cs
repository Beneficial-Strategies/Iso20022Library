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



namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.014.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, eg, a (new) plan manager, sends the PEPOrISAOrPortfolioTransferCancellationRequest message to the executing party, eg, a (old) plan manager, to request the cancellation of a previously sent PEPOrISAOrPortfolioTransferInstruction.
/// Usage
/// The PEPOrISAOrPortfolioTransferCancellationRequest message is used to request the cancellation of an entire PEPOrISAOrPortfolioTransferInstruction message, ie, all the product transfers that it contained. The cancellation request can be specified either by:
/// - quoting the transfer references of all the product transfers listed in the PEPOrISAOrPortfolioTransferInstruction message, or,
/// - quoting the details of all the product transfers (this includes TransferReference) listed in PEPOrISAOrPortfolioTransferInstruction message.
/// The message identification of the PEPOrISAOrPortfolioTransferInstruction may also be quoted in PreviousReference. It is also possible to request the cancellation of PEPOrISAOrPortfolioTransferInstruction by just quoting its message identification in PreviousReference.
/// </summary>
[Description(@"Scope|An instructing party, eg, a (new) plan manager, sends the PEPOrISAOrPortfolioTransferCancellationRequest message to the executing party, eg, a (old) plan manager, to request the cancellation of a previously sent PEPOrISAOrPortfolioTransferInstruction.|Usage|The PEPOrISAOrPortfolioTransferCancellationRequest message is used to request the cancellation of an entire PEPOrISAOrPortfolioTransferInstruction message, ie, all the product transfers that it contained. The cancellation request can be specified either by:|- quoting the transfer references of all the product transfers listed in the PEPOrISAOrPortfolioTransferInstruction message, or,|- quoting the details of all the product transfers (this includes TransferReference) listed in PEPOrISAOrPortfolioTransferInstruction message.|The message identification of the PEPOrISAOrPortfolioTransferInstruction may also be quoted in PreviousReference. It is also possible to request the cancellation of PEPOrISAOrPortfolioTransferInstruction by just quoting its message identification in PreviousReference.")]
[IsoId("_j9ueC9E5Ed-BzquC8wXy7w_493377092")]
[DisplayName("PEP Or ISA Or Portfolio Transfer Cancellation Request V")]
public partial record PEPOrISAOrPortfolioTransferCancellationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.014.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PEPOrISAOrPrtflTrfCxlReqV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.014.001.02";
    
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
    /// Identifies the message.
    /// </summary>
    [IsoId("_j93n8NE5Ed-BzquC8wXy7w_-331528290")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    public required MessageIdentification1 MessageReference { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_j93n8dE5Ed-BzquC8wXy7w_-104340078")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_j93n8tE5Ed-BzquC8wXy7w_614157736")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_j93n89E5Ed-BzquC8wXy7w_716668915")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; } 
    
    /// <summary>
    /// Information related to the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_j93n9NE5Ed-BzquC8wXy7w_-1688908693")]
    [DisplayName("Cancellation By Transfer Instruction Details")]
    [IsoXmlTag("CxlByTrfInstrDtls")]
    public PEPISATransfer7? CancellationByTransferInstructionDetails { get; init; } 
    
    /// <summary>
    /// Reference of the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_j93n9dE5Ed-BzquC8wXy7w_600500394")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public TransferReference3? CancellationByReference { get; init; } 
    
    
    #nullable disable
    
}


// Since PEPOrISAOrPortfolioTransferCancellationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PEPOrISAOrPortfolioTransferCancellationRequestV02.

