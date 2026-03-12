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
/// This record is an implementation of the sese.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, eg, a transfer agent, sends the TransferInCancellationRequest message to the executing party, eg, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.
/// Usage
/// The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.
/// There are two ways to specify the transfer cancellation request. Either:
/// - the transfer reference of the original transfer is quoted, or,
/// - all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.
/// The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference.
/// </summary>
[Description(@"Scope|An instructing party, eg, a transfer agent, sends the TransferInCancellationRequest message to the executing party, eg, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.|Usage|The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.|There are two ways to specify the transfer cancellation request. Either:|- the transfer reference of the original transfer is quoted, or,|- all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.|The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference.")]
[IsoId("_Iq5JiNE6Ed-BzquC8wXy7w_-1614969547")]
[DisplayName("Transfer In Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferInCancellationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInCxlReqV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.02";
    
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
    /// Constructs a TransferInCancellationRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferInCancellationRequestV02( MessageIdentification1 reqMessageIdentification )
    {
        MessageIdentification = reqMessageIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Iq5JidE6Ed-BzquC8wXy7w_-713613405")]
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
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Iq5JitE6Ed-BzquC8wXy7w_-1614969527")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PreviousReference { get; init; } 
    #else
    public AdditionalReference2? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Iq5Ji9E6Ed-BzquC8wXy7w_-1614049462")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PoolReference { get; init; } 
    #else
    public AdditionalReference2? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Iq5JjNE6Ed-BzquC8wXy7w_-1614049497")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? RelatedReference { get; init; } 
    #else
    public AdditionalReference2? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_IrCTcNE6Ed-BzquC8wXy7w_-2096566826")]
    [DisplayName("Cancellation By Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByRef")]
    #endif
    [IsoXmlTag("CxlByRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferReference1? CancellationByReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReference1? CancellationByReference { get; init; } 
    #else
    public TransferReference1? CancellationByReference { get; set; } 
    #endif
    
    /// <summary>
    /// The transfer in request message to cancel.
    /// </summary>
    [IsoId("_IrCTcdE6Ed-BzquC8wXy7w_-1614049514")]
    [DisplayName("Cancellation By Transfer In Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByTrfInDtls")]
    #endif
    [IsoXmlTag("CxlByTrfInDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferIn3? CancellationByTransferInDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferIn3? CancellationByTransferInDetails { get; init; } 
    #else
    public TransferIn3? CancellationByTransferInDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_IrCTctE6Ed-BzquC8wXy7w_319701879")]
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


// Since TransferInCancellationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInCancellationRequestV02.

