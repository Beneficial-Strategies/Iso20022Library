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
/// This record is an implementation of the colr.003.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MarginCallRequest message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager
/// This message is used to request new collateral at the initiation of an exposure or request additional collateral for an existing exposure. It can also be used to recall collateral upon the collateral giver or its collateral manager&apos;s request.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// When sent by the collateral taker the MarginCallRequest message is used to:
/// - request new collateral at the initiation of an exposure
/// - request additional collateral
/// When sent by the collateral giver the MarginCallRequest message is used to:
/// - request the return of collateral.
/// </summary>
[Description(@"Scope|The MarginCallRequest message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager|This message is used to request new collateral at the initiation of an exposure or request additional collateral for an existing exposure. It can also be used to recall collateral upon the collateral giver or its collateral manager's request.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When sent by the collateral taker the MarginCallRequest message is used to:|- request new collateral at the initiation of an exposure|- request additional collateral|When sent by the collateral giver the MarginCallRequest message is used to:|- request the return of collateral.")]
[IsoId("_CRyfq4FsEeWtPe6Crjmeug")]
[DisplayName("Margin Call Request V")]
public partial record MarginCallRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.003.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.003.001.04";
    
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
    [IsoId("_CRyfrYFsEeWtPe6Crjmeug")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_CRyfr4FsEeWtPe6Crjmeug")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation4 Obligation { get; init; } 
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_CRyfsYFsEeWtPe6Crjmeug")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public Agreement4? Agreement { get; init; } 
    
    /// <summary>
    /// Summation of the call amounts per margin type. It is provided for the purposes of carrying forward for future messages that are used to compare the margin call results to determine whether a call is agreed or full/partially disputed.
    /// </summary>
    [IsoId("_CRyfu4FsEeWtPe6Crjmeug")]
    [DisplayName("Margin Call Result")]
    [IsoXmlTag("MrgnCallRslt")]
    public required MarginCallResult3 MarginCallResult { get; init; } 
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party A.
    /// </summary>
    [IsoId("_CRyfs4FsEeWtPe6Crjmeug")]
    [DisplayName("Margin Details Due To A")]
    [IsoXmlTag("MrgnDtlsDueToA")]
    public MarginCall1? MarginDetailsDueToA { get; init; } 
    
    /// <summary>
    /// Provides details about the margin calculation that would be due to party B.
    /// </summary>
    [IsoId("_CRyftYFsEeWtPe6Crjmeug")]
    [DisplayName("Margin Details Due To B")]
    [IsoXmlTag("MrgnDtlsDueToB")]
    public MarginCall1? MarginDetailsDueToB { get; init; } 
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_CRyft4FsEeWtPe6Crjmeug")]
    [DisplayName("Requirement Details Due To A")]
    [IsoXmlTag("RqrmntDtlsDueToA")]
    public MarginRequirement1Choice_? RequirementDetailsDueToA { get; init; } 
    
    /// <summary>
    /// Amount of expected margin that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_CRyfuYFsEeWtPe6Crjmeug")]
    [DisplayName("Requirement Details Due To B")]
    [IsoXmlTag("RqrmntDtlsDueToB")]
    public MarginRequirement1Choice_? RequirementDetailsDueToB { get; init; } 
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party A by party B or recalled to party A from party B.
    /// </summary>
    [IsoId("_CRyfv4FsEeWtPe6Crjmeug")]
    [DisplayName("Expected Collateral Due To A")]
    [IsoXmlTag("XpctdCollDueToA")]
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToA { get; init; } 
    
    /// <summary>
    /// Provides details about the type of collateral that will be either delivered to party B by party A or recalled to party B from party A.
    /// </summary>
    [IsoId("_CRyfvYFsEeWtPe6Crjmeug")]
    [DisplayName("Expected Collateral Due To B")]
    [IsoXmlTag("XpctdCollDueToB")]
    public ExpectedCollateral2Choice_? ExpectedCollateralDueToB { get; init; } 
    
    /// <summary>
    /// Allows the reporting of the margin requirements for multiple accounts and report a single margin call amount made up of the aggregate of all the individual requirement amounts.
    /// </summary>
    [IsoId("_JCbdwILVEeWrrO9HojbPQA")]
    [DisplayName("Margin Call Details")]
    [IsoXmlTag("MrgnCallDtls")]
    public MarginCall2? MarginCallDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_CRyfwYFsEeWtPe6Crjmeug")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MarginCallRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarginCallRequestV04.

