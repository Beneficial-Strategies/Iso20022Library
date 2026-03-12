// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the transaction in the authorisation request.
/// </summary>
[IsoId("_Y-phEPwLEeGHDMP28rpT3g_1109146762")]
[DisplayName("Card Payment Transaction Details")]
public partial record CardPaymentTransactionDetails8
{
    #nullable enable
    
    /// <summary>
    /// Amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_Y-phEfwLEeGHDMP28rpT3g_-629455657")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CardAmountAndCurrencyExchange1? Amount { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_Y-phEvwLEeGHDMP28rpT3g_-739980496")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    public IsoMax1025Text? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_Y-phE_wLEeGHDMP28rpT3g_385046417")]
    [DisplayName("Payment Context")]
    [IsoXmlTag("PmtCntxt")]
    public PaymentContext3? PaymentContext { get; init; } 
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_Y-yrAPwLEeGHDMP28rpT3g_-832794042")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    
    /// <summary>
    /// Local date and time of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Y-yrAfwLEeGHDMP28rpT3g_990760651")]
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionDateTime { get; init; } 
    
    /// <summary>
    /// Identification of a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_Y-yrAvwLEeGHDMP28rpT3g_183251499")]
    [DisplayName("Sale Reference Number")]
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceNumber { get; init; } 
    
    /// <summary>
    /// Reason for representment of a card transaction.
    /// </summary>
    [IsoId("_Y-yrA_wLEeGHDMP28rpT3g_-373585340")]
    [DisplayName("Re Presentment Reason")]
    [IsoXmlTag("RePresntmntRsn")]
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_Y-yrBPwLEeGHDMP28rpT3g_-1801982595")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    
    /// <summary>
    /// Identification of the transaction that has to be unique for a time period.
    /// </summary>
    [IsoId("_Y-8cAPwLEeGHDMP28rpT3g_-454629875")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransactionReference { get; init; } 
    
    
    #nullable disable
    
}
