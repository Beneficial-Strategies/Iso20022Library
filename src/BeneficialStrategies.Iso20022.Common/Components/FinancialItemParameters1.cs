// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Regroups identification parameters for trade items.
/// </summary>
[IsoId("_OTgzMjk0-AOSNFX-8224497")]
[DisplayName("Financial Item Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialItemParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialItemParameters1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialItemParameters1( System.String reqIdentifier,System.DateOnly reqIssueDate )
    {
        Identifier = reqIdentifier;
        IssueDate = reqIssueDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of this item relative to the issuing party.
    /// </summary>
    [IsoId("_OTMxOTcx-AOSNFX-0262741")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identifier { get; init; } 
    #else
    public System.String Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date of creation of the item.
    /// </summary>
    [IsoId("_OTgzMjk1-AOSNFX-8224497")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssueDate { get; init; } 
    #else
    public System.DateOnly IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of related items, for example an assignment or an advice.
    /// </summary>
    [IsoId("_OTgzMjk2-AOSNFX-8224497")]
    [DisplayName("Related Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdItm")]
    #endif
    [IsoXmlTag("RltdItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? RelatedItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? RelatedItem { get; init; } 
    #else
    public QualifiedDocumentInformation1? RelatedItem { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the function of the document related to the item.
    /// </summary>
    [IsoId("_OTgzMjk4-AOSNFX-8224498")]
    [DisplayName("Document Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocPurp")]
    #endif
    [IsoXmlTag("DocPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; } 
    #else
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Language used for textual information in item.
    /// </summary>
    [IsoId("_OTgzMjk5-AOSNFX-8224498")]
    [DisplayName("Language Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LangCd")]
    #endif
    [IsoXmlTag("LangCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? LanguageCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LanguageCode { get; init; } 
    #else
    public string? LanguageCode { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issued this list of items.
    /// </summary>
    [IsoId("_OTgzMzAw-AOSNFX-8224498")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    #else
    public QualifiedPartyIdentification1? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Receiving party of this list of items.
    /// </summary>
    [IsoId("_OTgzMzAx-AOSNFX-8224498")]
    [DisplayName("Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcpt")]
    #endif
    [IsoXmlTag("Rcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Recipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Recipient { get; init; } 
    #else
    public QualifiedPartyIdentification1? Recipient { get; set; } 
    #endif
    
    /// <summary>
    /// Party that acts as buyer of the goods or services referred to by the financial item.
    /// </summary>
    [IsoId("_OTgzMzAy-AOSNFX-8224498")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Buyer { get; init; } 
    #else
    public QualifiedPartyIdentification1? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that acts as seller of the goods or services referred to by the financial item.
    /// </summary>
    [IsoId("_OTgzMzAz-AOSNFX-8224498")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? Seller { get; init; } 
    #else
    public QualifiedPartyIdentification1? Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Financial agent for the seller.
    /// </summary>
    [IsoId("_OTgzMzA0-AOSNFX-8224498")]
    [DisplayName("Seller Financial Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrFinAgt")]
    #endif
    [IsoXmlTag("SellrFinAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? SellerFinancialAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? SellerFinancialAgent { get; init; } 
    #else
    public QualifiedPartyIdentification1? SellerFinancialAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Financial agent for the buyer.
    /// </summary>
    [IsoId("_OTgzMzA1-AOSNFX-8224498")]
    [DisplayName("Buyer Financial Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrFinAgt")]
    #endif
    [IsoXmlTag("BuyrFinAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedPartyIdentification1? BuyerFinancialAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedPartyIdentification1? BuyerFinancialAgent { get; init; } 
    #else
    public QualifiedPartyIdentification1? BuyerFinancialAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to contract that governs the exchange of the message.
    /// </summary>
    [IsoId("_OTgzMzA2-AOSNFX-8224498")]
    [DisplayName("Governing Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GovngCtrct")]
    #endif
    [IsoXmlTag("GovngCtrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QualifiedDocumentInformation1? GoverningContract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QualifiedDocumentInformation1? GoverningContract { get; init; } 
    #else
    public QualifiedDocumentInformation1? GoverningContract { get; set; } 
    #endif
    
    /// <summary>
    /// Rules and laws governing the item.
    /// </summary>
    [IsoId("_OTgzMzA3-AOSNFX-8224498")]
    [DisplayName("Legal Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglCntxt")]
    #endif
    [IsoXmlTag("LglCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GovernanceRules2? LegalContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GovernanceRules2? LegalContext { get; init; } 
    #else
    public GovernanceRules2? LegalContext { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the item.
    /// </summary>
    [IsoId("_OTgzMzA4-AOSNFX-8224498")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the account debited for charges (or credited for reimbursement).
    /// </summary>
    [IsoId("_OTgzMzA5-AOSNFX-8224498")]
    [DisplayName("Debit Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtAcct")]
    #endif
    [IsoXmlTag("DbtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    #else
    public AccountIdentification4Choice_? DebitAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the account credited for charges (or debited for reimbursement).
    /// </summary>
    [IsoId("_OTgzMzEw-AOSNFX-8224498")]
    [DisplayName("Credit Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtAcct")]
    #endif
    [IsoXmlTag("CdtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? CreditAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? CreditAccount { get; init; } 
    #else
    public AccountIdentification4Choice_? CreditAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the geographical environment of the trade market.
    /// </summary>
    [IsoId("_OTgzMzEy-AOSNFX-8224498")]
    [DisplayName("Trade Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradMkt")]
    #endif
    [IsoXmlTag("TradMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeMarket1Choice_? TradeMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeMarket1Choice_? TradeMarket { get; init; } 
    #else
    public TradeMarket1Choice_? TradeMarket { get; set; } 
    #endif
    
    
    #nullable disable
    
}
