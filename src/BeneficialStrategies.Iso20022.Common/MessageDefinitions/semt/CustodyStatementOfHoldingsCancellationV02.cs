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



namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a transfer agent, sends the CustodyStatementOfHoldingsCancellation message to the account owner, for example, an investment manager or its authorised representative to cancel a previously sent CustodyStatementOfHoldings message.
/// Usage
/// The CustodyStatementOfHoldingsCancellation message is used to cancel a previously sent CustodyStatementOfHoldings message. This message must contain the reference of the message to be cancelled.
/// This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(@"Scope|An account servicer, for example, a transfer agent, sends the CustodyStatementOfHoldingsCancellation message to the account owner, for example, an investment manager or its authorised representative to cancel a previously sent CustodyStatementOfHoldings message.|Usage|The CustodyStatementOfHoldingsCancellation message is used to cancel a previously sent CustodyStatementOfHoldings message. This message must contain the reference of the message to be cancelled.|This message may also contain details of the message to be cancelled, but this is not recommended.")]
[IsoId("_Mb_vvNFSEd-BzquC8wXy7w_-145472728")]
[DisplayName("Custody Statement Of Holdings Cancellation V")]
public partial record CustodyStatementOfHoldingsCancellationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.004.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CtdyStmtOfHldgsCxlV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.004.001.02";
    
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
    [IsoId("_Mb_vvdFSEd-BzquC8wXy7w_682925728")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Mb_vvtFSEd-BzquC8wXy7w_-145472685")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Mb_vv9FSEd-BzquC8wXy7w_-145472650")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; } 
    
    /// <summary>
    /// Number used to sequence pages when it is not possible for data to be conveyed in a single message and the data has to be split across several pages (messages).
    /// </summary>
    [IsoId("_McJgsNFSEd-BzquC8wXy7w_-145472572")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public required Pagination MessagePagination { get; init; } 
    
    /// <summary>
    /// The Custody Statement of Holdings message to cancel.
    /// </summary>
    [IsoId("_McJgsdFSEd-BzquC8wXy7w_-145472607")]
    [DisplayName("Statement To Be Cancelled")]
    [IsoXmlTag("StmtToBeCanc")]
    public CustodyStatementOfHoldings2? StatementToBeCancelled { get; init; } 
    
    
    #nullable disable
    
}


// Since CustodyStatementOfHoldingsCancellationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustodyStatementOfHoldingsCancellationV02.

