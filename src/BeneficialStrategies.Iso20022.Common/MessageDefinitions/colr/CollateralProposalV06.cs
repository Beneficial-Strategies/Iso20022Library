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
/// This record is an implementation of the colr.007.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralProposal message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager, to propose the collateral to be delivered. This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. This message is used for both initial collateral proposal and subsequent counter proposals.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. The collateral proposal can include securities, cash and other types of collateral.
/// </summary>
[Description(@"Scope|The CollateralProposal message is sent by the collateral giver or its collateral manager to the collateral taker or its collateral manager, to propose the collateral to be delivered. This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. This message is used for both initial collateral proposal and subsequent counter proposals.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|This message is sent once the Margin Call is agreed or partially agreed and can be used for new collateral at the initiation of an exposure or for additional collateral for variation of an existing exposure. The collateral proposal can include securities, cash and other types of collateral.")]
[IsoId("_J4YkVygrEeyB747fKu7_rw")]
[DisplayName("Collateral Proposal V")]
public partial record CollateralProposalV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.007.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollPrpsl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.007.001.06";
    
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
    [IsoId("_J4YkXSgrEeyB747fKu7_rw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YkXygrEeyB747fKu7_rw")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation9 Obligation { get; init; } 
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YkYSgrEeyB747fKu7_rw")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public Agreement4? Agreement { get; init; } 
    
    /// <summary>
    /// Indicates whether this is an initial or counter proposal.
    /// </summary>
    [IsoId("_J4YkYygrEeyB747fKu7_rw")]
    [DisplayName("Type And Details")]
    [IsoXmlTag("TpAndDtls")]
    public required Proposal6 TypeAndDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkZSgrEeyB747fKu7_rw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since CollateralProposalV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralProposalV06.

