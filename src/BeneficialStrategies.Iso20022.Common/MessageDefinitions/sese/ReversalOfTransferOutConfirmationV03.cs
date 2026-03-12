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
/// This record is an implementation of the sese.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the ReversalOfTransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent TransferOutConfirmation message.
/// Usage
/// The ReversalOfTransferOutConfirmation message is used to reverse a previously sent TransferOutConfirmation.
/// There are two ways to specify the reversal of the transfer out confirmation. Either:
/// - the business references, for example, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,
/// - all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.
/// The message identification of the TransferOutConfirmation message in which the transfer out confirmation was conveyed may also be quoted in PreviousReference. The message identification of the TransferOutInstruction message in which the transfer out instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, sends the ReversalOfTransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent TransferOutConfirmation message.|Usage|The ReversalOfTransferOutConfirmation message is used to reverse a previously sent TransferOutConfirmation.|There are two ways to specify the reversal of the transfer out confirmation. Either:|- the business references, for example, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,|- all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.|The message identification of the TransferOutConfirmation message in which the transfer out confirmation was conveyed may also be quoted in PreviousReference. The message identification of the TransferOutInstruction message in which the transfer out instruction was conveyed may also be quoted in RelatedReference.")]
[IsoId("_0JtHAfpbEeCPwaG9zjUPNQ")]
[DisplayName("Reversal Of Transfer Out Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalOfTransferOutConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.004.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfOutConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.004.001.03";
    
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
    /// Constructs a ReversalOfTransferOutConfirmationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalOfTransferOutConfirmationV03( MessageIdentification1 reqMessageIdentification,References11 reqReferences )
    {
        MessageIdentification = reqMessageIdentification;
        References = reqReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_0JtHDfpbEeCPwaG9zjUPNQ")]
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
    [IsoId("_m7A0v_r2EeCJc7cZxzE2fg")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References11 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References11 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References11 References { get; init; } 
    #else
    public References11 References { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the transfer out confirmation to be reversed.
    /// </summary>
    [IsoId("_0JtHHfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Reversal By Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslByRef")]
    #endif
    [IsoXmlTag("RvslByRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferReference2? ReversalByReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReference2? ReversalByReference { get; init; } 
    #else
    public TransferReference2? ReversalByReference { get; set; } 
    #endif
    
    /// <summary>
    /// Copy of the transfer out confirmation to reverse.
    /// </summary>
    [IsoId("_0JtHIfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Reversal By Transfer Out Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslByTrfOutConfDtls")]
    #endif
    [IsoXmlTag("RvslByTrfOutConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferOut8? ReversalByTransferOutConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferOut8? ReversalByTransferOutConfirmationDetails { get; init; } 
    #else
    public TransferOut8? ReversalByTransferOutConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_0JtHJfpbEeCPwaG9zjUPNQ")]
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


// Since ReversalOfTransferOutConfirmationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferOutConfirmationV03.

