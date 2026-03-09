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
/// Detailed description of the items that correspond to the parameters set in a request and for which a report has been generated.
/// </summary>
[IsoId("_Pcav1tp-Ed-ak6NoX_4Aeg_-340644138")]
[DisplayName("Transaction Report Items")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionReportItems3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionReportItems3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionReportItems3( System.String reqTransactionIdentification,TransactionStatus4 reqTransactionStatus,DocumentIdentification7 reqPurchaseOrderReference,PartyIdentification26 reqBuyer,PartyIdentification26 reqSeller,BICIdentification1 reqBuyerBank,string reqBuyerBankCountry,BICIdentification1 reqSellerBank,string reqSellerBankCountry,CurrencyAndAmount reqOutstandingAmount,CurrencyAndAmount reqTotalNetAmount )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionStatus = reqTransactionStatus;
        PurchaseOrderReference = reqPurchaseOrderReference;
        Buyer = reqBuyer;
        Seller = reqSeller;
        BuyerBank = reqBuyerBank;
        BuyerBankCountry = reqBuyerBankCountry;
        SellerBank = reqSellerBank;
        SellerBankCountry = reqSellerBankCountry;
        OutstandingAmount = reqOutstandingAmount;
        TotalNetAmount = reqTotalNetAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_Pcav19p-Ed-ak6NoX_4Aeg_-340643903")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_Pcav2Np-Ed-ak6NoX_4Aeg_-340642293")]
    [DisplayName("Established Baseline Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstblishdBaselnId")]
    #endif
    [IsoXmlTag("EstblishdBaselnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    #else
    public DocumentIdentification3? EstablishedBaselineIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_Pckg0Np-Ed-ak6NoX_4Aeg_-340642912")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionStatus4 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionStatus4 TransactionStatus { get; init; } 
    #else
    public TransactionStatus4 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_Pckg0dp-Ed-ak6NoX_4Aeg_-340643309")]
    [DisplayName("User Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrTxRef")]
    #endif
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_Pckg0tp-Ed-ak6NoX_4Aeg_-340643207")]
    [DisplayName("Purchase Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsOrdrRef")]
    #endif
    [IsoXmlTag("PurchsOrdrRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification7 PurchaseOrderReference { get; init; } 
    #else
    public DocumentIdentification7 PurchaseOrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pckg09p-Ed-ak6NoX_4Aeg_-340642397")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Buyer { get; init; } 
    #else
    public PartyIdentification26 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pckg1Np-Ed-ak6NoX_4Aeg_-340642475")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Seller { get; init; } 
    #else
    public PartyIdentification26 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of the buyer.
    /// </summary>
    [IsoId("_Pckg1dp-Ed-ak6NoX_4Aeg_-340642817")]
    [DisplayName("Buyer Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrBk")]
    #endif
    [IsoXmlTag("BuyrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 BuyerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 BuyerBank { get; init; } 
    #else
    public BICIdentification1 BuyerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the buyer bank.
    /// </summary>
    [IsoId("_Pckg1tp-Ed-ak6NoX_4Aeg_-340643808")]
    [DisplayName("Buyer Bank Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrBkCtry")]
    #endif
    [IsoXmlTag("BuyrBkCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode BuyerBankCountry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string BuyerBankCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string BuyerBankCountry { get; init; } 
    #else
    public string BuyerBankCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution of the seller.
    /// </summary>
    [IsoId("_Pckg19p-Ed-ak6NoX_4Aeg_-340641981")]
    [DisplayName("Seller Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrBk")]
    #endif
    [IsoXmlTag("SellrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 SellerBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 SellerBank { get; init; } 
    #else
    public BICIdentification1 SellerBank { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the seller bank.
    /// </summary>
    [IsoId("_Pckg2Np-Ed-ak6NoX_4Aeg_-340643748")]
    [DisplayName("Seller Bank Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SellrBkCtry")]
    #endif
    [IsoXmlTag("SellrBkCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode SellerBankCountry { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SellerBankCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SellerBankCountry { get; init; } 
    #else
    public string SellerBankCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that is an obligor bank to the transaction.
    /// </summary>
    [IsoId("_Pckg2dp-Ed-ak6NoX_4Aeg_244469562")]
    [DisplayName("Obligor Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgrBk")]
    #endif
    [IsoXmlTag("OblgrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? ObligorBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? ObligorBank { get; init; } 
    #else
    public BICIdentification1? ObligorBank { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution that is a data set submitting bank to the transaction.
    /// </summary>
    [IsoId("_PcuR0Np-Ed-ak6NoX_4Aeg_600025147")]
    [DisplayName("Submitting Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgBk")]
    #endif
    [IsoXmlTag("SubmitgBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BICIdentification1? SubmittingBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1? SubmittingBank { get; init; } 
    #else
    public BICIdentification1? SubmittingBank { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of baseline not yet utilised.
    /// </summary>
    [IsoId("_PcuR0dp-Ed-ak6NoX_4Aeg_-340643843")]
    [DisplayName("Outstanding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngAmt")]
    #endif
    [IsoXmlTag("OutsdngAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount OutstandingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount OutstandingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount OutstandingAmount { get; init; } 
    #else
    public CurrencyAndAmount OutstandingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total net amount as specified in the baseline.
    /// </summary>
    [IsoId("_PcuR0tp-Ed-ak6NoX_4Aeg_-783982941")]
    [DisplayName("Total Net Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNetAmt")]
    #endif
    [IsoXmlTag("TtlNetAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount TotalNetAmount { get; init; } 
    #else
    public CurrencyAndAmount TotalNetAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_PcuR09p-Ed-ak6NoX_4Aeg_-340643379")]
    [DisplayName("Pending Request For Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdgReqForActn")]
    #endif
    [IsoXmlTag("PdgReqForActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PendingActivity2? PendingRequestForAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingActivity2? PendingRequestForAction { get; init; } 
    #else
    public PendingActivity2? PendingRequestForAction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
