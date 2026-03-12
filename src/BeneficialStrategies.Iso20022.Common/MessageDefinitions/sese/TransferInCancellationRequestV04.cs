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
/// This record is an implementation of the sese.006.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, a transfer agent, sends the TransferInCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.
/// Usage
/// The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.
/// There are two ways to specify the transfer cancellation request. Either:
/// - the transfer reference of the original transfer is quoted, or,
/// - all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.
/// The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference.
/// </summary>
[Description(@"Scope|An instructing party, for example, a transfer agent, sends the TransferInCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.|Usage|The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.|There are two ways to specify the transfer cancellation request. Either:|- the transfer reference of the original transfer is quoted, or,|- all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.|The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference.")]
[IsoId("_EmP8gRgCEeKqWJINzXcn5g")]
[DisplayName("Transfer In Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferInCancellationRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.006.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.04";
    
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
    /// Constructs a TransferInCancellationRequestV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferInCancellationRequestV04( MessageIdentification1 reqMessageIdentification,References11 reqReferences,Cancellation2Choice_ reqCancellation )
    {
        MessageIdentification = reqMessageIdentification;
        References = reqReferences;
        Cancellation = reqCancellation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_EmP8ixgCEeKqWJINzXcn5g")]
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
    [IsoId("_EmP8jxgCEeKqWJINzXcn5g")]
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
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [IsoId("_B1tJ5Rg2EeK-_89we2b-bA")]
    [DisplayName("Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cxl")]
    #endif
    [IsoXmlTag("Cxl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Cancellation2Choice_ Cancellation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Cancellation2Choice_ Cancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Cancellation2Choice_ Cancellation { get; init; } 
    #else
    public Cancellation2Choice_ Cancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_EmP8mxgCEeKqWJINzXcn5g")]
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


// Since TransferInCancellationRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInCancellationRequestV04.

