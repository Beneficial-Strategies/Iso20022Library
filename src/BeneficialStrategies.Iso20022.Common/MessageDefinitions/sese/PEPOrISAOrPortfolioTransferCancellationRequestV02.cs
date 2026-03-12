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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PEPOrISAOrPortfolioTransferCancellationRequestV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PEPOrISAOrPortfolioTransferCancellationRequestV02( MessageIdentification1 reqMessageReference )
    {
        MessageReference = reqMessageReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_j93n8NE5Ed-BzquC8wXy7w_-331528290")]
    [DisplayName("Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRef")]
    #endif
    [IsoXmlTag("MsgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageReference { get; init; } 
    #else
    public MessageIdentification1 MessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_j93n8dE5Ed-BzquC8wXy7w_-104340078")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PoolReference { get; init; } 
    #else
    public AdditionalReference3? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_j93n8tE5Ed-BzquC8wXy7w_614157736")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_j93n89E5Ed-BzquC8wXy7w_716668915")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? RelatedReference { get; init; } 
    #else
    public AdditionalReference3? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_j93n9NE5Ed-BzquC8wXy7w_-1688908693")]
    [DisplayName("Cancellation By Transfer Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByTrfInstrDtls")]
    #endif
    [IsoXmlTag("CxlByTrfInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PEPISATransfer7? CancellationByTransferInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PEPISATransfer7? CancellationByTransferInstructionDetails { get; init; } 
    #else
    public PEPISATransfer7? CancellationByTransferInstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_j93n9dE5Ed-BzquC8wXy7w_600500394")]
    [DisplayName("Cancellation By Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByRef")]
    #endif
    [IsoXmlTag("CxlByRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferReference3? CancellationByReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReference3? CancellationByReference { get; init; } 
    #else
    public TransferReference3? CancellationByReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PEPOrISAOrPortfolioTransferCancellationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PEPOrISAOrPortfolioTransferCancellationRequestV02.

