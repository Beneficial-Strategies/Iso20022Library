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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MarketClaimCancellationRequestStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarketClaimCancellationRequestStatusAdviceV01( DocumentIdentification9 reqMarketClaimCancellationRequestIdentification,References26 reqTransactionReference,CorporateActionGeneralInformation157 reqCorporateActionGeneralInformation,MarketClaimCancellationRequestStatus1Choice_ reqMarketClaimCancellationRequestStatus )
    {
        MarketClaimCancellationRequestIdentification = reqMarketClaimCancellationRequestIdentification;
        TransactionReference = reqTransactionReference;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        MarketClaimCancellationRequestStatus = reqMarketClaimCancellationRequestStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the related market claim cancellation request document for which the status is provided.
    /// </summary>
    [IsoId("_r6OtoNx3EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmCxlReqId")]
    #endif
    [IsoXmlTag("MktClmCxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification9 MarketClaimCancellationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification9 MarketClaimCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification9 MarketClaimCancellationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification9 MarketClaimCancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_x1AqBNx3EeqESbVR5AloZQ")]
    [DisplayName("Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRef")]
    #endif
    [IsoXmlTag("TxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References26 TransactionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References26 TransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References26 TransactionReference { get; init; } 
    #else
    public References26 TransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_x1AqBdx3EeqESbVR5AloZQ")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation157 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Status information about the processing of the market claim cancellation request.
    /// </summary>
    [IsoId("_7H81ANx3EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Cancellation Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmCxlReqSts")]
    #endif
    [IsoXmlTag("MktClmCxlReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketClaimCancellationRequestStatus1Choice_ MarketClaimCancellationRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketClaimCancellationRequestStatus1Choice_ MarketClaimCancellationRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketClaimCancellationRequestStatus1Choice_ MarketClaimCancellationRequestStatus { get; init; } 
    #else
    public MarketClaimCancellationRequestStatus1Choice_ MarketClaimCancellationRequestStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the related corporate action option and related movements to which the market claim is linked.
    /// </summary>
    [IsoId("_x1AqBtx3EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmDtls")]
    #endif
    [IsoXmlTag("MktClmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption185? MarketClaimDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption185? MarketClaimDetails { get; init; } 
    #else
    public CorporateActionOption185? MarketClaimDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_S5Y80SgaEeuYwc3diVMizA")]
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


// Since MarketClaimCancellationRequestStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimCancellationRequestStatusAdviceV01.

