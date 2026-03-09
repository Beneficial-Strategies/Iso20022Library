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
/// This record is an implementation of the seev.050.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope and Usage
/// The MarketClaimCreation message is sent by an account servicer to an account holder to advise of the creation of a market claim transaction on a securities account, for example by a CSD that has automatically generated market claims on a mandatory distribution type of corporate action event. The MarketClaimCreation message may also be sent by an account holder to its account holder, to instruct settlement of a bilaterally agreed (as opposed to centrally generated) market claim for a corporate action event.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope and Usage|The MarketClaimCreation message is sent by an account servicer to an account holder to advise of the creation of a market claim transaction on a securities account, for example by a CSD that has automatically generated market claims on a mandatory distribution type of corporate action event. The MarketClaimCreation message may also be sent by an account holder to its account holder, to instruct settlement of a bilaterally agreed (as opposed to centrally generated) market claim for a corporate action event.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_PT1lANsDEeqmdMJWobugpw")]
[DisplayName("Market Claim Creation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MarketClaimCreationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.050.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MktClmCre";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.050.001.01";
    
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
    /// Constructs a MarketClaimCreationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MarketClaimCreationV01( References25 reqTransactionReference,CorporateActionGeneralInformation157 reqCorporateActionGeneralInformation,RelatedSettlementInstruction1 reqRelatedSettlementInstructionDetails,AccountIdentification46 reqAccountDetails,MarketClaimType1Code reqMarketClaimType,CorporateActionOption185 reqMarketClaimDetails )
    {
        TransactionReference = reqTransactionReference;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        RelatedSettlementInstructionDetails = reqRelatedSettlementInstructionDetails;
        AccountDetails = reqAccountDetails;
        MarketClaimType = reqMarketClaimType;
        MarketClaimDetails = reqMarketClaimDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// References of the transaction for which the securities settlement condition modification is requested.
    /// </summary>
    [IsoId("_0BRJstsYEeqmdMJWobugpw")]
    [DisplayName("Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRef")]
    #endif
    [IsoXmlTag("TxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required References25 TransactionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required References25 TransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public References25 TransactionReference { get; init; } 
    #else
    public References25 TransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_BA078dsPEeqmdMJWobugpw")]
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
    /// Information about the related settlement instruction for which the market claim has been created.
    /// </summary>
    [IsoId("_SOQsMC2sEeuVt5XRmyhHiA")]
    [DisplayName("Related Settlement Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdSttlmInstrDtls")]
    #endif
    [IsoXmlTag("RltdSttlmInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RelatedSettlementInstruction1 RelatedSettlementInstructionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RelatedSettlementInstruction1 RelatedSettlementInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RelatedSettlementInstruction1 RelatedSettlementInstructionDetails { get; init; } 
    #else
    public RelatedSettlementInstruction1 RelatedSettlementInstructionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_GfnaodvlEeqmdMJWobugpw")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification46 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification46 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification46 AccountDetails { get; init; } 
    #else
    public AccountIdentification46 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_uBOHsC2qEeuVt5XRmyhHiA")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction59? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction59? CorporateActionDetails { get; init; } 
    #else
    public CorporateAction59? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Type of market claim creation requested.
    /// </summary>
    [IsoId("_-UDPQC2lEeuVt5XRmyhHiA")]
    [DisplayName("Market Claim Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmTp")]
    #endif
    [IsoXmlTag("MktClmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketClaimType1Code MarketClaimType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketClaimType1Code MarketClaimType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketClaimType1Code MarketClaimType { get; init; } 
    #else
    public MarketClaimType1Code MarketClaimType { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the related corporate action option and related movements to which the market claim is linked.
    /// </summary>
    [IsoId("_Lxm88NsaEeqmdMJWobugpw")]
    [DisplayName("Market Claim Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktClmDtls")]
    #endif
    [IsoXmlTag("MktClmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption185 MarketClaimDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption185 MarketClaimDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption185 MarketClaimDetails { get; init; } 
    #else
    public CorporateActionOption185 MarketClaimDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_otNmFNsZEeqmdMJWobugpw")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties75? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties75? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties75? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_7yIv1NvaEeqmdMJWobugpw")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties75? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties75? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties75? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_hhuxcdsGEeqmdMJWobugpw")]
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


// Since MarketClaimCreationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarketClaimCreationV01.

