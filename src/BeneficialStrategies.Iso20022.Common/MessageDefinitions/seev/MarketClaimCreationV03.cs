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



namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.050.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_g4ztEX_5Ee-h086v0qPiyQ")]
[DisplayName("Market Claim Creation V03")]
public partial record MarketClaimCreationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.050.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmCre";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.050.001.03";
    
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
    /// Account Details.
    /// </summary>
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification70 AccountDetails { get; init; } 
    
    /// <summary>
    /// Corporate Action Details.
    /// </summary>
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction59? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation181 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Delivering Settlement Parties.
    /// </summary>
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties123? DeliveringSettlementParties { get; init; } 
    
    /// <summary>
    /// Market Claim Details.
    /// </summary>
    [DisplayName("Market Claim Details")]
    [IsoXmlTag("MktClmDtls")]
    public required CorporateActionOption234 MarketClaimDetails { get; init; } 
    
    /// <summary>
    /// Market Claim Type.
    /// </summary>
    [DisplayName("Market Claim Type")]
    [IsoXmlTag("MktClmTp")]
    public required MarketClaimType1Code MarketClaimType { get; init; } 
    
    /// <summary>
    /// Receiving Settlement Parties.
    /// </summary>
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties124? ReceivingSettlementParties { get; init; } 
    
    /// <summary>
    /// Related Settlement Instruction Details.
    /// </summary>
    [DisplayName("Related Settlement Instruction Details")]
    [IsoXmlTag("RltdSttlmInstrDtls")]
    public required RelatedSettlementInstruction2 RelatedSettlementInstructionDetails { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    /// <summary>
    /// Transaction Reference.
    /// </summary>
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    public required References25 TransactionReference { get; init; } 
    
    
    #nullable disable
    
}


// Since MarketClaimCreationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimCreationV03.

