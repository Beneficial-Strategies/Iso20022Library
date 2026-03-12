// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed description of the items that correspond to the parameters set in a request and for which a report has been generated.
/// </summary>
[IsoId("_Pcav1tp-Ed-ak6NoX_4Aeg_-340644138")]
[DisplayName("Transaction Report Items")]
public partial record TransactionReportItems3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_Pcav19p-Ed-ak6NoX_4Aeg_-340643903")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification assigned by the matching application to the baseline when it is established.
    /// </summary>
    [IsoId("_Pcav2Np-Ed-ak6NoX_4Aeg_-340642293")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public DocumentIdentification3? EstablishedBaselineIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_Pckg0Np-Ed-ak6NoX_4Aeg_-340642912")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required TransactionStatus4 TransactionStatus { get; init; } 
    
    /// <summary>
    /// Reference to the transaction for each financial institution which is a party to the transaction.
    /// </summary>
    [IsoId("_Pckg0dp-Ed-ak6NoX_4Aeg_-340643309")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = new ValueList<DocumentIdentification5>(){};
    
    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_Pckg0tp-Ed-ak6NoX_4Aeg_-340643207")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; } 
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pckg09p-Ed-ak6NoX_4Aeg_-340642397")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentification26 Buyer { get; init; } 
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_Pckg1Np-Ed-ak6NoX_4Aeg_-340642475")]
    [DisplayName("Seller")]
    [IsoXmlTag("Sellr")]
    public required PartyIdentification26 Seller { get; init; } 
    
    /// <summary>
    /// Financial institution of the buyer.
    /// </summary>
    [IsoId("_Pckg1dp-Ed-ak6NoX_4Aeg_-340642817")]
    [DisplayName("Buyer Bank")]
    [IsoXmlTag("BuyrBk")]
    public required BICIdentification1 BuyerBank { get; init; } 
    
    /// <summary>
    /// Country of the buyer bank.
    /// </summary>
    [IsoId("_Pckg1tp-Ed-ak6NoX_4Aeg_-340643808")]
    [DisplayName("Buyer Bank Country")]
    [IsoXmlTag("BuyrBkCtry")]
    public required CountryCode BuyerBankCountry { get; init; } 
    
    /// <summary>
    /// Financial institution of the seller.
    /// </summary>
    [IsoId("_Pckg19p-Ed-ak6NoX_4Aeg_-340641981")]
    [DisplayName("Seller Bank")]
    [IsoXmlTag("SellrBk")]
    public required BICIdentification1 SellerBank { get; init; } 
    
    /// <summary>
    /// Country of the seller bank.
    /// </summary>
    [IsoId("_Pckg2Np-Ed-ak6NoX_4Aeg_-340643748")]
    [DisplayName("Seller Bank Country")]
    [IsoXmlTag("SellrBkCtry")]
    public required CountryCode SellerBankCountry { get; init; } 
    
    /// <summary>
    /// Financial institution that is an obligor bank to the transaction.
    /// </summary>
    [IsoId("_Pckg2dp-Ed-ak6NoX_4Aeg_244469562")]
    [DisplayName("Obligor Bank")]
    [IsoXmlTag("OblgrBk")]
    public BICIdentification1? ObligorBank { get; init; } 
    
    /// <summary>
    /// Financial institution that is a data set submitting bank to the transaction.
    /// </summary>
    [IsoId("_PcuR0Np-Ed-ak6NoX_4Aeg_600025147")]
    [DisplayName("Submitting Bank")]
    [IsoXmlTag("SubmitgBk")]
    public BICIdentification1? SubmittingBank { get; init; } 
    
    /// <summary>
    /// Amount of baseline not yet utilised.
    /// </summary>
    [IsoId("_PcuR0dp-Ed-ak6NoX_4Aeg_-340643843")]
    [DisplayName("Outstanding Amount")]
    [IsoXmlTag("OutsdngAmt")]
    public required CurrencyAndAmount OutstandingAmount { get; init; } 
    
    /// <summary>
    /// Total net amount as specified in the baseline.
    /// </summary>
    [IsoId("_PcuR0tp-Ed-ak6NoX_4Aeg_-783982941")]
    [DisplayName("Total Net Amount")]
    [IsoXmlTag("TtlNetAmt")]
    public required CurrencyAndAmount TotalNetAmount { get; init; } 
    
    /// <summary>
    /// Next processing step required.
    /// </summary>
    [IsoId("_PcuR09p-Ed-ak6NoX_4Aeg_-340643379")]
    [DisplayName("Pending Request For Action")]
    [IsoXmlTag("PdgReqForActn")]
    public PendingActivity2? PendingRequestForAction { get; init; } 
    
    
    #nullable disable
    
}
