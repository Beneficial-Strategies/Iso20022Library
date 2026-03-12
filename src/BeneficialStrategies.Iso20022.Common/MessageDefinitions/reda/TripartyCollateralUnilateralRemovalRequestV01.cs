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



namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.074.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// A collateral giver/taker sends a TripartyCollateralFinancialInstrumentRemovalRequest to the Triparty Agent to remove a financial instrument from the collateral pool.
/// 
/// The status of this request is provided with the reda.028 , the CollateralDataStatusAdvice.
/// </summary>
[Description(@"Scope:|A collateral giver/taker sends a TripartyCollateralFinancialInstrumentRemovalRequest to the Triparty Agent to remove a financial instrument from the collateral pool.||The status of this request is provided with the reda.028 , the CollateralDataStatusAdvice.")]
[IsoId("_2uaNRys7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Unilateral Removal Request V")]
public partial record TripartyCollateralUnilateralRemovalRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.074.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollUnltrlRmvlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.074.001.01";
    
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
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaNSSs7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the removal request as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_2uaNSys7EeySlt9bF77XfA")]
    [DisplayName("Removal Request Identification")]
    [IsoXmlTag("RmvlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RemovalRequestIdentification { get; init; } 
    
    /// <summary>
    /// Instructing party sending the removal request.
    /// </summary>
    [IsoId("_2uaNTSs7EeySlt9bF77XfA")]
    [DisplayName("Party A")]
    [IsoXmlTag("PtyA")]
    public required PartyIdentification232 PartyA { get; init; } 
    
    /// <summary>
    /// Party that instructs party A to send the message.
    /// </summary>
    [IsoId("_2uaNTys7EeySlt9bF77XfA")]
    [DisplayName("Client Party A")]
    [IsoXmlTag("ClntPtyA")]
    public PartyIdentification232? ClientPartyA { get; init; } 
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_2uaNUSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public required CollateralRole1Code CollateralSide { get; init; } 
    
    /// <summary>
    /// Details of the request (the request details block is not repetitive to remove some complexity, only one removal request will be possible per message).
    /// </summary>
    [IsoId("_2uaNUys7EeySlt9bF77XfA")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required RequestDetails28 RequestDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNVSs7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since TripartyCollateralUnilateralRemovalRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralUnilateralRemovalRequestV01.

