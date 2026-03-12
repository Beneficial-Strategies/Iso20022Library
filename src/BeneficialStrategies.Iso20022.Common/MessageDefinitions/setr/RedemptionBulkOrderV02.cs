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
/// This record is an implementation of the setr.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionBulkOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to instruct the executing party to redeem a financial instrument for two or more accounts.
/// Usage
/// The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, ie, account owners, but are the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.
/// This message will be typically used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.
/// For a single redemption order, the RedemptionMultipleOrder message, not the RedemptionBulkOrder message, must be used.
/// If there are redemption orders for different financial instruments but for the same account, then the RedemptionMultipleOrder must be used.
/// </summary>
[Description(@"Scope|The RedemptionBulkOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to instruct the executing party to redeem a financial instrument for two or more accounts.|Usage|The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, ie, account owners, but are the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.|This message will be typically used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.|For a single redemption order, the RedemptionMultipleOrder message, not the RedemptionBulkOrder message, must be used.|If there are redemption orders for different financial instruments but for the same account, then the RedemptionMultipleOrder must be used.")]
[IsoId("_p-h38NE7Ed-BzquC8wXy7w_-1554802764")]
[DisplayName("Redemption Bulk Order V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionBulkOrderV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.001.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.001.001.02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.001.001.02";
    
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
    /// Constructs a RedemptionBulkOrderV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionBulkOrderV02( RedemptionBulkOrder2 reqBulkOrderDetails )
    {
        BulkOrderDetails = reqBulkOrderDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_p-h38dE7Ed-BzquC8wXy7w_-1390267861")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? MasterReference { get; init; } 
    #else
    public AdditionalReference3? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_p-h38tE7Ed-BzquC8wXy7w_-1379184076")]
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
    [IsoId("_p-h389E7Ed-BzquC8wXy7w_-1381034585")]
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
    /// Common information related to all the orders.
    /// </summary>
    [IsoId("_p-h39NE7Ed-BzquC8wXy7w_-1057946997")]
    [DisplayName("Bulk Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlkOrdrDtls")]
    #endif
    [IsoXmlTag("BlkOrdrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RedemptionBulkOrder2 BulkOrderDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RedemptionBulkOrder2 BulkOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionBulkOrder2 BulkOrderDetails { get; init; } 
    #else
    public RedemptionBulkOrder2 BulkOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// The information related to an intermediary.
    /// </summary>
    [IsoId("_p-h39dE7Ed-BzquC8wXy7w_-1159389506")]
    [DisplayName("Intermediary Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmyDtls")]
    #endif
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = new ValueList<Intermediary4>(){};
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_p-ro8NE7Ed-BzquC8wXy7w_-667614163")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation1? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation1? CopyDetails { get; init; } 
    #else
    public CopyInformation1? CopyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_p-ro8dE7Ed-BzquC8wXy7w_-684127238")]
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


// Since RedemptionBulkOrderV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionBulkOrderV02.

