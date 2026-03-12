// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Regroups identification parameters for trade items.
/// </summary>
[IsoId("_OTgzMjk0-AOSNFX-8224497")]
[DisplayName("Financial Item Parameters")]
public partial record FinancialItemParameters1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of this item relative to the issuing party.
    /// </summary>
    [IsoId("_OTMxOTcx-AOSNFX-0262741")]
    [DisplayName("Identifier")]
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identifier { get; init; } 
    
    /// <summary>
    /// Date of creation of the item.
    /// </summary>
    [IsoId("_OTgzMjk1-AOSNFX-8224497")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; } 
    
    /// <summary>
    /// Identifier of related items, for example an assignment or an advice.
    /// </summary>
    [IsoId("_OTgzMjk2-AOSNFX-8224497")]
    [DisplayName("Related Item")]
    [IsoXmlTag("RltdItm")]
    public QualifiedDocumentInformation1? RelatedItem { get; init; } 
    
    /// <summary>
    /// Specifies the function of the document related to the item.
    /// </summary>
    [IsoId("_OTgzMjk4-AOSNFX-8224498")]
    [DisplayName("Document Purpose")]
    [IsoXmlTag("DocPurp")]
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; } 
    
    /// <summary>
    /// Language used for textual information in item.
    /// </summary>
    [IsoId("_OTgzMjk5-AOSNFX-8224498")]
    [DisplayName("Language Code")]
    [IsoXmlTag("LangCd")]
    public LanguageCode? LanguageCode { get; init; } 
    
    /// <summary>
    /// Party that issued this list of items.
    /// </summary>
    [IsoId("_OTgzMzAw-AOSNFX-8224498")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    
    /// <summary>
    /// Receiving party of this list of items.
    /// </summary>
    [IsoId("_OTgzMzAx-AOSNFX-8224498")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public QualifiedPartyIdentification1? Recipient { get; init; } 
    
    /// <summary>
    /// Party that acts as buyer of the goods or services referred to by the financial item.
    /// </summary>
    [IsoId("_OTgzMzAy-AOSNFX-8224498")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public QualifiedPartyIdentification1? Buyer { get; init; } 
    
    /// <summary>
    /// Party that acts as seller of the goods or services referred to by the financial item.
    /// </summary>
    [IsoId("_OTgzMzAz-AOSNFX-8224498")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public QualifiedPartyIdentification1? Seller { get; init; } 
    
    /// <summary>
    /// Financial agent for the seller.
    /// </summary>
    [IsoId("_OTgzMzA0-AOSNFX-8224498")]
    [DisplayName("Seller Financial Agent")]
    [IsoXmlTag("SellrFinAgt")]
    public QualifiedPartyIdentification1? SellerFinancialAgent { get; init; } 
    
    /// <summary>
    /// Financial agent for the buyer.
    /// </summary>
    [IsoId("_OTgzMzA1-AOSNFX-8224498")]
    [DisplayName("Buyer Financial Agent")]
    [IsoXmlTag("BuyrFinAgt")]
    public QualifiedPartyIdentification1? BuyerFinancialAgent { get; init; } 
    
    /// <summary>
    /// Reference to contract that governs the exchange of the message.
    /// </summary>
    [IsoId("_OTgzMzA2-AOSNFX-8224498")]
    [DisplayName("Governing Contract")]
    [IsoXmlTag("GovngCtrct")]
    public QualifiedDocumentInformation1? GoverningContract { get; init; } 
    
    /// <summary>
    /// Rules and laws governing the item.
    /// </summary>
    [IsoId("_OTgzMzA3-AOSNFX-8224498")]
    [DisplayName("Legal Context")]
    [IsoXmlTag("LglCntxt")]
    public GovernanceRules2? LegalContext { get; init; } 
    
    /// <summary>
    /// Currency of the item.
    /// </summary>
    [IsoId("_OTgzMzA4-AOSNFX-8224498")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Defines the account debited for charges (or credited for reimbursement).
    /// </summary>
    [IsoId("_OTgzMzA5-AOSNFX-8224498")]
    [DisplayName("Debit Account")]
    [IsoXmlTag("DbtAcct")]
    public AccountIdentification4Choice_? DebitAccount { get; init; } 
    
    /// <summary>
    /// Defines the account credited for charges (or debited for reimbursement).
    /// </summary>
    [IsoId("_OTgzMzEw-AOSNFX-8224498")]
    [DisplayName("Credit Account")]
    [IsoXmlTag("CdtAcct")]
    public AccountIdentification4Choice_? CreditAccount { get; init; } 
    
    /// <summary>
    /// Identification of the geographical environment of the trade market.
    /// </summary>
    [IsoId("_OTgzMzEy-AOSNFX-8224498")]
    [DisplayName("Trade Market")]
    [IsoXmlTag("TradMkt")]
    public TradeMarket1Choice_? TradeMarket { get; init; } 
    
    
    #nullable disable
    
}
