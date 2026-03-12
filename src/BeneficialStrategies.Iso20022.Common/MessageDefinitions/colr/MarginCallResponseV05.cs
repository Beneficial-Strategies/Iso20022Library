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



namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.004.001.05 ISO standard message type.
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
[IsoId("_J4YkLygrEeyB747fKu7_rw")]
[DisplayName("Margin Call Response V")]
public partial record MarginCallResponseV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.004.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.004.001.05";
    
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
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_J4YkNSgrEeyB747fKu7_rw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YkNygrEeyB747fKu7_rw")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation9 Obligation { get; init; } 
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YkOSgrEeyB747fKu7_rw")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public Agreement4? Agreement { get; init; } 
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_J4YkOygrEeyB747fKu7_rw")]
    [DisplayName("Margin Details Due To A")]
    [IsoXmlTag("MrgnDtlsDueToA")]
    public MarginCall1? MarginDetailsDueToA { get; init; } 
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_J4YkPSgrEeyB747fKu7_rw")]
    [DisplayName("Margin Details Due To B")]
    [IsoXmlTag("MrgnDtlsDueToB")]
    public MarginCall1? MarginDetailsDueToB { get; init; } 
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party A.
    /// </summary>
    [IsoId("_J4YkPygrEeyB747fKu7_rw")]
    [DisplayName("Agreed Amount Due To A")]
    [IsoXmlTag("AgrdAmtDueToA")]
    public AgreedAmount1Choice_? AgreedAmountDueToA { get; init; } 
    
    /// <summary>
    /// Provides details about the agreed amount that would be due to party B.
    /// </summary>
    [IsoId("_J4YkQSgrEeyB747fKu7_rw")]
    [DisplayName("Agreed Amount Due To B")]
    [IsoXmlTag("AgrdAmtDueToB")]
    public AgreedAmount1Choice_? AgreedAmountDueToB { get; init; } 
    
    /// <summary>
    /// Provides response details about the margin call.
    /// </summary>
    [IsoId("_J4YkQygrEeyB747fKu7_rw")]
    [DisplayName("Response Details")]
    [IsoXmlTag("RspnDtls")]
    public Response1? ResponseDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkRSgrEeyB747fKu7_rw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MarginCallResponseV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarginCallResponseV05.

