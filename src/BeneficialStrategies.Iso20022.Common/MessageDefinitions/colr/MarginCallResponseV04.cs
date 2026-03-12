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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.004.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MarginCallResponse message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager or vice versa. This is a response to the MarginCallRequest message. The margin call can be accepted, fully disputed or partially disputed.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// When sent by the collateral giver the MarginCallResponse message is used to:
/// - fully accept the MarginCallRequest
/// - or partially accept the MarginCallRequest.
/// 
/// When sent by the collateral taker the MarginCallResponse message is used to:
/// - fully accept the recall of collateral
/// - or partially accept the recall of collateral.
/// </summary>
[Description(@"Scope|The MarginCallResponse message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager or vice versa. This is a response to the MarginCallRequest message. The margin call can be accepted, fully disputed or partially disputed.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When sent by the collateral giver the MarginCallResponse message is used to:|- fully accept the MarginCallRequest|- or partially accept the MarginCallRequest.||When sent by the collateral taker the MarginCallResponse message is used to:|- fully accept the recall of collateral|- or partially accept the recall of collateral.")]
[IsoId("_CRyfw4FsEeWtPe6Crjmeug")]
[DisplayName("Margin Call Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarginCallResponseV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.004.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.004.001.04";
    
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
    /// Constructs a MarginCallResponseV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarginCallResponseV04( System.String reqTransactionIdentification,Obligation4 reqObligation )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_CRyfxYFsEeWtPe6Crjmeug")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_CRyfx4FsEeWtPe6Crjmeug")]
    [DisplayName("Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgtn")]
    #endif
    [IsoXmlTag("Oblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation4 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Obligation4 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation4 Obligation { get; init; } 
    #else
    public Obligation4 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_CRyfyYFsEeWtPe6Crjmeug")]
    [DisplayName("Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agrmt")]
    #endif
    [IsoXmlTag("Agrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement4? Agreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement4? Agreement { get; init; } 
    #else
    public Agreement4? Agreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_CRyfy4FsEeWtPe6Crjmeug")]
    [DisplayName("Margin Details Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnDtlsDueToA")]
    #endif
    [IsoXmlTag("MrgnDtlsDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCall1? MarginDetailsDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCall1? MarginDetailsDueToA { get; init; } 
    #else
    public MarginCall1? MarginDetailsDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_CRyfzYFsEeWtPe6Crjmeug")]
    [DisplayName("Margin Details Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnDtlsDueToB")]
    #endif
    [IsoXmlTag("MrgnDtlsDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarginCall1? MarginDetailsDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarginCall1? MarginDetailsDueToB { get; init; } 
    #else
    public MarginCall1? MarginDetailsDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party A.
    /// </summary>
    [IsoId("_CRyfz4FsEeWtPe6Crjmeug")]
    [DisplayName("Agreed Amount Due To A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdAmtDueToA")]
    #endif
    [IsoXmlTag("AgrdAmtDueToA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreedAmount1Choice_? AgreedAmountDueToA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedAmount1Choice_? AgreedAmountDueToA { get; init; } 
    #else
    public AgreedAmount1Choice_? AgreedAmountDueToA { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party B.
    /// </summary>
    [IsoId("_CRyf0YFsEeWtPe6Crjmeug")]
    [DisplayName("Agreed Amount Due To B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdAmtDueToB")]
    #endif
    [IsoXmlTag("AgrdAmtDueToB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreedAmount1Choice_? AgreedAmountDueToB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedAmount1Choice_? AgreedAmountDueToB { get; init; } 
    #else
    public AgreedAmount1Choice_? AgreedAmountDueToB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides response details about the margin call.
    /// </summary>
    [IsoId("_CRyf04FsEeWtPe6Crjmeug")]
    [DisplayName("Response Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnDtls")]
    #endif
    [IsoXmlTag("RspnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Response1? ResponseDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Response1? ResponseDetails { get; init; } 
    #else
    public Response1? ResponseDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_CRyf1YFsEeWtPe6Crjmeug")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MarginCallResponseV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarginCallResponseV04.

