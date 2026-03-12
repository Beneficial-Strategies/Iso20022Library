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
/// This record is an implementation of the seev.053.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope and Usage
/// The MarketClaimCancellationRequestStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction cancellation request.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope and Usage|The MarketClaimCancellationRequestStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction cancellation request.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_ygQkkNsFEeqmdMJWobugpw")]
[DisplayName("Market Claim Cancellation Request Status Advice V")]
public partial record MarketClaimCancellationRequestStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.053.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmCxlReqStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.053.001.01";
    
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
    /// Identification of the related market claim cancellation request document for which the status is provided.
    /// </summary>
    [IsoId("_r6OtoNx3EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Cancellation Request Identification")]
    [IsoXmlTag("MktClmCxlReqId")]
    public required DocumentIdentification9 MarketClaimCancellationRequestIdentification { get; init; } 
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_x1AqBNx3EeqESbVR5AloZQ")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    public required References26 TransactionReference { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_x1AqBdx3EeqESbVR5AloZQ")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Status information about the processing of the market claim cancellation request.
    /// </summary>
    [IsoId("_7H81ANx3EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Cancellation Request Status")]
    [IsoXmlTag("MktClmCxlReqSts")]
    public required MarketClaimCancellationRequestStatus1Choice_ MarketClaimCancellationRequestStatus { get; init; } 
    
    /// <summary>
    /// Detailed information about the related corporate action option and related movements to which the market claim is linked.
    /// </summary>
    [IsoId("_x1AqBtx3EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Details")]
    [IsoXmlTag("MktClmDtls")]
    public CorporateActionOption185? MarketClaimDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_S5Y80SgaEeuYwc3diVMizA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MarketClaimCancellationRequestStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimCancellationRequestStatusAdviceV01.

