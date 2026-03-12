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
/// This record is an implementation of the seev.052.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope and Usage
/// The MarketClaimStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope and Usage|The MarketClaimStatusAdvice message is sent by an account servicer to an account holder to provide the status of a market claim transaction.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_W1npgNsFEeqmdMJWobugpw")]
[DisplayName("Market Claim Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarketClaimStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.052.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.052.001.01";
    
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
    /// Constructs a MarketClaimStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarketClaimStatusAdviceV01( References26 reqTransactionReference,CorporateActionGeneralInformation157 reqCorporateActionGeneralInformation,MarketClaimProcessingStatus1Choice_ reqMarketClaimProcessingStatus )
    {
        TransactionReference = reqTransactionReference;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        MarketClaimProcessingStatus = reqMarketClaimProcessingStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("__v67INx2EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Creation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmCreId")]
    #endif
    [IsoXmlTag("MktClmCreId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification9? MarketClaimCreationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification9? MarketClaimCreationIdentification { get; init; } 
    #else
    public DocumentIdentification9? MarketClaimCreationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_LOMVRNx3EeqESbVR5AloZQ")]
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
    [IsoId("_LOM8UNx3EeqESbVR5AloZQ")]
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
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_B_PP4TDNEeunENYTWutRtQ")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification46? AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification46? AccountDetails { get; init; } 
    #else
    public AccountIdentification46? AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Status information about the processing of the market claim transaction.
    /// </summary>
    [IsoId("_VoUx0Nx3EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmPrcgSts")]
    #endif
    [IsoXmlTag("MktClmPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketClaimProcessingStatus1Choice_ MarketClaimProcessingStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketClaimProcessingStatus1Choice_ MarketClaimProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketClaimProcessingStatus1Choice_ MarketClaimProcessingStatus { get; init; } 
    #else
    public MarketClaimProcessingStatus1Choice_ MarketClaimProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the market claim transaction for which a status is provided.
    /// </summary>
    [IsoId("_LOM8Udx3EeqESbVR5AloZQ")]
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
    [IsoId("_ODyf0SgaEeuYwc3diVMizA")]
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


// Since MarketClaimStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimStatusAdviceV01.

