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
/// This record is an implementation of the sese.008.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the ReversalOfTransferInConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent TransferInConfirmation message.
/// Usage
/// The ReversalOfTransferInConfirmation message is used to reverse a previously sent TransferInConfirmation.
/// There are two ways to specify the reversal of the transfer in confirmation. Either:
/// - the business references, for example, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,
/// - all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.
/// The message identification of the TransferInConfirmation message in which the transfer confirmation was conveyed may also be quoted in PreviousReference.
/// The message reference (MessageIdentification) of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// 
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, sends the ReversalOfTransferInConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent TransferInConfirmation message.|Usage|The ReversalOfTransferInConfirmation message is used to reverse a previously sent TransferInConfirmation.|There are two ways to specify the reversal of the transfer in confirmation. Either:|- the business references, for example, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,|- all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.|The message identification of the TransferInConfirmation message in which the transfer confirmation was conveyed may also be quoted in PreviousReference.|The message reference (MessageIdentification) of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|")]
[IsoId("_BL8wcR8OEeWpZde3LQh6dg")]
[DisplayName("Reversal Of Transfer In Confirmation V")]
public partial record ReversalOfTransferInConfirmationV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.008.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfInConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.008.001.07";
    
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
    [IsoId("_BL8wcx8OEeWpZde3LQh6dg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.
    /// </summary>
    [IsoId("_BL8wdR8OEeWpZde3LQh6dg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public References20? References { get; init; } 
    
    /// <summary>
    /// Function of the transfer-in, that is, whether the message is used as a reversal of a previously sent confirmation or as a reversal of a previously sent advice. The absence of Function indicates the message is a reversal of a previously sent confirmation.
    /// </summary>
    [IsoId("_iHBxcSVQEeWI0orciOKunQ")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public TransferInFunction2Code? Function { get; init; } 
    
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [IsoId("_BL8wdx8OEeWpZde3LQh6dg")]
    [DisplayName("Reversal")]
    [IsoXmlTag("Rvsl")]
    public required Reversal7Choice_ Reversal { get; init; } 
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_BL8weR8OEeWpZde3LQh6dg")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_BL8wex8OEeWpZde3LQh6dg")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since ReversalOfTransferInConfirmationV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferInConfirmationV07.

