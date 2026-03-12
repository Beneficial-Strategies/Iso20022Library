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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.008.001.05 ISO standard message type.
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
[IsoId("__b7YQRXfEeOocOqSQt5Jbw")]
[DisplayName("Reversal Of Transfer In Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalOfTransferInConfirmationV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.008.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfInConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.008.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReversalOfTransferInConfirmationV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalOfTransferInConfirmationV05( MessageIdentification1 reqMessageIdentification,Reversal4Choice_ reqReversal )
    {
        MessageIdentification = reqMessageIdentification;
        Reversal = reqReversal;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("__b7YQxXfEeOocOqSQt5Jbw")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.
    /// </summary>
    [IsoId("__b7YRRXfEeOocOqSQt5Jbw")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public References15? References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References15? References { get; init; } 
    #else
    public References15? References { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [IsoId("__b7YRxXfEeOocOqSQt5Jbw")]
    [DisplayName("Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvsl")]
    #endif
    [IsoXmlTag("Rvsl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Reversal4Choice_ Reversal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Reversal4Choice_ Reversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reversal4Choice_ Reversal { get; init; } 
    #else
    public Reversal4Choice_ Reversal { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_eDNL0Rw8EeOIveEnnb_1-A")]
    [DisplayName("Market Practice Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktPrctcVrsn")]
    #endif
    [IsoXmlTag("MktPrctcVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; } 
    #else
    public MarketPracticeVersion1? MarketPracticeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("__b7YSRXfEeOocOqSQt5Jbw")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation2? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation2? CopyDetails { get; init; } 
    #else
    public CopyInformation2? CopyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ReversalOfTransferInConfirmationV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferInConfirmationV05.

