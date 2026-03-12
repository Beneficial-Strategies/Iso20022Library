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


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the RedemptionBulkOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of execution for a previously received RedemptionBulkOrder message.
/// Usage
/// The RedemptionBulkOrderConfirmation message is used to confirm the execution of all individual orders included in a previously sent RedemptionBulkOrder message.
/// There is usually one bulk confirmation message for one bulk order message.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionBulkOrder message in which the individual order was conveyed may also be quoted in RelatedReference, but this is not recommended.
/// A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionOrderConfirmation.
/// If the executing party needs to confirm a RedemptionOrder instruction, then the RedemptionOrderConfirmation must be used.
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, sends the RedemptionBulkOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of execution for a previously received RedemptionBulkOrder message.|Usage|The RedemptionBulkOrderConfirmation message is used to confirm the execution of all individual orders included in a previously sent RedemptionBulkOrder message.|There is usually one bulk confirmation message for one bulk order message.|Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionBulkOrder message in which the individual order was conveyed may also be quoted in RelatedReference, but this is not recommended.|A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionOrderConfirmation.|If the executing party needs to confirm a RedemptionOrder instruction, then the RedemptionOrderConfirmation must be used.")]
[IsoId("_pkm8ENE7Ed-BzquC8wXy7w_-2035015810")]
[DisplayName("Redemption Bulk Order Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionBulkOrderConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedBlkOrdrConfV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.003.001.03";
    
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
    /// Constructs a RedemptionBulkOrderConfirmationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionBulkOrderConfirmationV03( MessageIdentification1 reqMessageIdentification,RedemptionBulkExecution3 reqBulkExecutionDetails )
    {
        MessageIdentification = reqMessageIdentification;
        BulkExecutionDetails = reqBulkExecutionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_pkm8EdE7Ed-BzquC8wXy7w_1891903137")]
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
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_pkm8EtE7Ed-BzquC8wXy7w_-1579721033")]
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
    [IsoId("_pkm8E9E7Ed-BzquC8wXy7w_-1564944521")]
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
    [IsoId("_pkm8FNE7Ed-BzquC8wXy7w_-1577870531")]
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
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_pkm8FdE7Ed-BzquC8wXy7w_-260009400")]
    [DisplayName("Bulk Execution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkExctnDtls")]
    #endif
    [IsoXmlTag("BlkExctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RedemptionBulkExecution3 BulkExecutionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RedemptionBulkExecution3 BulkExecutionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionBulkExecution3 BulkExecutionDetails { get; init; } 
    #else
    public RedemptionBulkExecution3 BulkExecutionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_pkm8FtE7Ed-BzquC8wXy7w_-1123500614")]
    [DisplayName("Related Party Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdPtyDtls")]
    #endif
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = new ValueList<Intermediary9>(){};
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_pkwGANE7Ed-BzquC8wXy7w_-1119805484")]
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
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pkwGAdE7Ed-BzquC8wXy7w_-1117957647")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RedemptionBulkOrderConfirmationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionBulkOrderConfirmationV03.

